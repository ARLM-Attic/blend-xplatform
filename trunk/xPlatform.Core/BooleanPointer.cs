using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BooleanPointer : ISerializable, IPointer
    {
        public static readonly BooleanPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe BooleanPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (bool*)num;
        }

        [CLSCompliant(false)]
        public BooleanPointer(bool* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public BooleanPointer(void* target)
        {
            this.internalPointer = (bool*)target;
        }

        public BooleanPointer(BooleanPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public BooleanPointer(IntPtr target)
        {
            this.internalPointer = (bool*)target.ToPointer();
        }

        public BooleanPointer(int value)
        {
            this.internalPointer = (bool*)value;
        }

        public BooleanPointer(long value)
        {
            this.internalPointer = (bool*)((int)value);
        }

        private bool* internalPointer;

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
            bool* pointer = null;

            if (obj is IntPtr)
                pointer = (bool*)(IntPtr)obj;
            else if (obj is BooleanPointer)
                pointer = (bool*)(BooleanPointer)obj;

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
        public static implicit operator bool*(BooleanPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator BooleanPointer(bool* pointer)
        {
            return new BooleanPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(BooleanPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator BooleanPointer(void* pointer)
        {
            return new BooleanPointer(pointer);
        }

        public static implicit operator IntPtr(BooleanPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator BooleanPointer(IntPtr pointer)
        {
            return new BooleanPointer(pointer);
        }

        public static implicit operator int(BooleanPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(BooleanPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static BooleanPointer operator +(BooleanPointer pointer, int offset)
        {
            return new BooleanPointer(pointer.internalPointer + offset);
        }

        public static BooleanPointer operator -(BooleanPointer pointer, int offset)
        {
            return new BooleanPointer(pointer.internalPointer - offset);
        }

        public static BooleanPointer operator ++(BooleanPointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static BooleanPointer operator --(BooleanPointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(BooleanPointer left, BooleanPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(BooleanPointer left, BooleanPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public bool GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(bool value)
        {
            *this.internalPointer = value;
        }
    }
}
