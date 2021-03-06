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
    public unsafe struct Int32Pointer : ISerializable, ITypedPointer<int>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly Int32Pointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private Int32Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == Constants.X86PlatformPtrSize) &&
                ((num > Constants.X86UpperBound) || (num < Constants.X86LowerBound)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (int*)num;
        }

        [CLSCompliant(false)]
        public Int32Pointer(int* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public Int32Pointer(void* target)
        {
            this.internalPointer = (int*)target;
        }

        public Int32Pointer(Int32Pointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public Int32Pointer(IntPtr target)
        {
            this.internalPointer = (int*)target.ToPointer();
        }

        public Int32Pointer(int value)
        {
            this.internalPointer = (int*)value;
        }

        public Int32Pointer(long value)
        {
            this.internalPointer = (int*)((int)value);
        }

        private int* internalPointer;

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
            int* pointer = null;

            if (obj is IntPtr)
                pointer = (int*)(IntPtr)obj;
            else if (obj is Int32Pointer)
                pointer = (int*)(Int32Pointer)obj;

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
        public static implicit operator int*(Int32Pointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int32Pointer(int* pointer)
        {
            return new Int32Pointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(Int32Pointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Int32Pointer(void* pointer)
        {
            return new Int32Pointer(pointer);
        }

        public static implicit operator IntPtr(Int32Pointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator Int32Pointer(IntPtr pointer)
        {
            return new Int32Pointer(pointer);
        }

        public static implicit operator int(Int32Pointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(Int32Pointer pointer)
        {
            return pointer.ToInt64();
        }

        public static Int32Pointer operator +(Int32Pointer pointer, int offset)
        {
            return new Int32Pointer(pointer.internalPointer + offset);
        }

        public static Int32Pointer operator -(Int32Pointer pointer, int offset)
        {
            return new Int32Pointer(pointer.internalPointer - offset);
        }

        public static Int32Pointer operator ++(Int32Pointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static Int32Pointer operator --(Int32Pointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(Int32Pointer left, Int32Pointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(Int32Pointer left, Int32Pointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public int GetData()
        {
            return *this.internalPointer;
        }

        public int GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(int value)
        {
            *this.internalPointer = value;
        }

        public void SetData(int value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public int this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
