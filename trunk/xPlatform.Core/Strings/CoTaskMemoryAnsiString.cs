using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class CoTaskMemoryAnsiString : IDisposable
    {
        public CoTaskMemoryAnsiString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public CoTaskMemoryAnsiString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public CoTaskMemoryAnsiString(char[] array)
            : this(new String(array))
        {
        }

        public CoTaskMemoryAnsiString(int length)
            : this(Utilities.CreateWhitespaceString(length))
        {
        }

        public CoTaskMemoryAnsiString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToCoTaskMemAnsi(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryAnsiString(CoTaskMemoryAnsiString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryAnsiString()
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

        public unsafe int Length
        {
            get
            {
                int length = 0;
                sbyte* pointer = (sbyte*)this.internalPointer.ToPointer();

                while (*(pointer++) != 0)
                    length++;

                return length;
            }
        }

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAnsi(this.Address);
        }

        public static implicit operator int(CoTaskMemoryAnsiString target)
        {
            return target.Address.ToInt32();
        }

        public static implicit operator IntPtr(CoTaskMemoryAnsiString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryAnsiString(string source)
        {
            return new CoTaskMemoryAnsiString(source);
        }

        public static implicit operator string(CoTaskMemoryAnsiString source)
        {
            return source.ToString();
        }
    }
}
