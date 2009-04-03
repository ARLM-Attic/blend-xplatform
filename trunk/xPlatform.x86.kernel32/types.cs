﻿using System;
using xPlatform.Flags;
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

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Bytes
    {
        public byte BaseMid;
        public byte Flags1;
        public byte Flags2;
        public byte BaseHi;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct Bits
    {
        public uint Data;

        public uint BaseMid { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Type { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Dpl { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Pres { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint LimitHi { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Sys { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Reserved_0 { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Default_Big { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint Granularity { get { throw new NotImplementedException("Bit-field member not implemented."); } }
        public uint BaseHi { get { throw new NotImplementedException("Bit-field member not implemented."); } }
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct HighWord
    {
        [FieldOffset(0)]
        public Bytes Bytes;

        [FieldOffset(0)]
        public Bits Bits;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct LDT_ENTRY
    {
        [FieldOffset(0)]
        public ushort LimitLow;

        [FieldOffset(2)]
        public ushort BaseLow;

        [FieldOffset(4)]
        public HighWord HighWord;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SECURITY_ATTRIBUTES
    {
        public uint nLength;
        public IntPtr lpSecurityDescriptor;
        public int bInheritHandle;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short x;
        public short y;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_CURSOR_INFO
    {
        public uint dwSize;
        public int bVisible;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SMALL_RECT
    {
        public ushort Left;
        public ushort Top;
        public ushort Right;
        public ushort Bottom;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_SCREEN_BUFFER_INFO
    {
        public COORD dwSize;
        public COORD dwCursorPosition;
        public ushort wAttributes;
        public SMALL_RECT srWindow;
        public COORD dwMaximumWindowSize;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct uChar
    {
        [FieldOffset(0)]
        public ushort UnicodeChar;

        [FieldOffset(0)]
        public byte AsciiChar;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct KEY_EVENT_RECORD
    {
        [FieldOffset(0)]
        public int bKeyDown;

        [FieldOffset(4)]
        public ushort wRepeatCount;

        [FieldOffset(6)]
        public ushort wVirtualKeyCode;

        [FieldOffset(8)]
        public ushort wVirtualScanCode;

        [FieldOffset(10)]
        public uChar uChar;

        [FieldOffset(12)]
        public uint dwControlKeyState;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MOUSE_EVENT_RECORD
    {
        public COORD dwMousePosition;
        public uint dwButtonState;
        public uint dwControlKeyState;
        public uint dwEventFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct WINDOW_BUFFER_SIZE_RECORD
    {
        public COORD dwSize;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MENU_EVENT_RECORD
    {
        public uint dwCommandId;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD
    {
        public int bSetFocus;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct Event
    {
        [FieldOffset(0)]
        public KEY_EVENT_RECORD KeyEvent;

        [FieldOffset(0)]
        public MOUSE_EVENT_RECORD MouseEvent;

        [FieldOffset(0)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        [FieldOffset(0)]
        public MOUSE_EVENT_RECORD MenuEvent;

        [FieldOffset(0)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct INPUT_RECORD
    {
        [FieldOffset(0)]
        public ushort EventType;

        [FieldOffset(2)]
        public Event Event;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct CHAR_INFO
    {
        [FieldOffset(0)]
        public uChar Char;

        [FieldOffset(2)]
        public ushort Attributes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_FONT_INFO
    {
        public ushort nFOnt;
        public COORD dwFontSize;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_SELECTION_INFO
    {
        public uint dwFlags;
        public COORD dwSelectionAncor;
        public SMALL_RECT srSelection;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OVERLAPPED
    {
        public uint Internal;
        public uint InternalHigh;
        public uint Offset;
        public uint OffsetHigh;
        public IntPtr hEvent;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct LIST_ENTRY
    {
        public IntPtr Flink;
        public IntPtr Blink;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct RTL_CRITICAL_SECTION_DEBUG
    {
        public ushort Type;
        public ushort CreatorBackTraceIndex;
        public IntPtr CriticalSection;
        public LIST_ENTRY ProcessLocksList;
        public uint EntryCount;
        public uint ContentionCount;
        public uint Flags;
        public ushort CreatorBackTraceIndexHigh;
        public ushort SpareWORD;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, Pack = 8), CLSCompliant(false)]
    public struct RTL_CRITICAL_SECTION
    {
        public IntPtr DebugInfo;
        public int LockCount;
        public int RecursionCount;
        public IntPtr OwningThread;
        public IntPtr LockSemaphore;
        public uint SpinCount;
    }
}

namespace xPlatform.x86.kernel32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int HandlerRoutine(uint dwCtrlType);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int DllMain(IntPtr hinstDLL, uint fdwReason, IntPtr lpvReserved);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate void APCProc(uint dwParam);
}