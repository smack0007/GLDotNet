﻿#if WGL

using System;
using System.Runtime.InteropServices;

namespace GLDotNet
{
    public static class WGL
    {
        private const string OpenGL32Library = "opengl32.dll";

        public const uint CONTEXT_MAJOR_VERSION_ARB = 0x2091;
        public const uint CONTEXT_MINOR_VERSION_ARB = 0x2092;
        public const uint CONTEXT_FLAGS_ARB = 0x2094;

        public const int BITSPIXEL = 12;

        public const uint PFD_DOUBLEBUFFER = 0x00000001;
        public const uint PFD_DRAW_TO_WINDOW = 0x00000004;
        public const uint PFD_SUPPORT_OPENGL = 0x00000020;
        public const uint PFD_TYPE_RGBA = 0;
        public const uint PFD_MAIN_PLANE = 0;

        [DllImport(OpenGL32Library, EntryPoint = "wglCreateContext", ExactSpelling = true)]
        public static extern IntPtr CreateContext(IntPtr hDc);

        [DllImport(OpenGL32Library, EntryPoint = "wglDeleteContext", ExactSpelling = true)]
        public static extern bool DeleteContext(IntPtr oldContext);

        [DllImport(OpenGL32Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true)]
        private static extern IntPtr GetProcAddressWgl(string lpszProc);

        [DllImport(OpenGL32Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true)]
        public static extern bool MakeCurrent(IntPtr hDc, IntPtr newContext);

        [DllImport(OpenGL32Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true)]
        public static extern bool SwapBuffers(IntPtr hdc);

        [StructLayout(LayoutKind.Sequential)]
        public struct PixelFormatDescriptor
        {
            public ushort nSize;
            public ushort nVersion;
            public uint dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public uint dwLayerMask;
            public uint dwVisibleMask;
            public uint dwDamageMask;
        }

        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(IntPtr hdc, ref PixelFormatDescriptor ppfd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
        private static extern IntPtr GetModuleHandle(string module);

        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        private static extern IntPtr GetProcAddressWin32(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern int SetPixelFormat(IntPtr hdc, int iPixelFormat, ref PixelFormatDescriptor ppfd);

        public delegate IntPtr _CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int[] attribList);

        private static IntPtr hWnd;
        private static IntPtr hDC;
        private static IntPtr hRC;
        private static IntPtr hModule;

        public static void wglInit(IntPtr hWnd, int versionMajor, int versionMinor)
        {
            WGL.hWnd = hWnd;

            hDC = GetDC(hWnd);

            if (hDC == IntPtr.Zero)
                throw new InvalidOperationException("Could not get a device context (hDC).");

            PixelFormatDescriptor pfd = new PixelFormatDescriptor()
            {
                nSize = (ushort)Marshal.SizeOf(typeof(PixelFormatDescriptor)),
                nVersion = 1,
                dwFlags = (PFD_SUPPORT_OPENGL | PFD_DRAW_TO_WINDOW | PFD_DOUBLEBUFFER),
                iPixelType = (byte)PFD_TYPE_RGBA,
                cColorBits = (byte)GetDeviceCaps(hDC, BITSPIXEL),
                cDepthBits = 32,
                iLayerType = (byte)PFD_MAIN_PLANE
            };

            int pixelformat = ChoosePixelFormat(hDC, ref pfd);

            if (pixelformat == 0)
                throw new InvalidOperationException("Could not find A suitable pixel format.");

            if (SetPixelFormat(hDC, pixelformat, ref pfd) == 0)
                throw new InvalidOperationException("Could not set the pixel format.");

            IntPtr tempContext = CreateContext(hDC);

            if (tempContext == IntPtr.Zero)
                throw new InvalidOperationException("Unable to create temporary render context.");

            if (!MakeCurrent(hDC, tempContext))
                throw new InvalidOperationException("Unable to make temporary render context current.");

            int[] attribs = new int[]
            {
                (int)CONTEXT_MAJOR_VERSION_ARB, versionMajor,
                (int)CONTEXT_MINOR_VERSION_ARB, versionMinor,
                (int)CONTEXT_FLAGS_ARB, (int)0,
                0
            };

            IntPtr proc = GetProcAddressWgl("wglCreateContextAttribsARB");
            _CreateContextAttribsARB createContextAttribs = (_CreateContextAttribsARB)Marshal.GetDelegateForFunctionPointer(proc, typeof(_CreateContextAttribsARB));
            hRC = createContextAttribs(hDC, IntPtr.Zero, attribs);

            MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            DeleteContext(tempContext);

            if (hRC == IntPtr.Zero)
                throw new InvalidOperationException("Unable to create render context.");

            if (!MakeCurrent(hDC, hRC))
                throw new InvalidOperationException("Unable to make render context current.");

            hModule = LoadLibrary(OpenGL32Library);
        }

        public static void wglShutdown()
        {
            MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            DeleteContext(hRC);

            ReleaseDC(hWnd, hDC);
        }

        public static IntPtr wglGetProcAddress(string name)
        {
            IntPtr procAddress = GetProcAddressWgl(name);

            if (procAddress == IntPtr.Zero)
            {
                procAddress = GetProcAddressWin32(hModule, name);
            }

            return procAddress;
        }

        public static void wglMakeCurrent()
        {
            MakeCurrent(hDC, hRC);
        }

        public static void wglSwapBuffers()
        {
            SwapBuffers(hDC);
        }
    }
}

#endif