using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IntPtrPointer : ISerializable, IPointer
    {
        public static readonly IntPtrPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe IntPtrPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (IntPtr*)num;
        }

        [CLSCompliant(false)]
        public IntPtrPointer(IntPtr* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public IntPtrPointer(void* target)
        {
            this.internalPointer = (IntPtr*)target;
        }

        public IntPtrPointer(IntPtrPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public IntPtrPointer(IntPtr target)
        {
            this.internalPointer = (IntPtr*)target.ToPointer();
        }

        public IntPtrPointer(int value)
        {
            this.internalPointer = (IntPtr*)value;
        }

        public IntPtrPointer(long value)
        {
            this.internalPointer = (IntPtr*)((int)value);
        }

        private IntPtr* internalPointer;

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
            IntPtr* pointer = null;

            if (obj is IntPtr)
                pointer = (IntPtr*)(IntPtr)obj;
            else if (obj is IntPtrPointer)
                pointer = (IntPtr*)(IntPtrPointer)obj;

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
        public static implicit operator IntPtr*(IntPtrPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator IntPtrPointer(IntPtr* pointer)
        {
            return new IntPtrPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(IntPtrPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator IntPtrPointer(void* pointer)
        {
            return new IntPtrPointer(pointer);
        }

        public static implicit operator IntPtr(IntPtrPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator IntPtrPointer(IntPtr pointer)
        {
            return new IntPtrPointer(pointer);
        }

        public static implicit operator int(IntPtrPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(IntPtrPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static IntPtrPointer operator +(IntPtrPointer pointer, int offset)
        {
            return new IntPtrPointer(pointer.internalPointer + offset);
        }

        public static IntPtrPointer operator -(IntPtrPointer pointer, int offset)
        {
            return new IntPtrPointer(pointer.internalPointer - offset);
        }

        public static IntPtrPointer operator ++(IntPtrPointer pointer)
        {
            return new IntPtrPointer(pointer.internalPointer++);
        }

        public static IntPtrPointer operator --(IntPtrPointer pointer)
        {
            return new IntPtrPointer(pointer.internalPointer--);
        }

        public static bool operator ==(IntPtrPointer left, IntPtrPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(IntPtrPointer left, IntPtrPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public IntPtr GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(IntPtr value)
        {
            *this.internalPointer = value;
        }
    }
}
