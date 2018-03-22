using System;
using System.Runtime.InteropServices;

namespace GLDotNet.Samples
{
    public struct MemoryBlock : IDisposable
    {
        private GCHandle gcHandle;

        public IntPtr DataPointer { get; private set; }

        public int Length { get; private set; }

        public static MemoryBlock Create<T>(T[] data)
            where T : struct
        {
            return Create<T>(data, 0, data.Length);
        }

        public static MemoryBlock Create<T>(T[] data, int offset, int length)
            where T : struct
        {
            MemoryBlock block = new MemoryBlock();

            int sizeOfT = Marshal.SizeOf(typeof(T));
            block.gcHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
            block.DataPointer = IntPtr.Add(block.gcHandle.AddrOfPinnedObject(), offset * sizeOfT);
            block.Length = length * sizeOfT;

            return block;
        }

        public void Dispose()
        {
            this.gcHandle.Free();
        }
    }
}
