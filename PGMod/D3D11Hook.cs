using Hexa.NET.D3D11;
using Hexa.NET.D3DCommon;
using Hexa.NET.DXGI;
using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backends_ID3D11Device = Hexa.NET.ImGui.Backends.D3D11.ID3D11Device;
using Backends_ID3D11DeviceContext = Hexa.NET.ImGui.Backends.D3D11.ID3D11DeviceContext;
using ID3D11DeviceContextPtr = Hexa.NET.ImGui.Backends.D3D11.ID3D11DeviceContextPtr;
using ID3D11DevicePtr = Hexa.NET.ImGui.Backends.D3D11.ID3D11DevicePtr;

namespace PGMod
{
    internal static unsafe class D3D11Hook
    {
        private static bool isInitialized;
        private static ID3D11Device* device;
        private static ID3D11DeviceContext* context;
        private static ID3D11RenderTargetView* renderTargetView;

        public delegate void InitializedDelegate(nint originalWndProc);
        public delegate void DrawDelegate();
        
        public static nint hWindowProc;
        public static event DrawDelegate? OnDraw;
        public static event InitializedDelegate? OnInitialized;

        private static delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, int> OriginalPresent;
        public static void Initialize(DrawDelegate drawDelegate, delegate* unmanaged<nint, uint, nuint, nint, nint> hWndProc)
        {
            if (!isInitialized)
            {
                OnDraw += drawDelegate;
                hWindowProc = (nint)hWndProc;

                PatchVTable(GetSwapChainVTable());
            }
        }
        private static void PatchVTable(nint* vtable)
        {
            nint presentAddr = vtable[8];

            OriginalPresent = (delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, int>)presentAddr;
            WinApi.VirtualProtect((nint)(&vtable[8]), (nuint)IntPtr.Size, WinApi.PAGE_EXECUTE_READWRITE, out var oldProtect);

            vtable[8] = (nint)(delegate* unmanaged[Stdcall]<IDXGISwapChain*, uint, uint, int>)&PresentHook;

            WinApi.VirtualProtect((nint)(&vtable[8]), (nuint)IntPtr.Size, oldProtect, out _);
        }

        private static nint* GetSwapChainVTable()
        {
            var wClass = new WinApi.WNDCLASSW()
            {
                lpfnWndProc = &DummyWindowProcHook,
                hInstance = WinApi.GetModuleHandleW(null),
                lpszClassName = Marshal.StringToHGlobalUni("win")

            };

            WinApi.RegisterClassW(ref wClass);

            nint hWnd = WinApi.CreateWindowExW(
                0, "win", "win",
                WinApi.WS_OVERLAPPEDWINDOW, 0, 0, 100, 100,
                IntPtr.Zero, IntPtr.Zero, WinApi.GetModuleHandleW(null), IntPtr.Zero);


            Marshal.FreeHGlobal(wClass.lpszClassName);

            IDXGISwapChain* swapChain;
            ID3D11Device* device;
            ID3D11DeviceContext* deviceContext;

            var swapChainDesc = new SwapChainDesc()
            {
                Windowed = true,
                OutputWindow = hWnd,
                BufferCount = 2,
                SwapEffect = SwapEffect.Discard,
                Flags = (uint)SwapChainFlag.AllowModeSwitch,
                BufferDesc = new()
                {
                    Width = 100,
                    Height = 100,
                    Format = Format.R8G8B8A8Unorm
                },
                SampleDesc = new() { Count = 1, Quality = 0 }
            };

            var hResult = D3D11.CreateDeviceAndSwapChain(
                (IDXGIAdapter*)null,
                DriverType.Hardware,
                IntPtr.Zero,
                0,
                (FeatureLevel*)null, 0,
                D3D11.D3D11_SDK_VERSION,
                &swapChainDesc,
                &swapChain,
                &device,
                null,
                &deviceContext);

            nint* vtable = *(nint**)swapChain;

            swapChain->Release();
            device->Release();
            deviceContext->Release();

            WinApi.DestroyWindow(hWnd);

            return vtable;
        }


        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
        public static int PresentHook(IDXGISwapChain* swapChain, uint syncInterval, uint flags)
        {
            if (!isInitialized)
                isInitialized = ImGuiInitialize(swapChain);

            SwapChainDesc scDesc = default;

            swapChain->GetDesc(&scDesc);

            Viewport viewport;
            viewport.TopLeftX = 0;
            viewport.TopLeftY = 0;
            viewport.Width = scDesc.BufferDesc.Width;
            viewport.Height = scDesc.BufferDesc.Height;
            viewport.MinDepth = 0.0f;
            viewport.MaxDepth = 1.0f;
            context->RSSetViewports(1, &viewport);

            context->OMSetRenderTargets(1, ref renderTargetView, null);

            Hexa.NET.ImGui.Backends.D3D11.ImGuiImplD3D11.NewFrame();
            Hexa.NET.ImGui.Backends.Win32.ImGuiImplWin32.NewFrame();
            ImGui.NewFrame();

            OnDraw?.Invoke();

            ImGui.Render();
            Hexa.NET.ImGui.Backends.D3D11.ImGuiImplD3D11.RenderDrawData(ImGui.GetDrawData());

            return OriginalPresent(swapChain, syncInterval, flags);
        }

        private static bool ImGuiInitialize(IDXGISwapChain* swapChain)
        {
            SwapChainDesc swapChainDesc;
            ID3D11Device* device;
            ID3D11DeviceContext* context;
            ID3D11Texture2D* backBuffer;
            ID3D11RenderTargetView* renderTargetView;
            swapChain->GetDesc(&swapChainDesc);

            Guid deviceUuid = ID3D11Device.Guid;
            swapChain->GetDevice(&deviceUuid, (void**)&device);

            device->GetImmediateContext(&context);

            Guid bufferUuid = ID3D11Texture2D.Guid;
            swapChain->GetBuffer(0, &bufferUuid, (void**)&backBuffer);

            device->CreateRenderTargetView((ID3D11Resource*)backBuffer, null, &renderTargetView);

            backBuffer->Release();

            ID3D11DevicePtr devicePtr = new() { Handle = (Backends_ID3D11Device*)device };
            ID3D11DeviceContextPtr contextPtr = new() { Handle = (Backends_ID3D11DeviceContext*)context };


            ImGuiImpl.SetCurrentContext(ImGui.CreateContext());


            Hexa.NET.ImGui.Backends.Win32.ImGuiImplWin32.Init((void*)swapChainDesc.OutputWindow);
            Hexa.NET.ImGui.Backends.D3D11.ImGuiImplD3D11.Init(devicePtr, contextPtr);

            var originalWndProc = WinApi.SetWindowLongPtrW(
                                    swapChainDesc.OutputWindow,
                                    WinApi.GWLP_WNDPROC,
                                    hWindowProc);

            D3D11Hook.device = device;
            D3D11Hook.context = context;
            D3D11Hook.renderTargetView = renderTargetView;

            ImGui.GetIO().Fonts.AddFontFromFileTTF(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf"),
                15.0f);


            OnInitialized?.Invoke(originalWndProc);

            return true;
        }

        [UnmanagedCallersOnly]
        public static nint DummyWindowProcHook(nint hWnd, uint uMsg, nuint wParam, nint lParam)
            => WinApi.DefWindowProcW(hWnd, uMsg, wParam, lParam);
    }
}
