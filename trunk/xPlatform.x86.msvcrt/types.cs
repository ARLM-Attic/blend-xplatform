using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt
{
    [Serializable, Flags]
    public enum clock_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum _dev_t : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum size_t : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum wint_t : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum wctype_t : ushort { }

    [Serializable, Flags, CLSCompliant(false), Todo("Check wctrans_t type.")]
    public enum wctrans_t : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum wchar_t : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum __time32_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum __time64_t : long { }

    [Serializable, Flags]
    public enum time_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum _ino_t : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum _off_t : ushort { }

    [Serializable, Flags]
    public enum fpos_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum rsize_t : uint { }

    [Serializable, Flags]
    public enum intptr_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum uintptr_t : uint { }

    [Serializable, Flags]
    public enum ptrdiff_t : int { }

    [Serializable, Flags]
    public enum errcode : int { }

    [Serializable, Flags]
    public enum errno_t : int { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum _fsize_t : uint { }

    [Serializable, Flags]
    public enum sig_atomic_t : int { }
}

namespace xPlatform.x86.msvcrt
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall), Serializable, CLSCompliant(false)]
    public delegate void _se_translator_function(uint reason, IntPtr exceptionObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall), Serializable]
    public delegate void terminate_function();

    [UnmanagedFunctionPointer(CallingConvention.StdCall), Serializable]
    public delegate void unexpected_function();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl), Serializable]
    public delegate int _onexit_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl), Serializable, CLSCompliant(false)]
    public delegate int _PNH(size_t size);
}

namespace xPlatform.x86.msvcrt
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _complex
    {
        public double x, y;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _div_t
    {
        public int quot, rem;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _ldiv_t
    {
        public int quot, rem;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _exception
    {
        public int type;
        public IntPtr name;
        public double arg1;
        public double arg2;
        public double retval;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FILE
    {
        public IntPtr _ptr;
        public int _cnt;
        public IntPtr _base;
        public int _flag;
        public int _file;
        public int _charbuf;
        public int _bufsiz;
        public IntPtr _tmpfname;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddata32_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddata32i64_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddata64i32_t
    {
        public uint attrib;
        public __time64_t time_create;
        public __time64_t time_access;
        public __time64_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddata64_t
    {
        public uint attrib;
        public __time64_t time_create;
        public __time64_t time_access;
        public __time64_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddata_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _finddatai64_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddata32_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddata32i64_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddata64i32_t
    {
        public uint attrib;
        public __time64_t time_create;
        public __time64_t time_access;
        public __time64_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddata64_t
    {
        public uint attrib;
        public __time64_t time_create;
        public __time64_t time_access;
        public __time64_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddata_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _wfinddatai64_t
    {
        public uint attrib;
        public __time32_t time_create;
        public __time32_t time_access;
        public __time32_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct _HEAPINFO
    {
        public IntPtr _pentry;
        public size_t _size;
        public int _useflag;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct lconv
    {
        public IntPtr
            decimal_point,
            thousands_sep,
            grouping,
            int_curr_symbol,
            currency_symbol,
            mon_decimal_point,
            mon_thousands_sep,
            mon_grouping,
            positive_sign,
            negative_sign;

        public sbyte
            int_frac_digits,
            frac_digits,
            p_cs_precedes,
            p_sep_by_space,
            n_cs_precedes,
            n_sep_precedes,
            p_sign_posn,
            n_sign_posn;
    }
}
