using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class GlobalHeapBuffer : IDisposable
    {
        public GlobalHeapBuffer(int size)
            : base()
        {
            if (size < 1)
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
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeHGlobal(this.internalPointer);

            this.disposed = true;
        }

        void IDisposable.Dispose()
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
    }
}
