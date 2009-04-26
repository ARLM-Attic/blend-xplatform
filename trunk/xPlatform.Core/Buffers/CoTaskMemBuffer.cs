using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class CoTaskMemBuffer : IDisposable
    {
        public CoTaskMemBuffer(int size)
            : base()
        {
            if (size < 1)
                throw new ArgumentException("Size is invalid.", "size");

            this.internalPointer = Marshal.AllocCoTaskMem(size);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemBuffer(CoTaskMemBuffer previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemBuffer()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeCoTaskMem(this.internalPointer);

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

        public static implicit operator IntPtr(CoTaskMemBuffer target)
        {
            return target.Address;
        }
    }
}
