using System.Runtime.InteropServices;

namespace PGMod
{
    internal unsafe static partial class WinApi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct WNDCLASSW
        {
            public uint style;
            public delegate* unmanaged<nint, uint, nuint, nint, nint> lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public nint hInstance;
            public nint hIcon;
            public nint hCursor;
            public nint hbrBackground;
            public nint lpszMenuName;
            public nint lpszClassName;
        }


        [LibraryImport("user32.dll", SetLastError = true)]
        public static partial ushort RegisterClassW(ref WNDCLASSW lpWndClass);

        [LibraryImport("user32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint CreateWindowExW(
            uint dwExStyle,
            string lpClassName,
            string lpWindowName,
            uint dwStyle,
            int X,
            int Y,
            int nWidth,
            int nHeight,
            nint hWndParent,
            nint hMenu,
            nint hInstance,
            nint lpParam);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool DestroyWindow(nint hWnd);

        [LibraryImport("user32.dll")]
        public static partial nint DefWindowProcW(nint hWnd, uint uMsg, nuint wParam, nint lParam);

        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool AllocConsole();

        [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint GetModuleHandleW(string? lpModuleName);

        [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf8)]
        public static partial nint GetProcAddress(nint hModule, string lpProcName);

        [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint LoadLibraryW(string lpLibName);

        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool VirtualFree(nint lpAddress, uint dwSize, uint dwFreeType);

        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool VirtualProtect(
            nint lpAddress,
            nuint dwSize,
            uint flNewProtect,
            out uint lpflOldProtect
        );

        [LibraryImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool IsWindow(nint hWnd);

        [LibraryImport("user32.dll", SetLastError = true)]
        public static partial nint SetWindowLongPtrW(nint hWnd, int nIndex, nint dwNewLong);

        [LibraryImport("user32.dll", SetLastError = true)]
        public static partial int CallWindowProcW(nint lpPrevWndFunc, nint hWnd, uint Msg, nuint wParam, nint lParam);

        [LibraryImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool ClipCursor(nint lpRect);


        public const uint MEM_RELEASE = 0x00008000;
        public const uint WS_OVERLAPPEDWINDOW = 0x00CF0000;
        public const uint WS_DISABLED = 0x08000000;
        public const uint WS_VISIBLE = 0x10000000;
        public const uint CW_USEDEFAULT = 0x80000000u;
        public const int SW_HIDE = 0;
        public const uint PAGE_EXECUTE_READWRITE = 0x40;
        public const int GWLP_WNDPROC = -4;

    }
}
