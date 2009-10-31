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
            : this(new String(Constants.NullCharacter, length))
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

        public unsafe int Length
        {
            get
            {
                int length = 0;

                if (Marshal.SystemDefaultCharSize.Equals(1))
                {
                    sbyte* pointer = (sbyte*)this.internalPointer.ToPointer();

                    while (*(pointer++) != 0)
                        length++;
                }
                else
                {
                    char* pointer = (char*)this.internalPointer.ToPointer();

                    while (*(pointer++) != 0)
                        length++;
                }

                return length;
            }
        }

        public unsafe int this[int index]
        {
            get
            {
                if (Marshal.SystemDefaultCharSize.Equals(1))
                    return *(((sbyte*)this.Address.ToPointer()) + index);
                else
                    return *(((char*)this.Address.ToPointer()) + index);
            }
            set
            {
                if (Marshal.SystemDefaultCharSize.Equals(1))
                    *(((sbyte*)this.Address.ToPointer()) + index) = (sbyte)value;
                else
                    *(((char*)this.Address.ToPointer()) + index) = (char)value;
            }
        }

        public unsafe int SetBufferText(string text)
        {
            int i = 0;
            int length = (text.Length < this.Length ? text.Length : this.Length);

            if (Marshal.SystemDefaultCharSize.Equals(1))
            {
                sbyte* pointer = (sbyte*)this.Address.ToPointer();

                for (i = 0; i < length; i++)
                    *(pointer + i) = (sbyte)text[i];
            }
            else
            {
                char* pointer = (char*)this.Address.ToPointer();

                for (i = 0; i < length; i++)
                    *(pointer + i) = text[i];
            }

            return i;
        }

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAuto(this.Address);
        }

        public static implicit operator int(CoTaskMemoryAutoString target)
        {
            return target.Address.ToInt32();
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

        public static unsafe IntPtr operator +(CoTaskMemoryAutoString target, int offset)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1))
                return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) + offset);
            else
                return offset.Equals(0) ? target.Address : new IntPtr(((char*)target.Address.ToPointer()) + offset);
        }

        public static unsafe IntPtr operator -(CoTaskMemoryAutoString target, int offset)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1))
                return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) - offset);
            else
                return offset.Equals(0) ? target.Address : new IntPtr(((char*)target.Address.ToPointer()) - offset);
        }
    }
}
