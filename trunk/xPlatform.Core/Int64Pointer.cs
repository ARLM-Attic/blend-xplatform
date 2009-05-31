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
    public unsafe struct Int64Pointer : ISerializable, ITypedPointer<long>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly Int64Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private Int64Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (long*)num;
        }

        [CLSCompliant(false)]
        public Int64Pointer(long* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public Int64Pointer(void* target)
        {
            this.internalPointer = (long*)target;
        }

        public Int64Pointer(Int64Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public Int64Pointer(IntPtr target)
        {
            this.internalPointer = (long*)target.ToPointer();
        }

        public Int64Pointer(int value)
        {
            this.internalPointer = (long*)value;
        }

        public Int64Pointer(long value)
        {
            this.internalPointer = (long*)((int)value);
        }

        private long* internalPointer;

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
            long* pointer = null;

            if (obj is IntPtr)
                pointer = (long*)(IntPtr)obj;
            else if (obj is Int64Pointer)
                pointer = (long*)(Int64Pointer)obj;

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
        public static implicit operator long*(Int64Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int64Pointer(long* pointer)
        {
            return new Int64Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(Int64Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int64Pointer(void* pointer)
        {
            return new Int64Pointer(pointer);
        }

        public static implicit operator IntPtr(Int64Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator Int64Pointer(IntPtr pointer)
        {
            return new Int64Pointer(pointer);
        }

        public static implicit operator int(Int64Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(Int64Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static Int64Pointer operator +(Int64Pointer pointer, int offset)
        {
            return new Int64Pointer(pointer.internalPointer + offset);
        }

        public static Int64Pointer operator -(Int64Pointer pointer, int offset)
        {
            return new Int64Pointer(pointer.internalPointer - offset);
        }

        public static Int64Pointer operator ++(Int64Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static Int64Pointer operator --(Int64Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(Int64Pointer left, Int64Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(Int64Pointer left, Int64Pointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public long GetData()
        {
            return *this.internalPointer;
        }

        public long GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(long value)
        {
            *this.internalPointer = value;
        }

        public void SetData(long value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public long this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
