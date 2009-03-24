using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TimeSpanPointer : ISerializable, IPointer
    {
        public static readonly TimeSpanPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe TimeSpanPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (TimeSpan*)num;
        }

        [CLSCompliant(false)]
        public TimeSpanPointer(TimeSpan* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public TimeSpanPointer(void* target)
        {
            this.internalPointer = (TimeSpan*)target;
        }

        public TimeSpanPointer(TimeSpanPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public TimeSpanPointer(IntPtr target)
        {
            this.internalPointer = (TimeSpan*)target.ToPointer();
        }

        public TimeSpanPointer(int value)
        {
            this.internalPointer = (TimeSpan*)value;
        }

        public TimeSpanPointer(long value)
        {
            this.internalPointer = (TimeSpan*)((int)value);
        }

        private TimeSpan* internalPointer;

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
            TimeSpan* pointer = null;

            if (obj is IntPtr)
                pointer = (TimeSpan*)(IntPtr)obj;
            else if (obj is TimeSpanPointer)
                pointer = (TimeSpan*)(TimeSpanPointer)obj;

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
        public static implicit operator TimeSpan*(TimeSpanPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator TimeSpanPointer(TimeSpan* pointer)
        {
            return new TimeSpanPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(TimeSpanPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator TimeSpanPointer(void* pointer)
        {
            return new TimeSpanPointer(pointer);
        }

        public static implicit operator IntPtr(TimeSpanPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator TimeSpanPointer(IntPtr pointer)
        {
            return new TimeSpanPointer(pointer);
        }

        public static implicit operator int(TimeSpanPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(TimeSpanPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static TimeSpanPointer operator +(TimeSpanPointer pointer, int offset)
        {
            return new TimeSpanPointer(pointer.internalPointer + offset);
        }

        public static TimeSpanPointer operator -(TimeSpanPointer pointer, int offset)
        {
            return new TimeSpanPointer(pointer.internalPointer - offset);
        }

        public static TimeSpanPointer operator ++(TimeSpanPointer pointer)
        {
            return new TimeSpanPointer(pointer.internalPointer++);
        }

        public static TimeSpanPointer operator --(TimeSpanPointer pointer)
        {
            return new TimeSpanPointer(pointer.internalPointer--);
        }

        public static bool operator ==(TimeSpanPointer left, TimeSpanPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(TimeSpanPointer left, TimeSpanPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public TimeSpan GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(TimeSpan value)
        {
            *this.internalPointer = value;
        }
    }
}
