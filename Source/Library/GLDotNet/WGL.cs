using System;
using System.Runtime.InteropServices;

namespace GLDotNet
{
    public class WGL : IGLPlatformContext
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

        private IntPtr hWnd;
        private IntPtr hDC;
        private IntPtr hRC;
        private IntPtr hModule;

        public int VersionMajor { get; }

        public int VersionMinor { get; }

        public WGL(IntPtr hWnd, int versionMajor, int versionMinor)
        {
            this.hWnd = hWnd;

            this.hDC = GetDC(this.hWnd);

            if (this.hDC == IntPtr.Zero)
                throw new InvalidOperationException("Could not get a device context (hDC).");

            PixelFormatDescriptor pfd = new PixelFormatDescriptor()
            {
                nSize = (ushort)Marshal.SizeOf(typeof(PixelFormatDescriptor)),
                nVersion = 1,
                dwFlags = (PFD_SUPPORT_OPENGL | PFD_DRAW_TO_WINDOW | PFD_DOUBLEBUFFER),
                iPixelType = (byte)PFD_TYPE_RGBA,
                cColorBits = (byte)GetDeviceCaps(this.hDC, BITSPIXEL),
                cDepthBits = 32,
                iLayerType = (byte)PFD_MAIN_PLANE
            };

            int pixelformat = ChoosePixelFormat(this.hDC, ref pfd);

            if (pixelformat == 0)
                throw new InvalidOperationException("Could not find A suitable pixel format.");

            if (SetPixelFormat(this.hDC, pixelformat, ref pfd) == 0)
                throw new InvalidOperationException("Could not set the pixel format.");

            IntPtr tempContext = CreateContext(this.hDC);

            if (tempContext == IntPtr.Zero)
                throw new InvalidOperationException("Unable to create temporary render context.");

            if (!MakeCurrent(this.hDC, tempContext))
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
            this.hRC = createContextAttribs(this.hDC, IntPtr.Zero, attribs);

            MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            DeleteContext(tempContext);

            if (this.hRC == IntPtr.Zero)
                throw new InvalidOperationException("Unable to create render context.");

            if (!MakeCurrent(this.hDC, this.hRC))
                throw new InvalidOperationException("Unable to make render context current.");

            this.hModule = LoadLibrary(OpenGL32Library);

            this.VersionMajor = versionMajor;
            this.VersionMinor = versionMinor;
        }

        public void Dispose()
        {
            MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            DeleteContext(this.hRC);

            ReleaseDC(this.hWnd, this.hDC);
        }

        public IntPtr GetProcAddress(string name)
        {
            IntPtr procAddress = GetProcAddressWgl(name);

            if (procAddress == IntPtr.Zero)
            {
                procAddress = GetProcAddressWin32(this.hModule, name);
            }

            return procAddress;
        }

        public void MakeCurrent()
        {
            MakeCurrent(this.hDC, this.hRC);
        }

        public void SwapBuffers()
        {
            SwapBuffers(this.hDC);
        }
    }
}
