using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class GlobalHeapBuffer<T> : GlobalHeapBuffer
    {
        public GlobalHeapBuffer(int elementCount)
            : base(Marshal.SizeOf(typeof(T)) * elementCount)
        {
        }

        public GlobalHeapBuffer()
            : this(1)
        {
        }

        public static implicit operator IntPtr(GlobalHeapBuffer<T> target)
        {
            return target.Address;
        }

        public static implicit operator int(GlobalHeapBuffer<T> target)
        {
            return target.Address.ToInt32();
        }
    }
}
