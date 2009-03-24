using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UIntPtrPointer : ISerializable, IPointer
    {
        public static readonly UIntPtrPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe UIntPtrPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (UIntPtr*)num;
        }

        [CLSCompliant(false)]
        public UIntPtrPointer(UIntPtr* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public UIntPtrPointer(void* target)
        {
            this.internalPointer = (UIntPtr*)target;
        }

        public UIntPtrPointer(UIntPtrPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public UIntPtrPointer(IntPtr target)
        {
            this.internalPointer = (UIntPtr*)target.ToPointer();
        }

        public UIntPtrPointer(int value)
        {
            this.internalPointer = (UIntPtr*)value;
        }

        public UIntPtrPointer(long value)
        {
            this.internalPointer = (UIntPtr*)((int)value);
        }

        private UIntPtr* internalPointer;

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
            UIntPtr* pointer = null;

            if (obj is IntPtr)
                pointer = (UIntPtr*)(IntPtr)obj;
            else if (obj is UIntPtrPointer)
                pointer = (UIntPtr*)(UIntPtrPointer)obj;

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
        public static implicit operator UIntPtr*(UIntPtrPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UIntPtrPointer(UIntPtr* pointer)
        {
            return new UIntPtrPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(UIntPtrPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UIntPtrPointer(void* pointer)
        {
            return new UIntPtrPointer(pointer);
        }

        public static implicit operator IntPtr(UIntPtrPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator UIntPtrPointer(IntPtr pointer)
        {
            return new UIntPtrPointer(pointer);
        }

        public static implicit operator int(UIntPtrPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(UIntPtrPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static UIntPtrPointer operator +(UIntPtrPointer pointer, int offset)
        {
            return new UIntPtrPointer(pointer.internalPointer + offset);
        }

        public static UIntPtrPointer operator -(UIntPtrPointer pointer, int offset)
        {
            return new UIntPtrPointer(pointer.internalPointer - offset);
        }

        public static UIntPtrPointer operator ++(UIntPtrPointer pointer)
        {
            return new UIntPtrPointer(pointer.internalPointer++);
        }

        public static UIntPtrPointer operator --(UIntPtrPointer pointer)
        {
            return new UIntPtrPointer(pointer.internalPointer--);
        }

        public static bool operator ==(UIntPtrPointer left, UIntPtrPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(UIntPtrPointer left, UIntPtrPointer right)
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
        public UIntPtr GetData()
        {
            return *this.internalPointer;
        }

        [CLSCompliant(false)]
        public void SetData(UIntPtr value)
        {
            *this.internalPointer = value;
        }
    }
}
