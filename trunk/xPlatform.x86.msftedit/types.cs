using System;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msftedit
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate uint EditStreamCallback(
        [In] uint dwCookie,
        [In] IntPtr pbBuff,
        [In] int cb,
        [In] IntPtr pcb);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EditWorkBreakProcEx(
        [In] IntPtr pchText,
        [In] int cchText,
        [In] byte bCharSet,
        [In] int code);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate void HyphenateProc(
        [In] IntPtr pszWord,
        [In] uint langid,
        [In] uint ichExceed,
        [Out] out HYPHRESULT phyphresult);
}

namespace xPlatform.x86.msftedit
{
    [Serializable, Flags]
    public enum KHYPH : int
    {
        khyphNil,
        khyphNormal,
        khyphAddBefore,
        khyphChangeBefore,
        khyphDeleteBefore,
        khyphChangeAfter,
        khyphDelAndChange
    }
}

namespace xPlatform.x86.msftedit
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct HYPHRESULT
    {
        public KHYPH khyph;
        public int ichHyph;
        public char chHyph;
    }
}
