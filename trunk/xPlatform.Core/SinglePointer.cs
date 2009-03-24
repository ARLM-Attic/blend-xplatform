using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SinglePointer : ISerializable, IPointer
    {
        public static readonly SinglePointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe SinglePointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (float*)num;
        }

        [CLSCompliant(false)]
        public SinglePointer(float* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public SinglePointer(void* target)
        {
            this.internalPointer = (float*)target;
        }

        public SinglePointer(SinglePointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public SinglePointer(IntPtr target)
        {
            this.internalPointer = (float*)target.ToPointer();
        }

        public SinglePointer(int value)
        {
            this.internalPointer = (float*)value;
        }

        public SinglePointer(long value)
        {
            this.internalPointer = (float*)((int)value);
        }

        private float* internalPointer;

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
            float* pointer = null;

            if (obj is IntPtr)
                pointer = (float*)(IntPtr)obj;
            else if (obj is SinglePointer)
                pointer = (float*)(SinglePointer)obj;

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
        public static implicit operator float*(SinglePointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator SinglePointer(float* pointer)
        {
            return new SinglePointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(SinglePointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator SinglePointer(void* pointer)
        {
            return new SinglePointer(pointer);
        }

        public static implicit operator IntPtr(SinglePointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator SinglePointer(IntPtr pointer)
        {
            return new SinglePointer(pointer);
        }

        public static implicit operator int(SinglePointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(SinglePointer pointer)
        {
            return pointer.ToInt64();
        }

        public static SinglePointer operator +(SinglePointer pointer, int offset)
        {
            return new SinglePointer(pointer.internalPointer + offset);
        }

        public static SinglePointer operator -(SinglePointer pointer, int offset)
        {
            return new SinglePointer(pointer.internalPointer - offset);
        }

        public static SinglePointer operator ++(SinglePointer pointer)
        {
            return new SinglePointer(pointer.internalPointer++);
        }

        public static SinglePointer operator --(SinglePointer pointer)
        {
            return new SinglePointer(pointer.internalPointer--);
        }

        public static bool operator ==(SinglePointer left, SinglePointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(SinglePointer left, SinglePointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public float GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(float value)
        {
            *this.internalPointer = value;
        }
    }
}
