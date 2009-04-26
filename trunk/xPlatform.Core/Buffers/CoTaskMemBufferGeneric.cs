using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class CoTaskMemBuffer<T> : CoTaskMemBuffer
    {
        public CoTaskMemBuffer(int elementCount)
            : base(Marshal.SizeOf(typeof(T)) * elementCount)
        {
        }

        public CoTaskMemBuffer()
            : this(1)
        {
        }

        public static implicit operator IntPtr(CoTaskMemBuffer<T> target)
        {
            return target.Address;
        }
    }
}
