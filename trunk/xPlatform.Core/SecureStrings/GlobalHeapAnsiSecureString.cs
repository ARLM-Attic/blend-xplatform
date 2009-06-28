using System;
using System.Security;
using System.Runtime.InteropServices;

namespace xPlatform.SecureStrings
{
    public sealed class GlobalHeapAnsiSecureString : IDisposable
    {
        public GlobalHeapAnsiSecureString(SecureString originalSecureString)
            : base()
        {
            if (originalSecureString == null)
                throw new ArgumentNullException("originalSecureString");

            this.internalPointer = Marshal.SecureStringToGlobalAllocAnsi(originalSecureString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapAnsiSecureString(GlobalHeapAnsiSecureString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapAnsiSecureString()
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

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAnsi(this.Address);
        }

        public static implicit operator IntPtr(GlobalHeapAnsiSecureString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapAnsiSecureString(SecureString source)
        {
            return new GlobalHeapAnsiSecureString(source);
        }
    }
}
