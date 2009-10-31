using System;
using System.Runtime.InteropServices;

namespace xPlatform.Buffers
{
    public class CoTaskMemBuffer : IDisposable
    {
        public CoTaskMemBuffer(int size)
            : base()
        {
            if ((this.size = size) < 1)
                throw new ArgumentException("Size is invalid.", "size");

            this.internalPointer = Marshal.AllocCoTaskMem(size);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");

            this.Initialization();
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

        protected virtual void Initialization() { }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private readonly int size = 0;
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeCoTaskMem(this.internalPointer);

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

        public static implicit operator IntPtr(CoTaskMemBuffer target)
        {
            return target.Address;
        }

        public static implicit operator int(CoTaskMemBuffer target)
        {
            return target.Address.ToInt32();
        }
    }
}
