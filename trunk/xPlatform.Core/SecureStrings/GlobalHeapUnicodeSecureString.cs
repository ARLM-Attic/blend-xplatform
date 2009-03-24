using System;
using System.Security;
using System.Runtime.InteropServices;

namespace xPlatform.SecureStrings
{
    public sealed class GlobalHeapUnicodeSecureString : IDisposable
    {
        public GlobalHeapUnicodeSecureString(SecureString originalSecureString)
            : base()
        {
            if (originalSecureString == null)
                throw new ArgumentNullException("originalSecureString");

            this.internalPointer = Marshal.SecureStringToGlobalAllocUnicode(originalSecureString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapUnicodeSecureString(GlobalHeapUnicodeSecureString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapUnicodeSecureString()
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
                return null;
            else
                return Marshal.PtrToStringUni(this.Address);
        }

        public static implicit operator IntPtr(GlobalHeapUnicodeSecureString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapUnicodeSecureString(SecureString source)
        {
            return new GlobalHeapUnicodeSecureString(source);
        }
    }
}
