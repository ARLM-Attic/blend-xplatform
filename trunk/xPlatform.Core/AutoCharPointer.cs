using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace xPlatform
{
    [Serializable]
    [ComVisible(true)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AutoCharPointer : ISerializable, IPointer<int>
    {
        public static readonly AutoCharPointer Zero;
        public static int Size { get { return IntPtr.Size; } }

        private AutoCharPointer(SerializationInfo info, StreamingContext context)
        {
            long num = info.GetInt64("value");

            if ((Size == 4) && ((num > 0x7fffffffL) || (num < -2147483648L)))
                throw new Exception("Invalid pointer value.");

            this.internalPointer = (void*)num;
        }

        [CLSCompliant(false)]
        public AutoCharPointer(void* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public AutoCharPointer(char* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public AutoCharPointer(byte* target)
        {
            this.internalPointer = target;
        }

        [CLSCompliant(false)]
        public AutoCharPointer(sbyte* target)
        {
            this.internalPointer = target;
        }

        public AutoCharPointer(AutoCharPointer target)
        {
            this.internalPointer = target.internalPointer;
        }

        public AutoCharPointer(IntPtr target)
        {
            this.internalPointer = (void*)target.ToPointer();
        }

        public AutoCharPointer(int value)
        {
            this.internalPointer = (void*)value;
        }

        public AutoCharPointer(long value)
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
            else if (obj is AutoCharPointer)
                pointer = (void*)(AutoCharPointer)obj;

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
        public static implicit operator void*(AutoCharPointer pointer)
        {
            return pointer.internalPointer;
        }

        [CLSCompliant(false)]
        public static implicit operator AutoCharPointer(void* pointer)
        {
            return new AutoCharPointer(pointer);
        }

        public static implicit operator IntPtr(AutoCharPointer pointer)
        {
            return new IntPtr(pointer.internalPointer);
        }

        public static implicit operator AutoCharPointer(IntPtr pointer)
        {
            return new AutoCharPointer(pointer);
        }

        public static implicit operator int(AutoCharPointer pointer)
        {
            return pointer.ToInt32();
        }

        public static implicit operator long(AutoCharPointer pointer)
        {
            return pointer.ToInt64();
        }

        public static AutoCharPointer operator +(AutoCharPointer pointer, int offset)
        {
            void* result = null;

            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                result = ((byte*)pointer.internalPointer) + offset;
            else // Treat as Unicode
                result = ((char*)pointer.internalPointer) + offset;

            return new AutoCharPointer(result);
        }

        public static AutoCharPointer operator -(AutoCharPointer pointer, int offset)
        {
            void* result = null;

            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                result = ((byte*)pointer.internalPointer) - offset;
            else // Treat as Unicode
                result = ((char*)pointer.internalPointer) - offset;

            return new AutoCharPointer(result);
        }

        public static AutoCharPointer operator ++(AutoCharPointer pointer)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
            {
                byte* result = (byte*)pointer.internalPointer;
                result++;
                pointer.internalPointer = result;
            }
            else // Treat as Unicode
            {
                char* result = (char*)pointer.internalPointer;
                result++;
                pointer.internalPointer = result;
            }

            return pointer;
        }

        public static AutoCharPointer operator --(AutoCharPointer pointer)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
            {
                byte* result = (byte*)pointer.internalPointer;
                result--;
                pointer.internalPointer = result;
            }
            else // Treat as Unicode
            {
                char* result = (char*)pointer.internalPointer;
                result--;
                pointer.internalPointer = result;
            }

            return pointer;
        }

        public static bool operator ==(AutoCharPointer left, AutoCharPointer right)
        {
            return (left.internalPointer == right.internalPointer);
        }

        public static bool operator !=(AutoCharPointer left, AutoCharPointer right)
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
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                return *((byte*)this.internalPointer);
            else // Treat as Unicode
                return *((char*)this.internalPointer);
        }

        public int GetData(int index)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                return *((byte*)this.internalPointer + index);
            else // Treat as Unicode
                return *((char*)this.internalPointer + index);
        }

        public void SetData(int value)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                *((byte*)this.internalPointer) = (byte)value;
            else // Treat as Unicode
                *((char*)this.internalPointer) = (char)value;
        }

        public void SetData(int value, int index)
        {
            if (Marshal.SystemDefaultCharSize.Equals(1)) // ANSI
                *((byte*)this.internalPointer + index) = (byte)value;
            else // Treat as Unicode
                *((char*)this.internalPointer + index) = (char)value;
        }

        public int this[int index]
        {
            get { return this.GetData(index); }
            set { this.SetData(value, index); }
        }
    }
}
