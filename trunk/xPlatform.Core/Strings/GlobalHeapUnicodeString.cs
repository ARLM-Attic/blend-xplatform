using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class GlobalHeapUnicodeString : IDisposable
    {
        public GlobalHeapUnicodeString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public GlobalHeapUnicodeString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public GlobalHeapUnicodeString(char[] array)
            : this(new String(array))
        {
        }

        public GlobalHeapUnicodeString(int length)
            : this(Utilities.CreateWhitespaceString(length))
        {
        }

        public GlobalHeapUnicodeString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToHGlobalUni(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapUnicodeString(GlobalHeapUnicodeString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapUnicodeString()
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

        public unsafe int Length
        {
            get
            {
                int length = 0;
                char* pointer = (char*)this.internalPointer.ToPointer();

                while (*(pointer++) != 0)
                    length++;

                return length;
            }
        }

        public unsafe char this[int index]
        {
            get { return *(((char*)this.Address.ToPointer()) + index); }
            set { *(((char*)this.Address.ToPointer()) + index) = value; }
        }

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringUni(this.Address);
        }

        public static implicit operator int(GlobalHeapUnicodeString target)
        {
            return target.Address.ToInt32();
        }

        public static implicit operator IntPtr(GlobalHeapUnicodeString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapUnicodeString(string source)
        {
            return new GlobalHeapUnicodeString(source);
        }

        public static implicit operator string(GlobalHeapUnicodeString source)
        {
            return source.ToString();
        }
    }
}
