using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class GlobalHeapAnsiString : IDisposable
    {
        public GlobalHeapAnsiString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public GlobalHeapAnsiString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public GlobalHeapAnsiString(char[] array)
            : this(new String(array))
        {
        }

        public GlobalHeapAnsiString(int length)
            : this(new String(Constants.NullCharacter, length))
        {
        }

        public GlobalHeapAnsiString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToHGlobalAnsi(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapAnsiString(GlobalHeapAnsiString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapAnsiString()
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
                sbyte* pointer = (sbyte*)this.internalPointer.ToPointer();

                while (*(pointer++) != 0)
                    length++;

                return length;
            }
        }

        [CLSCompliant(false)]
        public unsafe sbyte this[int index]
        {
            get { return *(((sbyte*)this.Address.ToPointer()) + index); }
            set { *(((sbyte*)this.Address.ToPointer()) + index) = value; }
        }

        public unsafe int SetBufferText(string text)
        {
            int i = 0;
            sbyte* pointer = (sbyte*)this.Address.ToPointer();
            int length = (text.Length < this.Length ? text.Length : this.Length);

            for (i = 0; i < length; i++)
                *(pointer + i) = (sbyte)text[i];

            return i;
        }

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAnsi(this.Address);
        }

        public static implicit operator int(GlobalHeapAnsiString target)
        {
            return target.Address.ToInt32();
        }

        public static implicit operator IntPtr(GlobalHeapAnsiString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapAnsiString(string source)
        {
            return new GlobalHeapAnsiString(source);
        }

        public static implicit operator string(GlobalHeapAnsiString source)
        {
            return source.ToString();
        }

        public static unsafe IntPtr operator +(GlobalHeapAnsiString target, int offset)
        {
            return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) + offset);
        }

        public static unsafe IntPtr operator -(GlobalHeapAnsiString target, int offset)
        {
            return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) - offset);
        }
    }
}
