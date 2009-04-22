using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WideCharPointer : ISerializable, IPointer<char>
    {
        public static readonly WideCharPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private WideCharPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (char*)num;
        }

        [CLSCompliant(false)]
        public WideCharPointer(char* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public WideCharPointer(void* target)
        {
            this.internalPointer = (char*)target;
        }

        public WideCharPointer(WideCharPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public WideCharPointer(IntPtr target)
        {
            this.internalPointer = (char*)target.ToPointer();
        }

        public WideCharPointer(int value)
        {
            this.internalPointer = (char*)value;
        }

        public WideCharPointer(long value)
        {
            this.internalPointer = (char*)((int)value);
        }

        private char* internalPointer;

        public int ToInt32()
        {
            return (int)this.internalPointer;
        }

        public long ToInt64()
        {
            return (long)((int)this.internalPointer);
        }

        [CLSCompliant(false)]
        public void* ToPointer()
        {
            return (void*)this.internalPointer;
        }

        public override int GetHashCode()
        {
            return (int)((ulong)this.internalPointer);
        }

        public override bool Equals(object obj)
        {
            char* pointer = null;

            if (obj is IntPtr)
                pointer = (char*)(IntPtr)obj;
            else if (obj is WideCharPointer)
                pointer = (char*)(WideCharPointer)obj;

            return (pointer == this.internalPointer);
        }

        public override string ToString()
        {
            return ((int)this.internalPointer).ToString(CultureInfo.InvariantCulture);
        }

        public string ToString(string format)
        {
            return ((int)this.internalPointer).ToString(format, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static implicit operator char*(WideCharPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator WideCharPointer(char* pointer)
        {
            return new WideCharPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(WideCharPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator WideCharPointer(void* pointer)
        {
            return new WideCharPointer(pointer);
        }

        public static implicit operator IntPtr(WideCharPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator WideCharPointer(IntPtr pointer)
        {
            return new WideCharPointer(pointer);
        }

        public static implicit operator int(WideCharPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(WideCharPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static WideCharPointer operator +(WideCharPointer pointer, int offset)
        {
            return new WideCharPointer(pointer.internalPointer + offset);
        }

        public static WideCharPointer operator -(WideCharPointer pointer, int offset)
        {
            return new WideCharPointer(pointer.internalPointer - offset);
        }

        public static WideCharPointer operator ++(WideCharPointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static WideCharPointer operator --(WideCharPointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(WideCharPointer left, WideCharPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(WideCharPointer left, WideCharPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public char GetData()
        {
            return *this.internalPointer;
        }

        public char GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(char value)
        {
            *this.internalPointer = value;
        }

        public void SetData(char value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public char this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
