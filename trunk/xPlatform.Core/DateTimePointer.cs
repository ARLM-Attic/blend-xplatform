using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DateTimePointer : ISerializable, IPointer
    {
        public static readonly DateTimePointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe DateTimePointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (DateTime*)num;
        }

        [CLSCompliant(false)]
        public DateTimePointer(DateTime* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public DateTimePointer(void* target)
        {
            this.internalPointer = (DateTime*)target;
        }

        public DateTimePointer(DateTimePointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public DateTimePointer(IntPtr target)
        {
            this.internalPointer = (DateTime*)target.ToPointer();
        }

        public DateTimePointer(int value)
        {
            this.internalPointer = (DateTime*)value;
        }

        public DateTimePointer(long value)
        {
            this.internalPointer = (DateTime*)((int)value);
        }

        private DateTime* internalPointer;

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
            DateTime* pointer = null;

            if (obj is IntPtr)
                pointer = (DateTime*)(IntPtr)obj;
            else if (obj is DateTimePointer)
                pointer = (DateTime*)(DateTimePointer)obj;

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
        public static implicit operator DateTime*(DateTimePointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DateTimePointer(DateTime* pointer)
        {
            return new DateTimePointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(DateTimePointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DateTimePointer(void* pointer)
        {
            return new DateTimePointer(pointer);
        }

        public static implicit operator IntPtr(DateTimePointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator DateTimePointer(IntPtr pointer)
        {
            return new DateTimePointer(pointer);
        }

        public static implicit operator int(DateTimePointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(DateTimePointer pointer)
        {
            return pointer.ToInt64();
        }

        public static DateTimePointer operator +(DateTimePointer pointer, int offset)
        {
            return new DateTimePointer(pointer.internalPointer + offset);
        }

        public static DateTimePointer operator -(DateTimePointer pointer, int offset)
        {
            return new DateTimePointer(pointer.internalPointer - offset);
        }

        public static DateTimePointer operator ++(DateTimePointer pointer)
        {
            return new DateTimePointer(pointer.internalPointer++);
        }

        public static DateTimePointer operator --(DateTimePointer pointer)
        {
            return new DateTimePointer(pointer.internalPointer--);
        }

        public static bool operator ==(DateTimePointer left, DateTimePointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(DateTimePointer left, DateTimePointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public DateTime GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(DateTime value)
        {
            *this.internalPointer = value;
        }
    }
}
