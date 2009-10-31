using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class OleBasicString : IDisposable
    {
        public OleBasicString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public OleBasicString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public OleBasicString(char[] array)
            : this(new String(array))
        {
        }

        public OleBasicString(int length)
            : this(new String(Constants.NullCharacter, length))
        {
        }

        public OleBasicString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToBSTR(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public OleBasicString(OleBasicString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~OleBasicString()
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

        public static implicit operator int(OleBasicString target)
        {
            return target.Address.ToInt32();
        }

        public static implicit operator IntPtr(OleBasicString target)
        {
            return target.Address;
        }

        public static implicit operator OleBasicString(string source)
        {
            return new OleBasicString(source);
        }

        public static implicit operator string(OleBasicString source)
        {
            return source.ToString();
        }
    }
}
