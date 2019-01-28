using System;
using System.Runtime.InteropServices;

namespace GLDotNet
{
    public static partial class GL
    {
        public static unsafe void glBufferData<T>(uint target, ReadOnlySpan<T> data, uint usage)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(data))
            {
                _glBufferData(target, Marshal.SizeOf<T>() * data.Length, (IntPtr)dataPtr, usage);
            }
        }

        public static unsafe void glBufferSubData<T>(uint target, int offset, ReadOnlySpan<T> data)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(data))
            {
                _glBufferSubData(target, offset, Marshal.SizeOf<T>() * data.Length, (IntPtr)dataPtr);
            }
        }
    }
}
