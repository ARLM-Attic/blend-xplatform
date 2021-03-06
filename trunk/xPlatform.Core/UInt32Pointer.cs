﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using xPlatform.NonStandard;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UInt32Pointer : ISerializable, ITypedPointer<uint>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly UInt32Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private UInt32Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == Constants.X86PlatformPtrSize) &&
                ((num > Constants.X86UpperBound) || (num < Constants.X86LowerBound)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (uint*)num;
        }

        [CLSCompliant(false)]
        public UInt32Pointer(uint* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public UInt32Pointer(void* target)
        {
            this.internalPointer = (uint*)target;
        }

        public UInt32Pointer(UInt32Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public UInt32Pointer(IntPtr target)
        {
            this.internalPointer = (uint*)target.ToPointer();
        }

        public UInt32Pointer(int value)
        {
            this.internalPointer = (uint*)value;
        }

        public UInt32Pointer(long value)
        {
            this.internalPointer = (uint*)((int)value);
        }

        private uint* internalPointer;

        public int ToInt32()
        {
            return (int)this.internalPointer;
        }

        public long ToInt64()
        {
            return (long)((int)this.internalPointer);
        }

        public IntPtr ToIntPtr()
        {
            return new IntPtr(this.internalPointer);
        }

        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            return (uint)this.internalPointer;
        }

        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            return (ulong)this.internalPointer;
        }

        [CLSCompliant(false)]
        public UIntPtr ToUIntPtr()
        {
            return new UIntPtr(this.internalPointer);
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
            uint* pointer = null;

            if (obj is IntPtr)
                pointer = (uint*)(IntPtr)obj;
            else if (obj is UInt32Pointer)
                pointer = (uint*)(UInt32Pointer)obj;

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
        public static implicit operator uint*(UInt32Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt32Pointer(uint* pointer)
        {
            return new UInt32Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(UInt32Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator UInt32Pointer(void* pointer)
        {
            return new UInt32Pointer(pointer);
        }

        public static implicit operator IntPtr(UInt32Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator UInt32Pointer(IntPtr pointer)
        {
            return new UInt32Pointer(pointer);
        }

        public static implicit operator int(UInt32Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(UInt32Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static UInt32Pointer operator +(UInt32Pointer pointer, int offset)
        {
            return new UInt32Pointer(pointer.internalPointer + offset);
        }

        public static UInt32Pointer operator -(UInt32Pointer pointer, int offset)
        {
            return new UInt32Pointer(pointer.internalPointer - offset);
        }

        public static UInt32Pointer operator ++(UInt32Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static UInt32Pointer operator --(UInt32Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(UInt32Pointer left, UInt32Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(UInt32Pointer left, UInt32Pointer right)
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
        public uint GetData()
        {
            return *this.internalPointer;
        }

        [CLSCompliant(false)]
        public uint GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        [CLSCompliant(false)]
        public void SetData(uint value)
        {
            *this.internalPointer = value;
        }

        [CLSCompliant(false)]
        public void SetData(uint value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        [CLSCompliant(false)]
        public uint this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
