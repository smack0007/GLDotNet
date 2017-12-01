#if WIN32

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace GLDotNet.Samples
{
    internal static class Win32
    {
        public const int COLOR_WINDOW = 5;

        public const int CW_USEDEFULAT = unchecked((int)0x80000000);

        public const int IDC_ARROW = 32512;
        public const int IDC_IBEAM = 32513;
        public const int IDC_WAIT = 32514;
        public const int IDC_CROSS = 32515;
        public const int IDC_UPARROW = 32516;
        public const int IDC_SIZE = 32640;
        public const int IDC_ICON = 32641;
        public const int IDC_SIZENWSE = 32642;
        public const int IDC_SIZENESW = 32643;
        public const int IDC_SIZEWE = 32644;
        public const int IDC_SIZENS = 32645;
        public const int IDC_SIZEALL = 32646;
        public const int IDC_NO = 32648;
        public const int IDC_HAND = 32649;
        public const int IDC_APPSTARTING = 32650;
        public const int IDC_HELP = 32651;

        public const int IDI_APPLICATION = 32512;
        public const int IDI_HAND = 32513;
        public const int IDI_QUESTION = 32514;
        public const int IDI_EXCLAMATION = 32515;
        public const int IDI_ASTERISK = 32516;
        public const int IDI_WINLOGO = 32517;
        public const int IDI_WARNING = IDI_EXCLAMATION;
        public const int IDI_ERROR = IDI_HAND;
        public const int IDI_INFORMATION = IDI_ASTERISK;

        public const int PM_REMOVE = 0x0001;

        public const uint WM_MOVE = 0x0003;
        public const uint WM_SIZE = 0x0005;
        public const uint WM_CLOSE = 0x0010;
        public const uint WM_QUIT = 0x0012;
        public const uint WM_DESTROY = 0x0002;
        public const uint WM_PAINT = 0x000F;
        public const uint WM_ERASEBKGND = 0x0014;
        public const uint WM_KEYDOWN = 0x0100;
        public const uint WM_KEYUP = 0x0101;
        public const uint WM_CHAR = 0x0102;
        public const uint WM_SYSKEYDOWN = 0x0104;
        public const uint WM_SYSKEYUP = 0x0105;
        public const uint WM_UNICHAR = 0x0109;
        public const uint WM_SYSCOMMAND = 0x0112;
        public const uint WM_MOUSEMOVE = 0x0200;
        public const uint WM_LBUTTONDOWN = 0x0201;
        public const uint WM_LBUTTONUP = 0x0202;
        public const uint WM_RBUTTONDOWN = 0x0204;
        public const uint WM_RBUTTONUP = 0x0205;
        public const uint WM_MBUTTONDOWN = 0x0207;
        public const uint WM_MBUTTONUP = 0x0208;
        public const uint WM_ENTERSIZEMOVE = 0x0231;
        public const uint WM_EXITSIZEMOVE = 0x0232;
        public const uint WM_MOUSEHOVER = 0x02A1;
        public const uint WM_MOUSELEAVE = 0x02A3;

        public const uint WS_BORDER = 0x800000;
        public const uint WS_CAPTION = 0xc00000;
        public const uint WS_CHILD = 0x40000000;
        public const uint WS_CLIPCHILDREN = 0x2000000;
        public const uint WS_CLIPSIBLINGS = 0x4000000;
        public const uint WS_DISABLED = 0x8000000;
        public const uint WS_DLGFRAME = 0x400000;
        public const uint WS_GROUP = 0x20000;
        public const uint WS_HSCROLL = 0x100000;
        public const uint WS_MAXIMIZE = 0x1000000;
        public const uint WS_MAXIMIZEBOX = 0x10000;
        public const uint WS_MINIMIZE = 0x20000000;
        public const uint WS_MINIMIZEBOX = 0x20000;
        public const uint WS_OVERLAPPED = 0x0;
        public const uint WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_SIZEFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;
        public const uint WS_POPUP = 0x80000000u;
        public const uint WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU;
        public const uint WS_SIZEFRAME = 0x40000;
        public const uint WS_SYSMENU = 0x80000;
        public const uint WS_TABSTOP = 0x10000;
        public const uint WS_VISIBLE = 0x10000000;
        public const uint WS_VSCROLL = 0x200000;

        public const uint WS_EX_ACCEPTFILES = 0x00000010;
        public const uint WS_EX_APPWINDOW = 0x00040000;
        public const uint WS_EX_CLIENTEDGE = 0x00000200;
        public const uint WS_EX_COMPOSITED = 0x02000000;
        public const uint WS_EX_CONTEXTHELP = 0x00000400;
        public const uint WS_EX_CONTROLPARENT = 0x00010000;
        public const uint WS_EX_DLGMODALFRAME = 0x00000001;
        public const uint WS_EX_LAYERED = 0x00080000;
        public const uint WS_EX_LAYOUTRTL = 0x00400000;
        public const uint WS_EX_LEFT = 0x00000000;
        public const uint WS_EX_LEFTSCROLLBAR = 0x00004000;
        public const uint WS_EX_LTRREADING = 0x00000000;
        public const uint WS_EX_MDICHILD = 0x00000040;
        public const uint WS_EX_NOACTIVATE = 0x08000000;
        public const uint WS_EX_NOINHERITLAYOUT = 0x00100000;
        public const uint WS_EX_NOPARENTNOTIFY = 0x00000004;
        public const uint WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;
        public const uint WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;
        public const uint WS_EX_RIGHT = 0x00001000;
        public const uint WS_EX_RIGHTSCROLLBAR = 0x00000000;
        public const uint WS_EX_RTLREADING = 0x00002000;
        public const uint WS_EX_STATICEDGE = 0x00020000;
        public const uint WS_EX_TOOLWINDOW = 0x00000080;
        public const uint WS_EX_TOPMOST = 0x00000008;
        public const uint WS_EX_TRANSPARENT = 0x00000020;
        public const uint WS_EX_WINDOWEDGE = 0x00000100;

        public const int SC_MINIMIZE = 0xF020;
        public const int SC_RESTORE = 0xF120;

        public const int SW_FORCEMINIMIZE = 11;
        public const int SW_HIDE = 0;
        public const int SW_MAXIMIZE = 3;
        public const int SW_MINIMIZE = 6;
        public const int SW_RESTORE = 9;
        public const int SW_SHOW = 5;
        public const int SW_SHOWDEFAULT = 10;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOWNORMAL = 1;

        public const uint SWP_ASYNCWINDOWPOS = 0x4000;
        public const uint SWP_DEFERERASE = 0x2000;
        public const uint SWP_DRAWFRAME = 0x0020;
        public const uint SWP_FRAMECHANGED = 0x0020;
        public const uint SWP_HIDEWINDOW = 0x0080;
        public const uint SWP_NOACTIVATE = 0x0010;
        public const uint SWP_NOCOPYBITS = 0x0100;
        public const uint SWP_NOMOVE = 0x0002;
        public const uint SWP_NOOWNERZORDER = 0x0200;
        public const uint SWP_NOREDRAW = 0x0008;
        public const uint SWP_NOREPOSITION = 0x0200;
        public const uint SWP_NOSENDCHANGING = 0x0400;
        public const uint SWP_NOSIZE = 0x0001;
        public const uint SWP_NOZORDER = 0x0004;
        public const uint SWP_SHOWWINDOW = 0x0040;

        public const int TME_HOVER = 0x0001;
        public const int TME_LEAVE = 0x0002;

        [StructLayout(LayoutKind.Sequential)]
        public struct MESSAGE
        {
            public IntPtr hWnd;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public POINT p;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public bool fErase;
            public RECT rcPaint;
            public bool fRestore;
            public bool fIncUpdate;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WNDCLASSEX
        {
            public uint cbSize;
            public uint style;
            public WndProc lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance;
            public IntPtr hIcon;
            public IntPtr hCursor;
            public IntPtr hbrBackground;
            public string lpszMenuName;
            public string lpszClassName;
            public IntPtr hIconSm;
        }

        public delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowEx(
           uint dwExStyle,
           uint lpClassName,
           string lpWindowName,
           uint dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           IntPtr hMenu,
           IntPtr hInstance,
           IntPtr lpParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr DispatchMessage(ref MESSAGE msg);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadIcon(IntPtr hInstance, int lpIconName);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool PeekMessage(out MESSAGE msg, IntPtr hWnd, uint messageFilterMin, uint messageFilterMax, uint flags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpwcx);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool TranslateMessage([In] ref MESSAGE msg);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateWindow(IntPtr hWnd);

        public static string GetLastErrorString()
        {
            int lastError = Marshal.GetLastWin32Error();
            return new Win32Exception(lastError).Message;
        }

        public static ushort LowWord(IntPtr value)
        {
            return (ushort)(uint)value;
        }

        public static ushort HighWord(IntPtr value)
        {
            return (ushort)((uint)value >> 16);
        }
    }
}

#endif