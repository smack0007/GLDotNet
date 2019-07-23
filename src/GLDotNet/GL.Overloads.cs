﻿using System;
using System.Runtime.InteropServices;

namespace GLDotNet
{
    public static unsafe partial class GL
    {
        public static void glBufferData(uint target, int size, IntPtr data, uint usage)
        {
            glBufferData(target, size, data.ToPointer(), usage);
        }

        public static void glBufferData<T>(uint target, int size, T[] data, uint usage)
            where T: unmanaged
        {
            fixed (void* dataPtr = data)
            {
                glBufferData(target, size, dataPtr, usage);
            }
        }

        public static void glDeleteBuffer(uint buffer)
        {
            glDeleteBuffers(1, (uint*)buffer);
        }

        public static void glDeleteTexture(uint texture)
        {
            glDeleteVertexArrays(1, (uint*)texture);
        }

        public static void glDeleteVertexArray(uint vertexArray)
        {
            glDeleteVertexArrays(1, (uint*)vertexArray);
        }

        public static void glDrawElements(uint mode, int count, uint type, IntPtr indices)
        {
            glDrawElements(mode, count, type, indices.ToPointer());
        }

        public static uint glGenBuffer()
        {
            uint buffer;
            glGenBuffers(1, &buffer);
            return buffer;
        }

        public static uint glGenTexture()
        {
            uint texture;
            glGenTextures(1, &texture);
            return texture;
        }

        public static uint glGenVertexArray()
        {
            uint vertexArray;
            glGenVertexArrays(1, &vertexArray);
            return vertexArray;
        }

        public static void glGetIntegerv(uint pname, ref int data)
        {
            fixed (int* dataPtr = &data)
            {
                glGetIntegerv(pname, dataPtr);
            }
        }

        public static int glGetProgrami(uint program, uint pname)
        {
            int param = 0;
            glGetProgramiv(program, pname, &param);
            return param;
        }

        public static int glGetShaderi(uint shader, uint pname)
        {
            int param = 0;
            glGetShaderiv(shader, pname, &param);
            return param;
        }

        public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
        {
            glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels.ToPointer());
        }

        public static void glUniformMatrix4fv(int location, int count, bool transpose, ref float value)
        {
            fixed (float* valuePtr = &value)
            {
                glUniformMatrix4fv(location, count, transpose, valuePtr);
            }
        }

        public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer)
        {
            glVertexAttribPointer(index, size, type, normalized, stride, pointer.ToPointer());
        }

#if !GLDOTNET_EXCLUDE_SYSTEM_MEMORY
        public static void glBufferData<T>(uint target, ReadOnlySpan<T> data, uint usage)
            where T: unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(data))
            {
                glBufferData(target, Marshal.SizeOf<T>() * data.Length, dataPtr, usage);
            }
        }

        public static unsafe void glBufferSubData<T>(uint target, int offset, ReadOnlySpan<T> data)
            where T: unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(data))
            {
                glBufferSubData(target, offset, Marshal.SizeOf<T>() * data.Length, dataPtr);
            }
        }

        public static unsafe void glTexImage1D<T>(uint target, int level, int internalformat, int width, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T: unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                glTexImage1D(target, level, internalformat, width, border, format, type, dataPtr);
            }
        }

        public static unsafe void glTexImage2D<T>(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T: unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                glTexImage2D(target, level, internalformat, width, height, border, format, type, dataPtr);
            }
        }

        public static unsafe void glTexImage3D<T>(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, ReadOnlySpan<T> pixels)
            where T: unmanaged
        {
            fixed (void* dataPtr = &MemoryMarshal.GetReference(pixels))
            {
                glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, dataPtr);
            }
        }
#endif
    }
}
