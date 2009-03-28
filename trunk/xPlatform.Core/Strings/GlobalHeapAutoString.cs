﻿using System;
using System.Runtime.InteropServices;

namespace xPlatform.Strings
{
    public sealed class GlobalHeapAutoString : IDisposable
    {
        public GlobalHeapAutoString(string originalString)
            : base()
        {
            if (originalString == null)
                throw new ArgumentNullException("originalString");

            this.internalPointer = Marshal.StringToHGlobalAuto(originalString);

            if (this.internalPointer.Equals(IntPtr.Zero))
                throw new Exception("Cannot allocate memory.");
        }

        public GlobalHeapAutoString(GlobalHeapAutoString previous)
            : base()
        {
            this.internalPointer = previous.internalPointer;
        }

        ~GlobalHeapAutoString()
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
                return Marshal.PtrToStringAuto(this.Address);
        }

        public static implicit operator IntPtr(GlobalHeapAutoString target)
        {
            return target.Address;
        }

        public static implicit operator GlobalHeapAutoString(string source)
        {
            return new GlobalHeapAutoString(source);
        }

        public static implicit operator string(GlobalHeapAutoString source)
        {
            return source.ToString();
        }
    }
}