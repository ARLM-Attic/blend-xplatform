using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class GlobalHeapAutoString : IDisposable
    {
        public GlobalHeapAutoString(StringBuilder originalString)
            : this(originalString.ToString())
        {
        }

        public GlobalHeapAutoString(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public GlobalHeapAutoString(char[] array)
            : this(new String(array))
        {
        }

        public GlobalHeapAutoString(int length)
            : this(Utilities.CreateWhitespaceString(length))
        {
        }

        public GlobalHeapAutoString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToHGlobalAuto(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapAutoString(GlobalHeapAutoString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapAutoString()
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

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAuto(this.Address);
        }

        public static implicit operator int(GlobalHeapAutoString target)
        {
            return target.Address.ToInt32();
        }

        public static implicit operator IntPtr(GlobalHeapAutoString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapAutoString(string source)
        {
            return new GlobalHeapAutoString(source);
        }

        public static implicit operator string(GlobalHeapAutoString source)
        {
            return source.ToString();
        }

        public static unsafe IntPtr operator +(GlobalHeapAutoString target, int offset)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1))
                return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) + offset);
            else
                return offset.Equals(0) ? target.Address : new IntPtr(((char*)target.Address.ToPointer()) + offset);
        }

        public static unsafe IntPtr operator -(GlobalHeapAutoString target, int offset)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1))
                return offset.Equals(0) ? target.Address : new IntPtr(((sbyte*)target.Address.ToPointer()) - offset);
            else
                return offset.Equals(0) ? target.Address : new IntPtr(((char*)target.Address.ToPointer()) - offset);
        }
    }
}
