using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GuidPointer : ISerializable, IPointer
    {
        public static readonly GuidPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe GuidPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (Guid*)num;
        }

        [CLSCompliant(false)]
        public GuidPointer(Guid* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public GuidPointer(void* target)
        {
            this.internalPointer = (Guid*)target;
        }

        public GuidPointer(GuidPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public GuidPointer(IntPtr target)
        {
            this.internalPointer = (Guid*)target.ToPointer();
        }

        public GuidPointer(int value)
        {
            this.internalPointer = (Guid*)value;
        }

        public GuidPointer(long value)
        {
            this.internalPointer = (Guid*)((int)value);
        }

        private Guid* internalPointer;

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
            Guid* pointer = null;

            if (obj is IntPtr)
                pointer = (Guid*)(IntPtr)obj;
            else if (obj is GuidPointer)
                pointer = (Guid*)(GuidPointer)obj;

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
        public static implicit operator Guid*(GuidPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator GuidPointer(Guid* pointer)
        {
            return new GuidPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(GuidPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator GuidPointer(void* pointer)
        {
            return new GuidPointer(pointer);
        }

        public static implicit operator IntPtr(GuidPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator GuidPointer(IntPtr pointer)
        {
            return new GuidPointer(pointer);
        }

        public static implicit operator int(GuidPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(GuidPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static GuidPointer operator +(GuidPointer pointer, int offset)
        {
            return new GuidPointer(pointer.internalPointer + offset);
        }

        public static GuidPointer operator -(GuidPointer pointer, int offset)
        {
            return new GuidPointer(pointer.internalPointer - offset);
        }

        public static GuidPointer operator ++(GuidPointer pointer)
        {
            return new GuidPointer(pointer.internalPointer++);
        }

        public static GuidPointer operator --(GuidPointer pointer)
        {
            return new GuidPointer(pointer.internalPointer--);
        }

        public static bool operator ==(GuidPointer left, GuidPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(GuidPointer left, GuidPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public Guid GetData()
        {
            return *this.internalPointer;
        }

        public void SetData(Guid value)
        {
            *this.internalPointer = value;
        }
    }
}
