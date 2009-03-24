using System;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class CoTaskMemoryAnsiString : IDisposable
    {
        public CoTaskMemoryAnsiString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToCoTaskMemAnsi(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public CoTaskMemoryAnsiString(CoTaskMemoryAnsiString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~CoTaskMemoryAnsiString()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeCoTaskMem(this.internalPointer);

            this.disposed = true;
        }

        void IDisposable.Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IntPtr Address
        {
            get
            {
                if (this.disposed)
                    return IntPtr.Zero;
                else
                    return this.internalPointer;
            }
        }

        public override string ToString()
        {
            if (this.disposed)
                return null;
            else
                return Marshal.PtrToStringAnsi(this.Address);
        }

        public static implicit operator IntPtr(CoTaskMemoryAnsiString target)
        {
            return target.Address;
        }

        public static implicit operator CoTaskMemoryAnsiString(string source)
        {
            return new CoTaskMemoryAnsiString(source);
        }

        public static implicit operator string(CoTaskMemoryAnsiString source)
        {
            return source.ToString();
        }
    }
}
