﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VoidPointer : ISerializable, IPointer
    {
        public static readonly VoidPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private unsafe VoidPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (void*)num;
        }

        [CLSCompliant(false)]
        public VoidPointer(void* target)
        {
            this.internalPointer = target;
        }

        public VoidPointer(VoidPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public VoidPointer(IntPtr target)
        {
            this.internalPointer = (void*)target.ToPointer();
        }

        public VoidPointer(int value)
        {
            this.internalPointer = (void*)value;
        }

        public VoidPointer(long value)
        {
            this.internalPointer = (void*)((int)value);
        }

        private void* internalPointer;

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
            void* pointer = null;

            if (obj is IntPtr)
                pointer = (void*)(IntPtr)obj;
            else if (obj is VoidPointer)
                pointer = (void*)(VoidPointer)obj;

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
        public static implicit operator void*(VoidPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator VoidPointer(void* pointer)
        {
            return new VoidPointer(pointer);
        }

        public static implicit operator IntPtr(VoidPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator VoidPointer(IntPtr pointer)
        {
            return new VoidPointer(pointer);
        }

        public static implicit operator int(VoidPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(VoidPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static bool operator ==(VoidPointer left, VoidPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(VoidPointer left, VoidPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public byte GetByte()
        {
            return *((byte*)this.internalPointer);
        }

        public short GetInt16()
        {
            return *((short*)this.internalPointer);
        }

        public int GetInt32()
        {
            return *((int*)this.internalPointer);
        }

        public long GetInt64()
        {
            return *((long*)this.internalPointer);
        }

        public IntPtr GetIntPtr()
        {
            return *((IntPtr*)this.internalPointer);
        }

        public void SetData(byte value)
        {
            *((byte*)this.internalPointer) = value;
        }

        public void SetData(short value)
        {
            *((short*)this.internalPointer) = value;
        }

        public void SetData(int value)
        {
            *((int*)this.internalPointer) = value;
        }

        public void SetData(long value)
        {
            *((long*)this.internalPointer) = value;
        }

        public void SetData(IntPtr value)
        {
            *((IntPtr*)this.internalPointer) = value;
        }
    }
}