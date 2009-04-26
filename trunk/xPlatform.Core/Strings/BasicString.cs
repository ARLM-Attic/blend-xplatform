using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class BasicString : IDisposable
    {
        public BasicString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public BasicString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public BasicString(char[] array)
            : this(new String(array))
        {
        }

        public BasicString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToBSTR(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public BasicString(BasicString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~BasicString()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeBSTR(this.internalPointer);

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
                return Marshal.PtrToStringBSTR(this.Address);
        }

        public static implicit operator IntPtr(BasicString target)
        {
            return target.Address;
        }

        public static implicit operator BasicString(string source)
        {
            return new BasicString(source);
        }

        public static implicit operator string(BasicString source)
        {
            return source.ToString();
        }
    }
}
