#if WIN32

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GLDotNet.Samples
{
    public partial class Sample
    {
        private static Win32.WndProc _windowProc = _StaticWindowProc;
        private static ushort _windowClass;
        private static Dictionary<IntPtr, Sample> _windows = new Dictionary<IntPtr, Sample>();

        private IntPtr _hWnd;
        private int _borderWidth;
        private int _borderHeight;

        private void PlatformInitialize()
        {
            IntPtr hInstance = Win32.GetModuleHandle(null);

            if (_windowClass == 0)
            {
                Win32.WNDCLASSEX wc = new Win32.WNDCLASSEX();
                wc.cbSize = (uint)Marshal.SizeOf(typeof(Win32.WNDCLASSEX));
                wc.style = 0;
                wc.lpfnWndProc = _windowProc;
                wc.cbClsExtra = 0;
                wc.cbWndExtra = 0;
                wc.hInstance = hInstance;
                wc.hIcon = Win32.LoadIcon(IntPtr.Zero, Win32.IDI_APPLICATION);
                wc.hCursor = Win32.LoadCursor(IntPtr.Zero, Win32.IDC_ARROW);
                wc.hbrBackground = (IntPtr)(Win32.COLOR_WINDOW + 1);
                wc.lpszMenuName = null;
                wc.lpszClassName = typeof(Sample).FullName;
                wc.hIconSm = Win32.LoadIcon(IntPtr.Zero, Win32.IDI_APPLICATION);

                _windowClass = Win32.RegisterClassEx(ref wc);

                if (_windowClass == 0)
                    throw new InvalidOperationException($"RegisterClassEx failed: {Win32.GetLastErrorString()}");
            }

            this._hWnd = Win32.CreateWindowEx(
                Win32.WS_EX_APPWINDOW | Win32.WS_EX_WINDOWEDGE,
                _windowClass,
                string.Empty,
                Win32.WS_MINIMIZEBOX | Win32.WS_SYSMENU | Win32.WS_OVERLAPPED | Win32.WS_CAPTION,
                Win32.CW_USEDEFULAT,
                Win32.CW_USEDEFULAT,
                DefaultWidth,
                DefaultHeight,
                IntPtr.Zero,
                IntPtr.Zero,
                hInstance,
                IntPtr.Zero);

            if (this._hWnd == IntPtr.Zero)
                throw new InvalidOperationException($"CreateWindowEx failed: {Win32.GetLastErrorString()}");

            _windows.Add(this._hWnd, this);

            Win32.RECT clientRect;
            Win32.GetClientRect(this._hWnd, out clientRect);

            this._borderWidth = DefaultWidth - clientRect.right;
            this._borderHeight = DefaultHeight - clientRect.bottom;

            Win32.SetWindowPos(this._hWnd, IntPtr.Zero, 0, 0, DefaultWidth + this._borderWidth, DefaultHeight + this._borderHeight, Win32.SWP_NOMOVE | Win32.SWP_NOZORDER);
        }

        private static IntPtr _StaticWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            Sample window;
            if (_windows.TryGetValue(hWnd, out window))
                return window._WindowProc(msg, wParam, lParam);

            return Win32.DefWindowProc(hWnd, msg, wParam, lParam);
        }

        private IntPtr _WindowProc(uint msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case Win32.WM_MOVE:
                    this.TriggerPositionChanged(Win32.LowWord(lParam), Win32.HighWord(lParam));
                    break;

                case Win32.WM_SIZE:
                    int clientWidth = Win32.LowWord(lParam);
                    int clientHeight = Win32.HighWord(lParam);
                    this.TriggerSizeChanged(clientWidth, clientHeight);
                    break;

                case Win32.WM_CLOSE:
                    if (this.TriggerClose())
                    {
                        Win32.DestroyWindow(this._hWnd);
                    }
                    break;
            }

            return Win32.DefWindowProc(this._hWnd, msg, wParam, lParam);
        }

        private void PlatformDispose(bool disposing)
        {
            _windows.Remove(this._hWnd);

            if (disposing)
            {
                if (this._hWnd != IntPtr.Zero)
                {
                    Win32.DestroyWindow(this._hWnd);
                }
            }
        }

        private IntPtr PlatformGetHandle()
        {
            return this._hWnd;
        }

        private void PlatformSetTitle(string title)
        {
            Win32.SetWindowText(this._hWnd, title);
        }

        private void PlatformSetPosition(int x, int y)
        {
            Win32.SetWindowPos(this._hWnd, IntPtr.Zero, x, y, 0, 0, Win32.SWP_NOSIZE | Win32.SWP_NOZORDER);
        }

        private void PlatformSetSize(int width, int height)
        {
            Win32.SetWindowPos(this._hWnd, IntPtr.Zero, 0, 0, width, height, Win32.SWP_NOMOVE | Win32.SWP_NOZORDER);
        }

        private void PlatformShow()
        {
            Win32.ShowWindow(this._hWnd, Win32.SW_SHOWNORMAL);
            Win32.UpdateWindow(this._hWnd);
        }

        private void PlatformHide()
        {
            Win32.ShowWindow(this._hWnd, Win32.SW_HIDE);
        }

        private void PlatformPollEvents()
        {
            Win32.MESSAGE message;

            while (Win32.PeekMessage(out message, IntPtr.Zero, 0, 0, Win32.PM_REMOVE))
            {
                Win32.TranslateMessage(ref message);
                Win32.DispatchMessage(ref message);
            }
        }
    }
}

#endif