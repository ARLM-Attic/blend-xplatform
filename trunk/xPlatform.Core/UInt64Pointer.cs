using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UInt64Pointer : ISerializable, IPointer<ulong>
    {
        public static readonly UInt64Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private UInt64Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (ulong*)num;
        }

        [CLSCompliant(false)]
        public UInt64Pointer(ulong* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public UInt64Pointer(void* target)
        {
            this.internalPointer = (ulong*)target;
        }

        public UInt64Pointer(UInt64Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public UInt64Pointer(IntPtr target)
        {
            this.internalPointer = (ulong*)target.ToPointer();
        }

        public UInt64Pointer(int value)
        {
            this.internalPointer = (ulong*)value;
        }

        public UInt64Pointer(long value)
        {
            this.internalPointer = (ulong*)((int)value);
        }

        private ulong* internalPointer;

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
            ulong* pointer = null;

            if (obj is IntPtr)
                pointer = (ulong*)(IntPtr)obj;
            else if (obj is UInt64Pointer)
                pointer = (ulong*)(UInt64Pointer)obj;

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
        public static implicit operator ulong*(UInt64Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt64Pointer(ulong* pointer)
        {
            return new UInt64Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(UInt64Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt64Pointer(void* pointer)
        {
            return new UInt64Pointer(pointer);
        }

        public static implicit operator IntPtr(UInt64Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator UInt64Pointer(IntPtr pointer)
        {
            return new UInt64Pointer(pointer);
        }

        public static implicit operator int(UInt64Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(UInt64Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static UInt64Pointer operator +(UInt64Pointer pointer, int offset)
        {
            return new UInt64Pointer(pointer.internalPointer + offset);
        }

        public static UInt64Pointer operator -(UInt64Pointer pointer, int offset)
        {
            return new UInt64Pointer(pointer.internalPointer - offset);
        }

        public static UInt64Pointer operator ++(UInt64Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static UInt64Pointer operator --(UInt64Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(UInt64Pointer left, UInt64Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(UInt64Pointer left, UInt64Pointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        [CLSCompliant(false)]
        public ulong GetData()
        {
            return *this.internalPointer;
        }

        [CLSCompliant(false)]
        public ulong GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        [CLSCompliant(false)]
        public void SetData(ulong value)
        {
            *this.internalPointer = value;
        }

        [CLSCompliant(false)]
        public void SetData(ulong value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        [CLSCompliant(false)]
        public ulong this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
