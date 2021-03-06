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
    public unsafe struct DecimalPointer : ISerializable, ITypedPointer<decimal>, IUnsafePointer, IUnsignedPointer, IPointer
    {
        public static readonly DecimalPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private DecimalPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == Constants.X86PlatformPtrSize) &&
                ((num > Constants.X86UpperBound) || (num < Constants.X86LowerBound)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (decimal*)num;
        }

        [CLSCompliant(false)]
        public DecimalPointer(decimal* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public DecimalPointer(void* target)
        {
            this.internalPointer = (decimal*)target;
        }

        public DecimalPointer(DecimalPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public DecimalPointer(IntPtr target)
        {
            this.internalPointer = (decimal*)target.ToPointer();
        }

        public DecimalPointer(int value)
        {
            this.internalPointer = (decimal*)value;
        }

        public DecimalPointer(long value)
        {
            this.internalPointer = (decimal*)((int)value);
        }

        private decimal* internalPointer;

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
            decimal* pointer = null;

            if (obj is IntPtr)
                pointer = (decimal*)(IntPtr)obj;
            else if (obj is DecimalPointer)
                pointer = (decimal*)(DecimalPointer)obj;

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
        public static implicit operator decimal*(DecimalPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DecimalPointer(decimal* pointer)
        {
            return new DecimalPointer(pointer);
        }

        [CLSCompliant(false)]
        public static implicit operator void*(DecimalPointer pointer)
        {
            return (void*)pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator DecimalPointer(void* pointer)
        {
            return new DecimalPointer(pointer);
        }

        public static implicit operator IntPtr(DecimalPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator DecimalPointer(IntPtr pointer)
        {
            return new DecimalPointer(pointer);
        }

        public static implicit operator int(DecimalPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(DecimalPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static DecimalPointer operator +(DecimalPointer pointer, int offset)
        {
            return new DecimalPointer(pointer.internalPointer + offset);
        }

        public static DecimalPointer operator -(DecimalPointer pointer, int offset)
        {
            return new DecimalPointer(pointer.internalPointer - offset);
        }

        public static DecimalPointer operator ++(DecimalPointer pointer)
        {
            pointer.internalPointer++;
            return pointer;
        }

        public static DecimalPointer operator --(DecimalPointer pointer)
        {
            pointer.internalPointer--;
            return pointer;
        }

        public static bool operator ==(DecimalPointer left, DecimalPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(DecimalPointer left, DecimalPointer right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public decimal GetData()
        {
            return *this.internalPointer;
        }

        public decimal GetData(int index)
        {
            return *(this.internalPointer + index);
        }

        public void SetData(decimal value)
        {
            *this.internalPointer = value;
        }

        public void SetData(decimal value, int index)
        {
            *(this.internalPointer + index) = value;
        }

        public decimal this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
