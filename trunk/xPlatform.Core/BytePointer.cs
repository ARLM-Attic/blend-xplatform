using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BytePointer : ISerializable, IPointer<byte>
    {
        public static readonly BytePointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private BytePointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (byte*)num;
        }

        [CLSCompliant(false)]
        public BytePointer(byte* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public BytePointer(void* target)
        {
            this.internalPointer = (byte*)target;
        }

        public BytePointer(BytePointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public BytePointer(IntPtr target)
        {
            this.internalPointer = (byte*)target.ToPointer();
        }

        public BytePointer(int value)
        {
            this.internalPointer = (byte*)value;
        }

        public BytePointer(long value)
        {
            this.internalPointer = (byte*)((int)value);
        }

        private byte* internalPointer;

        public int ToInt32()
        {
            return (int)this.internalPointer;
        }

        public long ToInt64()
        {
            return (long)((int)this.internalPointer);
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
            byte* pointer = null;

            if (obj is IntPtr)
                pointer = (byte*)(IntPtr)obj;
            else if (obj is BytePointer)
                pointer = (byte*)(BytePointer)obj;

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
        public static implicit operator byte*(BytePointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator BytePointer(byte* pointer)
        {
            return new BytePointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(BytePointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator BytePointer(void* pointer)
        {
            return new BytePointer(pointer);
        }

        public static implicit operator IntPtr(BytePointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator BytePointer(IntPtr pointer)
        {
            return new BytePointer(pointer);
        }

        public static implicit operator int(BytePointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(BytePointer pointer)
        {
            return pointer.ToInt64();
        }

        public static BytePointer operator +(BytePointer pointer, int offset)
        {
            return new BytePointer(pointer.internalPointer + offset);
        }

        public static BytePointer operator -(BytePointer pointer, int offset)
        {
            return new BytePointer(pointer.internalPointer - offset);
        }

        public static BytePointer operator ++(BytePointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static BytePointer operator --(BytePointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(BytePointer left, BytePointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(BytePointer left, BytePointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public byte GetData()
        {
            return *this.internalPointer;
        }

        public byte GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(byte value)
        {
            *this.internalPointer = value;
        }

        public void SetData(byte value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public byte this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
