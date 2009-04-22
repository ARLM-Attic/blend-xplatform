using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Int16Pointer : ISerializable, IPointer<short>
    {
        public static readonly Int16Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private Int16Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (short*)num;
        }

        [CLSCompliant(false)]
        public Int16Pointer(short* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public Int16Pointer(void* target)
        {
            this.internalPointer = (short*)target;
        }

        public Int16Pointer(Int16Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public Int16Pointer(IntPtr target)
        {
            this.internalPointer = (short*)target.ToPointer();
        }

        public Int16Pointer(int value)
        {
            this.internalPointer = (short*)value;
        }

        public Int16Pointer(long value)
        {
            this.internalPointer = (short*)((int)value);
        }

        private short* internalPointer;

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
            short* pointer = null;

            if (obj is IntPtr)
                pointer = (short*)(IntPtr)obj;
            else if (obj is Int16Pointer)
                pointer = (short*)(Int16Pointer)obj;

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
        public static implicit operator short*(Int16Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int16Pointer(short* pointer)
        {
            return new Int16Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(Int16Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int16Pointer(void* pointer)
        {
            return new Int16Pointer(pointer);
        }

        public static implicit operator IntPtr(Int16Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator Int16Pointer(IntPtr pointer)
        {
            return new Int16Pointer(pointer);
        }

        public static implicit operator int(Int16Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(Int16Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static Int16Pointer operator +(Int16Pointer pointer, int offset)
        {
            return new Int16Pointer(pointer.internalPointer + offset);
        }

        public static Int16Pointer operator -(Int16Pointer pointer, int offset)
        {
            return new Int16Pointer(pointer.internalPointer - offset);
        }

        public static Int16Pointer operator ++(Int16Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static Int16Pointer operator --(Int16Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(Int16Pointer left, Int16Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(Int16Pointer left, Int16Pointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public short GetData()
        {
            return *this.internalPointer;
        }

        public short GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(short value)
        {
            *this.internalPointer = value;
        }

        public void SetData(short value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public short this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
