using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class CoTaskMemoryUnicodeString : IDisposable
    {
        public CoTaskMemoryUnicodeString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public CoTaskMemoryUnicodeString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public CoTaskMemoryUnicodeString(char[] array)
            : this(new String(array))
        {
        }

        public CoTaskMemoryUnicodeString(int length)
            : this(Utilities.CreateEmptyString(length))
        {
        }

        public CoTaskMemoryUnicodeString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToCoTaskMemUni(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryUnicodeString(CoTaskMemoryUnicodeString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryUnicodeString()
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
                return null;
            else
                return Marshal.PtrToStringUni(this.Address);
        }

        public static implicit operator IntPtr(CoTaskMemoryUnicodeString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryUnicodeString(string source)
        {
            return new CoTaskMemoryUnicodeString(source);
        }

        public static implicit operator string(CoTaskMemoryUnicodeString source)
        {
            return source.ToString();
        }
    }
}
