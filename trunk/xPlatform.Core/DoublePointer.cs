using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DoublePointer : ISerializable, IPointer
    {
        public static readonly DoublePointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe DoublePointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (double*)num;
        }

        [CLSCompliant(false)]
        public DoublePointer(double* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public DoublePointer(void* target)
        {
            this.internalPointer = (double*)target;
        }

        public DoublePointer(DoublePointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public DoublePointer(IntPtr target)
        {
            this.internalPointer = (double*)target.ToPointer();
        }

        public DoublePointer(int value)
        {
            this.internalPointer = (double*)value;
        }

        public DoublePointer(long value)
        {
            this.internalPointer = (double*)((int)value);
        }

        private double* internalPointer;

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
            double* pointer = null;

            if (obj is IntPtr)
                pointer = (double*)(IntPtr)obj;
            else if (obj is DoublePointer)
                pointer = (double*)(DoublePointer)obj;

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
        public static implicit operator double*(DoublePointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DoublePointer(double* pointer)
        {
            return new DoublePointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(DoublePointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DoublePointer(void* pointer)
        {
            return new DoublePointer(pointer);
        }

        public static implicit operator IntPtr(DoublePointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator DoublePointer(IntPtr pointer)
        {
            return new DoublePointer(pointer);
        }

        public static implicit operator int(DoublePointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(DoublePointer pointer)
        {
            return pointer.ToInt64();
        }

        public static DoublePointer operator +(DoublePointer pointer, int offset)
        {
            return new DoublePointer(pointer.internalPointer + offset);
        }

        public static DoublePointer operator -(DoublePointer pointer, int offset)
        {
            return new DoublePointer(pointer.internalPointer - offset);
        }

        public static DoublePointer operator ++(DoublePointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static DoublePointer operator --(DoublePointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(DoublePointer left, DoublePointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(DoublePointer left, DoublePointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public double GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(double value)
        {
            *this.internalPointer = value;
        }
    }
}
