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
                _glBufferData(target, Marshal.SizeOf<T>() * data.Length, dataPtr, usage);
            }
        }

        public static unsafe void glBufferSubData<T>(uint target, int offset, ReadOnlySpan<T> data)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(data))
            {
                _glBufferSubData(target, offset, Marshal.SizeOf<T>() * data.Length, dataPtr);
            }
        }

        public static unsafe void glTexImage1D<T>(uint target, int level, int internalformat, int width, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                _glTexImage1D(target, level, internalformat, width, border, format, type, dataPtr);
            }
        }

        public static unsafe void glTexImage2D<T>(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                _glTexImage2D(target, level, internalformat, width, height, border, format, type, dataPtr);
            }
        }

        public static unsafe void glTexImage3D<T>(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T : unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                _glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, dataPtr);
            }
        }
    }
}
