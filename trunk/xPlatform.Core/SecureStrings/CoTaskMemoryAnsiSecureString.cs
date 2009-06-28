using System;
using System.Security;
using System.Runtime.InteropServices;

namespace xPlatform.SecureStrings
{
    public sealed class CoTaskMemoryAnsiSecureString : IDisposable
    {
        public CoTaskMemoryAnsiSecureString(SecureString originalSecureString)
            : base()
        {
            if (originalSecureString == null)
                throw new ArgumentNullException("originalSecureString");

            this.internalPointer = Marshal.SecureStringToCoTaskMemAnsi(originalSecureString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryAnsiSecureString(CoTaskMemoryAnsiSecureString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryAnsiSecureString()
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

        public static implicit operator IntPtr(CoTaskMemoryAnsiSecureString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryAnsiSecureString(SecureString source)
        {
            return new CoTaskMemoryAnsiSecureString(source);
        }
    }
}
