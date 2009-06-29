using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class GlobalHeapBuffer : IDisposable
    {
        public GlobalHeapBuffer(int size)
            : base()
        {
            if ((this.size = size) < 1)
                throw new ArgumentException("Size is invalid.", "size");

            this.internalPointer = Marshal.AllocHGlobal(size);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapBuffer(GlobalHeapBuffer previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapBuffer()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private readonly int size = 0;
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeHGlobal(this.internalPointer);

            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IntPtr Address
        {
            get
            {
                if (this.disposed)
                    return IntPtr.Zero;
                else
                    return this.internalPointer;
            }
        }

        public int Size
        {
            get { return this.size; }
        }

        public override string ToString()
        {
            if (this.disposed)
                return IntPtr.Zero.ToString();
            else
                return this.internalPointer.ToString();
        }

        public static implicit operator IntPtr(GlobalHeapBuffer target)
        {
            return target.Address;
        }

        public static implicit operator int(GlobalHeapBuffer target)
        {
            return target.Address.ToInt32();
        }
    }
}
