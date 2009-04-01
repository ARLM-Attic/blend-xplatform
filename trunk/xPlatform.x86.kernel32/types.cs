using System;
using System.Runtime.InteropServices;

namespace xPlatform.x86.kernel32
{
    [Serializable, Flags, CLSCompliant(false)]
    public enum ATOM : ushort { }
}

namespace xPlatform.x86.kernel32
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONTEXT
    {
        public ulong FltF0;
        public ulong FltF1;
        public ulong FltF2;
        public ulong FltF3;
        public ulong FltF4;
        public ulong FltF5;
        public ulong FltF6;
        public ulong FltF7;
        public ulong FltF8;
        public ulong FltF9;
        public ulong FltF10;
        public ulong FltF11;
        public ulong FltF12;
        public ulong FltF13;
        public ulong FltF14;
        public ulong FltF15;
        public ulong FltF16;
        public ulong FltF17;
        public ulong FltF18;
        public ulong FltF19;
        public ulong FltF20;
        public ulong FltF21;
        public ulong FltF22;
        public ulong FltF23;
        public ulong FltF24;
        public ulong FltF25;
        public ulong FltF26;
        public ulong FltF27;
        public ulong FltF28;
        public ulong FltF29;
        public ulong FltF30;
        public ulong FltF31;

        public ulong IntV0;    //  $0: return value register, v0
        public ulong IntT0;    //  $1: temporary registers, t0 - t7
        public ulong IntT1;    //  $2:
        public ulong IntT2;    //  $3:
        public ulong IntT3;    //  $4:
        public ulong IntT4;    //  $5:
        public ulong IntT5;    //  $6:
        public ulong IntT6;    //  $7:
        public ulong IntT7;    //  $8:
        public ulong IntS0;    //  $9: nonvolatile registers, s0 - s5
        public ulong IntS1;    // $10:
        public ulong IntS2;    // $11:
        public ulong IntS3;    // $12:
        public ulong IntS4;    // $13:
        public ulong IntS5;    // $14:
        public ulong IntFp;    // $15: frame pointer register, fp/s6
        public ulong IntA0;    // $16: argument registers, a0 - a5
        public ulong IntA1;    // $17:
        public ulong IntA2;    // $18:
        public ulong IntA3;    // $19:
        public ulong IntA4;    // $20:
        public ulong IntA5;    // $21:
        public ulong IntT8;    // $22: temporary registers, t8 - t11
        public ulong IntT9;    // $23:
        public ulong IntT10;   // $24:
        public ulong IntT11;   // $25:
        public ulong IntRa;    // $26: return address register, ra
        public ulong IntT12;   // $27: temporary register, t12
        public ulong IntAt;    // $28: assembler temp register, at
        public ulong IntGp;    // $29: global pointer register, gp
        public ulong IntSp;    // $30: stack pointer register, sp
        public ulong IntZero;  // $31: zero register, zero

        public ulong Fpcr;     // floating point control register
        public ulong SoftFpcr; // software extension to FPCR

        public ulong Fir;      // (fault instruction) continuation address
        public uint Psr;          // processor status

        public uint ContextFlags;

        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeConst = 4)]
        public uint[] Fill;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXCEPTION_RECORD
    {
        public uint ExceptionCode;
        public uint ExceptionFlags;
        public IntPtr ExceptionRecord;
        public IntPtr ExceptionAddress;
        public uint NumberParameters;

        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeConst = 15)]
        public uint[] ExceptionInformation;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXCEPTION_DEBUG_INFO
    {
        public EXCEPTION_RECORD ExceptionRecord;
        public uint dwFirstChance;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        public IntPtr hThread;
        public IntPtr lpThreadLocalBase;
        public IntPtr lpStartAddress;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {
        public IntPtr hFile;
        public IntPtr hProcess;
        public IntPtr hThread;
        public IntPtr lpBaseOfImage;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public IntPtr lpThreadLocalBase;
        public IntPtr lpStartAddress;
        public IntPtr lpImageName;
        public ushort fUnicode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXIT_THREAD_DEBUG_INFO
    {
        public uint dwExitCode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXIT_PROCESS_DEBUG_INFO
    {
        public uint dwExitCode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LOAD_DLL_DEBUG_INFO
    {
        public IntPtr hFile;
        public IntPtr lpBaseOfDll;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public IntPtr lpImageName;
        public ushort fUnicode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct UNLOAD_DLL_DEBUG_INFO
    {
        public IntPtr lpBaseOfDll;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        public IntPtr lpDebugStringData;
        public ushort fUnicode;
        public ushort nDebugStringLength;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct RIP_INFO
    {
        public uint dwError;
        public uint dwType;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct DEBUG_EVENT
    {
        [FieldOffset(0)]
        public uint dwDebugEventCode;

        [FieldOffset(4)]
        public uint dwProcessId;

        [FieldOffset(8)]
        public uint dwThreadId;

        [FieldOffset(12)]
        public EXCEPTION_DEBUG_INFO Exception;

        [FieldOffset(12)]
        public CREATE_THREAD_DEBUG_INFO CreateThread;

        [FieldOffset(12)]
        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;

        [FieldOffset(12)]
        public EXIT_THREAD_DEBUG_INFO ExitThread;

        [FieldOffset(12)]
        public EXIT_PROCESS_DEBUG_INFO ExitProcess;

        [FieldOffset(12)]
        public LOAD_DLL_DEBUG_INFO LoadDll;

        [FieldOffset(12)]
        public UNLOAD_DLL_DEBUG_INFO UnloadDll;

        [FieldOffset(12)]
        public OUTPUT_DEBUG_STRING_INFO OutputString;

        [FieldOffset(12)]
        public RIP_INFO RipInfo;
    }
}