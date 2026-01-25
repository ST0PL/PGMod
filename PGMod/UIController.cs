using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.Win32;
using System.Numerics;
using System.Runtime.InteropServices;

namespace PGMod
{
    internal static class UIController
    {
        private static nint originalWindowProc;

        private static bool isMenuActive = true;

        private static string[] currencies =
            [
                "Coins",
                "GemsCurrency",
                "ClanSilver",
                "ClanLootBoxPoints",
                "Coupons",
                "PixelPassCurrency",
                "TicketsCurrency"
            ];

        private static string comboBoxString = string.Join('\0', currencies);

        private static int currencyAmount = 1;
        private static int selectedIndex = 0;
        public static unsafe void Initialize()
        {
            D3D11Hook.Initialize(Draw, &WindowProcHook);
            D3D11Hook.OnInitialized += (origWindProc) =>
            {
                originalWindowProc = origWindProc;
                ApplyTheme();
            };
        }

        private static void Draw()
        {
            ImGui.GetIO().MouseDrawCursor = isMenuActive;

            if (!isMenuActive)
                return;

            ImGui.SetNextWindowSize(new Vector2(400, 150), ImGuiCond.Once);
            ApplyTheme();

            if (ImGui.Begin("PGMod by ST0PL", ref isMenuActive, ImGuiWindowFlags.NoResize))
            {
                ImGui.Text($"Currency type");
                ImGui.SetNextItemWidth(-1);
                ImGui.Combo("##Type", ref selectedIndex, comboBoxString);
                ImGui.Text("Amount");
                ImGui.SetNextItemWidth(-1);

                if (ImGui.InputInt("##Amount", ref currencyAmount))
                    currencyAmount = currencyAmount < 1 ? 1 : currencyAmount;

                if (ImGui.Button("Add currency"))
                {
                    IL2cpp.ThreadAttach(IL2cpp.DomainGet());
                    PixelAPI.AddCurrency(currencies[selectedIndex], currencyAmount, Types.CurrencySource.InAppBonus);
                }
            }
            ImGui.End();
        }

        [UnmanagedCallersOnly]
        private static nint WindowProcHook(nint hWnd, uint uMsg, nuint wParam, nint lParam)
        {
            ImGuiImplWin32.WndProcHandler(hWnd, uMsg, wParam, lParam);

            if (isMenuActive)
            {
                WinApi.ClipCursor(IntPtr.Zero); // free cursor

                switch (uMsg)
                {
                    case 0x0201: // WM_LBUTTONDOWN
                    case 0x0202: // WM_LBUTTONUP
                    case 0x0200: // WM_MOUSEMOVE
                        return WinApi.DefWindowProcW(hWnd, uMsg, wParam, lParam);
                }
            }

            //WM_KEYDOWN && VK_NUMPAD0
            if (uMsg == 0x100 && wParam == 0x60)
                isMenuActive = !isMenuActive;

            return WinApi.CallWindowProcW(originalWindowProc, hWnd, uMsg, wParam, lParam);
        }

        private static void ApplyTheme()
        {
            ImGuiStylePtr style = ImGui.GetStyle();
            var colors = style.Colors;

            var purpleAccent = new Vector4(0.61f, 0.00f, 1.00f, 1.00f);
            var purpleHover = new Vector4(0.70f, 0.20f, 1.00f, 1.00f);
            var purpleActive = new Vector4(0.50f, 0.00f, 0.80f, 1.00f);

            style.WindowRounding = 5.0f;
            style.FrameRounding = 3.0f;
            style.PopupRounding = 4.0f;
            style.ScrollbarRounding = 9.0f;
            style.GrabRounding = 3.0f;

            colors[(int)ImGuiCol.Text] = new Vector4(1.00f, 1.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.WindowBg] = new Vector4(0.09f, 0.01f, 0.13f, 0.94f);
            colors[(int)ImGuiCol.Border] = new Vector4(0.43f, 0.43f, 0.50f, 0.50f);

            colors[(int)ImGuiCol.TitleBg] = new Vector4(0.04f, 0.04f, 0.04f, 1.00f);
            colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.33f, 0.16f, 0.48f, 1.00f);

            colors[(int)ImGuiCol.FrameBg] = new Vector4(0.34f, 0.16f, 0.48f, 0.54f);
            colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.61f, 0.00f, 1.00f, 0.40f);
            colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.61f, 0.00f, 1.00f, 0.67f);

            colors[(int)ImGuiCol.PopupBg] = new Vector4(0.08f, 0.08f, 0.08f, 0.94f);
            colors[(int)ImGuiCol.Header] = new Vector4(0.61f, 0.00f, 1.00f, 0.31f);
            colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.61f, 0.00f, 1.00f, 0.80f);
            colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.61f, 0.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.50f, 0.20f, 0.80f, 1.00f);
            colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.61f, 0.00f, 1.00f, 1.00f);

            colors[(int)ImGuiCol.Button] = new Vector4(0.61f, 0.00f, 1.00f, 0.40f);
            colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.61f, 0.00f, 1.00f, 1.00f);
            colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.45f, 0.00f, 0.80f, 1.00f);

            colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.02f, 0.02f, 0.02f, 0.53f);
            colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.31f, 0.31f, 0.31f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.41f, 0.41f, 0.41f, 1.00f);
            colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.51f, 0.51f, 0.51f, 1.00f);
        }
    }
}
