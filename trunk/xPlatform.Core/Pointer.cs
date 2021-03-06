﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using xPlatform.NonStandard;

namespace xPlatform
{
    [Serializable]
    [ComVisible(false)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Pointer<T> : ISerializable, ITypedPointer<T>, IUnsafePointer, IUnsignedPointer, IPointer
        where T : struct
    {
        public static readonly Pointer<T> Zero;
        public static int Size { get { return IntPtr.Size; } }

        private static int ElementSize
        {
            get
            {
                if (typeof(T).Equals(typeof(char)))
                    return Marshal.SizeOf(typeof(short));
                else if (typeof(T).Equals(typeof(bool)))
                    return Marshal.SizeOf(typeof(byte));
                else
                    return Marshal.SizeOf(typeof(T));
            }
        }

        private Pointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == Constants.X86PlatformPtrSize) &&
                ((num > Constants.X86UpperBound) || (num < Constants.X86LowerBound)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (void*)num;
        }

        [CLSCompliant(false)]
        public Pointer(void* target)
        {
            this.internalPointer = target;
        }

        public Pointer(Pointer<T> target)
        {
            this.internalPointer = target.internalPointer;
        }

        public Pointer(IntPtr target)
        {
            this.internalPointer = target.ToPointer();
        }

        public Pointer(int value)
        {
            this.internalPointer = (void*)value;
        }

        public Pointer(long value)
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
            void* pointer = null;

            if (obj is IntPtr)
                pointer = (void*)(IntPtr)obj;
            else if (obj is BytePointer)
                pointer = (void*)(BytePointer)obj;

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
        public static implicit operator void*(Pointer<T> pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator Pointer<T>(void* pointer)
        {
            return new Pointer<T>(pointer);
        }

        public static implicit operator IntPtr(Pointer<T> pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator Pointer<T>(IntPtr pointer)
        {
            return new Pointer<T>(pointer);
        }

        public static implicit operator int(Pointer<T> pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(Pointer<T> pointer)
        {
            return pointer.ToInt64();
        }

        public static Pointer<T> operator +(Pointer<T> pointer, int offset)
        {
            byte* castedPointer = (byte*)pointer.internalPointer;
            int movement = offset * ElementSize;
            castedPointer += movement;
            return new Pointer<T>((void*)castedPointer);
        }

        public static Pointer<T> operator -(Pointer<T> pointer, int offset)
        {
            byte* castedPointer = (byte*)pointer.internalPointer;
            int movement = offset * ElementSize;
            castedPointer -= movement;
            return new Pointer<T>((void*)castedPointer);
        }

        public static Pointer<T> operator ++(Pointer<T> pointer)
        {
            pointer.internalPointer = (void*)(((byte*)pointer.internalPointer) + ElementSize);
            return pointer;
        }

        public static Pointer<T> operator --(Pointer<T> pointer)
        {
            pointer.internalPointer = (void*)(((byte*)pointer.internalPointer) - ElementSize);
            return pointer;
        }

        public static bool operator ==(Pointer<T> left, Pointer<T> right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(Pointer<T> left, Pointer<T> right)
        {
            return (left.internalPointer != right.internalPointer);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("value", (long)((int)this.internalPointer));
        }

        public T GetData()
        {
            return GetData(0);
        }

        public T GetData(int index)
        {
            IntPtr newAddress = IntPtr.Zero;

            if (index > 0)
            {
                byte* castedPointer = (byte*)this.internalPointer;
                int movement = index * ElementSize;
                castedPointer += movement;
                newAddress = new IntPtr(castedPointer);
            }
            else
                newAddress = new IntPtr(this.internalPointer);

            byte[] buffer = new byte[ElementSize];
            Marshal.Copy(newAddress, buffer, 0, buffer.Length);

            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            T result = default(T);

            if (typeof(T).Equals(typeof(char)))
                result = (T)Convert.ChangeType(Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(ushort)), typeof(T));
            else
                result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));

            handle.Free();
            return result;
        }

        public void SetData(T value)
        {
            this.SetData(value, 0);
        }

        public void SetData(T value, int index)
        {
            IntPtr newAddress = IntPtr.Zero;

            if (index > 0)
            {
                byte* castedPointer = (byte*)this.internalPointer;
                int movement = index * ElementSize;
                castedPointer += movement;
                newAddress = new IntPtr(castedPointer);
            }
            else
                newAddress = new IntPtr(this.internalPointer);

            if (typeof(T).Equals(typeof(char)))
                Marshal.StructureToPtr((ushort)Convert.ChangeType(value, typeof(ushort)), newAddress, false);
            else
                Marshal.StructureToPtr(value, newAddress, false);
        }

        public T this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
