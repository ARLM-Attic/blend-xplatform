using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using xPlatform.NonStandard;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UInt16Pointer : ISerializable, ITypedPointer<ushort>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly UInt16Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private UInt16Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (ushort*)num;
        }

        [CLSCompliant(false)]
        public UInt16Pointer(ushort* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public UInt16Pointer(void* target)
        {
            this.internalPointer = (ushort*)target;
        }

        public UInt16Pointer(UInt16Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public UInt16Pointer(IntPtr target)
        {
            this.internalPointer = (ushort*)target.ToPointer();
        }

        public UInt16Pointer(int value)
        {
            this.internalPointer = (ushort*)value;
        }

        public UInt16Pointer(long value)
        {
            this.internalPointer = (ushort*)((int)value);
        }

        private ushort* internalPointer;

        public int ToInt32()
        {
            return (int)this.internalPointer;
        }

        public long ToInt64()
        {
            return (long)((int)this.internalPointer);
        }

        public IntPtr ToIntPtr()
        {
            return new IntPtr(this.internalPointer);
        }

        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            return (uint)this.internalPointer;
        }

        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            return (ulong)this.internalPointer;
        }

        [CLSCompliant(false)]
        public UIntPtr ToUIntPtr()
        {
            return new UIntPtr(this.internalPointer);
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
            ushort* pointer = null;

            if (obj is IntPtr)
                pointer = (ushort*)(IntPtr)obj;
            else if (obj is UInt16Pointer)
                pointer = (ushort*)(UInt16Pointer)obj;

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
        public static implicit operator ushort*(UInt16Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt16Pointer(ushort* pointer)
        {
            return new UInt16Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(UInt16Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt16Pointer(void* pointer)
        {
            return new UInt16Pointer(pointer);
        }

        public static implicit operator IntPtr(UInt16Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator UInt16Pointer(IntPtr pointer)
        {
            return new UInt16Pointer(pointer);
        }

        public static implicit operator int(UInt16Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(UInt16Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static UInt16Pointer operator +(UInt16Pointer pointer, int offset)
        {
            return new UInt16Pointer(pointer.internalPointer + offset);
        }

        public static UInt16Pointer operator -(UInt16Pointer pointer, int offset)
        {
            return new UInt16Pointer(pointer.internalPointer - offset);
        }

        public static UInt16Pointer operator ++(UInt16Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static UInt16Pointer operator --(UInt16Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(UInt16Pointer left, UInt16Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(UInt16Pointer left, UInt16Pointer right)
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
        public ushort GetData()
        {
            return *this.internalPointer;
        }

        [CLSCompliant(false)]
        public ushort GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        [CLSCompliant(false)]
        public void SetData(ushort value)
        {
            *this.internalPointer = value;
        }

        [CLSCompliant(false)]
        public void SetData(ushort value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        [CLSCompliant(false)]
        public ushort this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
