using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class CoTaskMemBuffer<T> : CoTaskMemBuffer
        where T : struct
    {
        public CoTaskMemBuffer(params T[] elements)
            : this(elements.Length)
        {
            this.typedPointer = new Pointer<T>(this.Address);

            for (int i = 0; i < elements.Length; i++)
                this.typedPointer[i] = elements[i];
        }

        public CoTaskMemBuffer(int elementCount)
            : base(Marshal.SizeOf(typeof(T)) * elementCount)
        {
        }

        public CoTaskMemBuffer()
            : this(1)
        {
        }

        protected override void Dispose(bool disposing)
        {
            this.typedPointer = null;
            base.Dispose(disposing);
        }

        private Pointer<T> typedPointer;

        public Pointer<T> TypedPointer
        {
            get { return this.typedPointer; }
        }

        public T this[int index]
        {
            get { return this.typedPointer[index]; }
            set { this.typedPointer[index] = value; }
        }

        public static implicit operator IntPtr(CoTaskMemBuffer<T> target)
        {
            return target.Address;
        }

        public static implicit operator int(CoTaskMemBuffer<T> target)
        {
            return target.Address.ToInt32();
        }
    }
}
