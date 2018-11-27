using System;
using System.Runtime.InteropServices;
using static HelloWGL.Win32;
using static GLDotNet.GL;
using static GLDotNet.WGL;

namespace HelloWGL
{
    class Program
    {
        private static readonly string WindowClass = "HelloWGLWindow";

        public static void Main(string[] args)
        {
            var wndClass = new WNDCLASSEX();
            wndClass.cbSize = (uint)Marshal.SizeOf(wndClass);
            wndClass.hInstance = GetModuleHandle(null);
            wndClass.lpfnWndProc = WndProc;
            wndClass.lpszClassName = WindowClass;
            wndClass.hCursor = LoadCursor(IntPtr.Zero, IDC_ARROW);

            var @class = RegisterClassEx(ref wndClass);

            var window = CreateWindowEx(
                WS_EX_APPWINDOW,
                WindowClass,
                "Hello WGL",
                WS_OVERLAPPEDWINDOW,
                0,
                0,
                800,
                600,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero);

            wglInit(window, 4, 0);
            glInit(wglGetProcAddress, 4, 0);
            glClearColor(1.0f, 0, 1.0f, 1.0f);

            ShowWindow(window, SW_SHOWNORMAL);

            bool running = true;

            while (running)
            {
                if (PeekMessage(out MSG message, IntPtr.Zero, 0, 0, PM_REMOVE))
                {
                    switch (message.msg)
                    {
                        case WM_QUIT:
                            running = false;
                            break;
                    }

                    TranslateMessage(ref message);
                    DispatchMessage(ref message);
                }
                else
                {
                    // TODO: Game loop
                }
            }
        }

        private static IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case WM_DESTROY:
                    PostQuitMessage(0);
                    break;

                case WM_PAINT:
                    glClear(GL_COLOR_BUFFER_BIT);
                    wglSwapBuffers();
                    break;
            }

            return DefWindowProc(hWnd, msg, wParam, lParam);
        }
    }
}
