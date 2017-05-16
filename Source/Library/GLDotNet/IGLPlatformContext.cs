using System;

namespace GLDotNet
{
    public interface IGLPlatformContext : IDisposable
    {
        int VersionMajor { get; }

        int VersionMinor { get; }

        IntPtr GetProcAddress(string name);

        void MakeCurrent();

        void SwapBuffers();
    }
}
