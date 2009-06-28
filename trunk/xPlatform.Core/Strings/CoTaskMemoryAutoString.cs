using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class CoTaskMemoryAutoString : IDisposable
    {
        public CoTaskMemoryAutoString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public CoTaskMemoryAutoString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public CoTaskMemoryAutoString(char[] array)
            : this(new String(array))
        {
        }

        public CoTaskMemoryAutoString(int length)
            : this(Utilities.CreateWhitespaceString(length))
        {
        }

        public CoTaskMemoryAutoString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToCoTaskMemAuto(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryAutoString(CoTaskMemoryAutoString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryAutoString()
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
                return Marshal.PtrToStringAuto(this.Address);
        }

        public static implicit operator IntPtr(CoTaskMemoryAutoString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryAutoString(string source)
        {
            return new CoTaskMemoryAutoString(source);
        }

        public static implicit operator string(CoTaskMemoryAutoString source)
        {
            return source.ToString();
        }
    }
}
