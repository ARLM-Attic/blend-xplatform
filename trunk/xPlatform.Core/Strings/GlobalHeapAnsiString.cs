using System;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class GlobalHeapAnsiString : IDisposable
    {
        public GlobalHeapAnsiString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToHGlobalAnsi(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapAnsiString(GlobalHeapAnsiString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapAnsiString()
        {
            this.Dispose(false);
        }

        private readonly IntPtr internalPointer = IntPtr.Zero;
        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                Marshal.FreeHGlobal(this.internalPointer);

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

        public static implicit operator IntPtr(GlobalHeapAnsiString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapAnsiString(string source)
        {
            return new GlobalHeapAnsiString(source);
        }

        public static implicit operator string(GlobalHeapAnsiString source)
        {
            return source.ToString();
        }
    }
}
