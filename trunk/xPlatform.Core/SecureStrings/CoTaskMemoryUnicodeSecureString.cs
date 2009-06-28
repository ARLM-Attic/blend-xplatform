using System;
using System.Security;
using System.Runtime.InteropServices;

namespace xPlatform.SecureStrings
{
    public sealed class CoTaskMemoryUnicodeSecureString : IDisposable
    {
        public CoTaskMemoryUnicodeSecureString(SecureString originalSecureString)
            : base()
        {
            if (originalSecureString == null)
                throw new ArgumentNullException("originalSecureString");

            this.internalPointer = Marshal.SecureStringToCoTaskMemUnicode(originalSecureString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryUnicodeSecureString(CoTaskMemoryUnicodeSecureString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryUnicodeSecureString()
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
                return Marshal.PtrToStringUni(this.Address);
        }

        public static implicit operator IntPtr(CoTaskMemoryUnicodeSecureString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryUnicodeSecureString(SecureString source)
        {
            return new CoTaskMemoryUnicodeSecureString(source);
        }
    }
}
