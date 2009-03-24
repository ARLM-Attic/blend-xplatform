using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SBytePointer : ISerializable, IPointer
    {
        public static readonly SBytePointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe SBytePointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (sbyte*)num;
        }

        [CLSCompliant(false)]
        public SBytePointer(sbyte* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public SBytePointer(void* target)
        {
            this.internalPointer = (sbyte*)target;
        }

        public SBytePointer(SBytePointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public SBytePointer(IntPtr target)
        {
            this.internalPointer = (sbyte*)target.ToPointer();
        }

        public SBytePointer(int value)
        {
            this.internalPointer = (sbyte*)value;
        }

        public SBytePointer(long value)
        {
            this.internalPointer = (sbyte*)((int)value);
        }

        private sbyte* internalPointer;

        public int ToInt32()
        {
            return (int)this.internalPointer;
        }

        public long ToInt64()
        {
            return (long)((int)this.internalPointer);
        }

        public override int GetHashCode()
        {
            return (int)((ulong)this.internalPointer);
        }

        public override bool Equals(object obj)
        {
            sbyte* pointer = null;

            if (obj is IntPtr)
                pointer = (sbyte*)(IntPtr)obj;
            else if (obj is SBytePointer)
                pointer = (sbyte*)(SBytePointer)obj;

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
        public static implicit operator sbyte*(SBytePointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator SBytePointer(sbyte* pointer)
        {
            return new SBytePointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(SBytePointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator SBytePointer(void* pointer)
        {
            return new SBytePointer(pointer);
        }

        public static implicit operator IntPtr(SBytePointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator SBytePointer(IntPtr pointer)
        {
            return new SBytePointer(pointer);
        }

        public static implicit operator int(SBytePointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(SBytePointer pointer)
        {
            return pointer.ToInt64();
        }

        public static SBytePointer operator +(SBytePointer pointer, int offset)
        {
            return new SBytePointer(pointer.internalPointer + offset);
        }

        public static SBytePointer operator -(SBytePointer pointer, int offset)
        {
            return new SBytePointer(pointer.internalPointer - offset);
        }

        public static SBytePointer operator ++(SBytePointer pointer)
        {
            return new SBytePointer(pointer.internalPointer++);
        }

        public static SBytePointer operator --(SBytePointer pointer)
        {
            return new SBytePointer(pointer.internalPointer--);
        }

        public static bool operator ==(SBytePointer left, SBytePointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(SBytePointer left, SBytePointer right)
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
        public sbyte GetData()
        {
            return *this.internalPointer;
        }

        [CLSCompliant(false)]
        public void SetData(sbyte value)
        {
            *this.internalPointer = value;
        }
    }
}
