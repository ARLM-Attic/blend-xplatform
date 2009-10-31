using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class GlobalHeapBuffer<T> : GlobalHeapBuffer
        where T : struct
    {
        public GlobalHeapBuffer(params T[] elements)
            : this(elements.Length)
        {
            this.elements = elements;
        }

        public GlobalHeapBuffer(int elementCount)
            : base(Marshal.SizeOf(typeof(T)) * elementCount)
        {
        }

        public GlobalHeapBuffer()
            : this(1)
        {
        }

        protected override void Dispose(bool disposing)
        {
            this.typedPointer = null;
            base.Dispose(disposing);
        }

        protected override void Initialization()
        {
            this.typedPointer = new Pointer<T>(this.Address);

            if (this.elements != null &&
                this.elements.Length > 0)
            {
                for (int i = 0; i < elements.Length; i++)
                    this.typedPointer[i] = elements[i];
            }
        }

        private Pointer<T> typedPointer;
        private T[] elements;

        public Pointer<T> TypedPointer
        {
            get { return this.typedPointer; }
        }

        public T this[int index]
        {
            get { return this.typedPointer[index]; }
            set { this.typedPointer[index] = value; }
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
