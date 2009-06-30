using System;
using System.Security;
using System.Runtime.InteropServices;

namespace xPlatform.SecureStrings
{
    public sealed class OleBasicSecureString : IDisposable
    {
        public OleBasicSecureString(SecureString originalSecureString)
            : base()
        {
            if (originalSecureString == null)
                throw new ArgumentNullException("originalSecureString");

            this.internalPointer = Marshal.SecureStringToBSTR(originalSecureString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public OleBasicSecureString(OleBasicSecureString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~OleBasicSecureString()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.ZeroFreeBSTR(this.internalPointer);

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
                return Marshal.PtrToStringBSTR(this.Address);
        }

        public static implicit operator IntPtr(OleBasicSecureString target)
        {
            return target.Address;
        }

        public static implicit operator OleBasicSecureString(SecureString source)
        {
            return new OleBasicSecureString(source);
        }

        public static implicit operator string (OleBasicSecureString source)
        {
            return source.ToString();
        }
    }
}
