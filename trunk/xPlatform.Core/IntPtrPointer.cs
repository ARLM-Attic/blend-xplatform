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
    public unsafe struct IntPtrPointer : ISerializable, ITypedPointer<IntPtr>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly IntPtrPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private IntPtrPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == Constants.X86PlatformPtrSize) &&
                ((num > Constants.X86UpperBound) || (num < Constants.X86LowerBound)))
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
            pointer.internalPointer++;
            return pointer;
        }

        public static IntPtrPointer operator --(IntPtrPointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
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

        public IntPtr GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(IntPtr value)
        {
            *this.internalPointer = value;
        }

        public void SetData(IntPtr value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public IntPtr this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
