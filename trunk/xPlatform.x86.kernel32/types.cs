using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.kernel32
{
    [Serializable, Flags, CLSCompliant(false)]
    public enum ATOM : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum SECURITY_INFORMATION : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum SECURITY_DESCRIPTOR_CONTROL : ushort { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum REGSAM : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum LCID : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum CALID : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum CALTYPE : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum LCTYPE : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum LANGID : ushort { }
}

namespace xPlatform.x86.kernel32
{
    // Todo: Structure validation needed.

    [Serializable]
    public enum FINDEX_INFO_LEVELS : int
    {
        FindExInfoStandard
    }

    [Serializable]
    public enum FINDEX_SEARCH_OPS : int
    {
        FindExSearchNameMatch,
        FindExSearchLimitToDirectories,
        FindExSearchLimitToDevices
    }

    [Serializable]
    public enum MEDIA_TYPE : int
    {
        Unknown,
        F5_1Pt2_512,
        F3_1Pt44_512,
        F3_2Pt88_512,
        F3_20Pt8_512,
        F3_720_512,
        F5_360_512,
        F5_320_512,
        F5_320_1024,
        F5_180_512,
        F5_160_512,
        RemovableMedia,
        FixedMedia
    }

    [Serializable]
    public enum JOBOBJECTINFOCLASS : int
    {
        JobObjectBasicAccountingInformation = 1,
        JobObjectBasicLimitInformation,
        JobObjectBasicProcessIdList,
        JobObjectBasicUIRestrictions,
        JobObjectSecurityLimitInformation,
        JobObjectEndOfJobTimeInformation,
        JobObjectAssociateCompletionPortInformation,
        JobObjectBasicAndIoAccountingInformation,
        JobObjectExtendedLimitInformation,
        JobObjectJobSetInformation,
        MaxJobObjectInfoClass
    }

    [Serializable]
    public enum COMPUTER_NAME_FORMAT : int
    {
        ComputerNameNetBIOS,
        ComputerNameDnsHostname,
        ComputerNameDnsDomain,
        ComputerNameDnsFullyQualified,
        ComputerNamePhysicalNetBIOS,
        ComputerNamePhysicalDnsHostname,
        ComputerNamePhysicalDnsDomain,
        ComputerNamePhysicalDnsFullyQualified,
        ComputerNameMax
    }
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

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U4, SizeConst = 4)]
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

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U4, SizeConst = 15)]
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

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpDebugStringData;

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
        public ushort UnicodeChar;

        [FieldOffset(10)]
        public byte AsciiChar;

        [FieldOffset(12)]
        public uint dwControlKeyState;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct MOUSE_EVENT_RECORD
    {
        [FieldOffset(0)]
        public COORD dwMousePosition;

        [FieldOffset(4)]
        public uint dwButtonState;

        [FieldOffset(8)]
        public uint dwControlKeyState;

        [FieldOffset(12)]
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
    public struct INPUT_RECORD
    {
        [FieldOffset(0)]
        public ushort EventType;

        [FieldOffset(4)]
        public KEY_EVENT_RECORD KeyEvent;

        [FieldOffset(4)]
        public MOUSE_EVENT_RECORD MouseEvent;

        [FieldOffset(4)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        [FieldOffset(4)]
        public MOUSE_EVENT_RECORD MenuEvent;

        [FieldOffset(4)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct CHAR_INFO
    {
        [FieldOffset(0)]
        public char UnciodeChar;

        [FieldOffset(0)]
        public char AsciiChar;

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

    [Serializable, StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {
        [FieldOffset(0)]
        public long QuadPart;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct ULARGE_INTEGER
    {
        [FieldOffset(0)]
        public ulong QuadPart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct WIN32_FIND_DATA
    {
        public uint dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public uint nFileSizeHigh;
        public uint nFileSizeLow;
        public uint dwReserved0;
        public uint dwReserved1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BY_HANDLE_FILE_INFORMATION
    {
        public uint dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public uint dwVolumeSerialNumber;
        public uint nFileSizeHigh;
        public uint nFileSizeLow;
        public uint nNumberOfLinks;
        public uint nFileIndexHigh;
        public uint nFileIndexLow;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct FILE_SEGMENT_ELEMENT
    {
        [FieldOffset(0)]
        public IntPtr Buffer;

        [FieldOffset(0)]
        public ulong Alignment;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACL
    {
        public byte AclRevision;
        public byte Sbz1;
        public ushort AclSize;
        public ushort AceCount;
        public ushort Sbz2;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SECURITY_DESCRIPTOR
    {
        public byte Revision;
        public byte Sbz1;
        public SECURITY_DESCRIPTOR_CONTROL Control;
        public IntPtr Owner;
        public IntPtr Group;
        public IntPtr Sacl;
        public IntPtr Dacl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct OFSTRUCT
    {
        public byte cBytes;
        public byte fFixedDisk;
        public ushort nErrCode;
        public ushort Reserved1;
        public ushort Reserved2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPathName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MEMORYSTATUS
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public uint dwTotalPhys;
        public uint dwAvailPhys;
        public uint dwTotalPageFile;
        public uint dwAvailPageFile;
        public uint dwTotalVirtual;
        public uint dwAvailVirtual;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct Block
    {
        public IntPtr hMem;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U4, SizeConst = 3)]
        public uint[] dwReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct Region
    {
        public uint dwCommitedSize;
        public uint dwUnCommitedSize;
        public IntPtr lpFirstBlock;
        public IntPtr lpLastBlock;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct PROCESS_HEAP_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr lpData;

        [FieldOffset(4)]
        public uint cbData;

        [FieldOffset(8)]
        public byte cbOverhead;

        [FieldOffset(9)]
        public byte iRegionIndex;

        [FieldOffset(10)]
        public ushort wFlags;

        [FieldOffset(14)]
        public Block Block;

        [FieldOffset(14)]
        public Region Region;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public uint RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct TIME_ZONE_INFORMATION
    {
        public int Bias;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public string StandardName;

        public SYSTEMTIME StandardDate;
        public int StandardBias;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public string DaylightName;

        public SYSTEMTIME DaylightDate;
        public int DaylightBias;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DCB
    {
        public uint DCBlength;
        public uint BaudRate;
        public uint Flags;
        public ushort wReserved;
        public ushort XonLim;
        public ushort XoffLim;
        public byte ByteSize;
        public byte Parity;
        public byte StopBits;
        public byte XonChar;
        public byte XoffChar;
        public byte ErrorChar;
        public byte EofChar;
        public byte EvtChar;
        public ushort wReserved1;

        public byte fBinary { get { throw new NotImplementedException(); } }
        public byte fParity { get { throw new NotImplementedException(); } }
        public byte fOutxCtsFlow { get { throw new NotImplementedException(); } }
        public byte fOutxDsrFlow { get { throw new NotImplementedException(); } }
        public byte fDtrControl { get { throw new NotImplementedException(); } }
        public byte fDsrSensitivity { get { throw new NotImplementedException(); } }
        public byte fTXContinueOnXoff { get { throw new NotImplementedException(); } }
        public byte fOutX { get { throw new NotImplementedException(); } }
        public byte fInX { get { throw new NotImplementedException(); } }
        public byte fErrorChar { get { throw new NotImplementedException(); } }
        public byte fNull { get { throw new NotImplementedException(); } }
        public byte fRtsControl { get { throw new NotImplementedException(); } }
        public byte fAbortOnError { get { throw new NotImplementedException(); } }
        public byte fDummy { get { throw new NotImplementedException(); } }
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMMTIMEOUTS
    {
        public uint ReadIntervalTimeout;
        public uint ReadTotalTimeoutMultiplier;
        public uint ReadTotalTimeoutConstant;
        public uint WriteTotalTimeoutMultiplier;
        public uint WriteTotalTimeoutConstant;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMSTAT
    {
        public uint Flags;
        public uint cbInQue;
        public uint cbOutQue;

        public uint fCtsHold { get { throw new NotImplementedException(); } }
        public uint fDsrHold { get { throw new NotImplementedException(); } }
        public uint fRlsdHold { get { throw new NotImplementedException(); } }
        public uint fXoffHold { get { throw new NotImplementedException(); } }
        public uint fXoffSent { get { throw new NotImplementedException(); } }
        public uint fEof { get { throw new NotImplementedException(); } }
        public uint fTxim { get { throw new NotImplementedException(); } }
        public uint fReserved { get { throw new NotImplementedException(); } }
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMMCONFIG
    {
        public uint dwSize;
        public ushort wVersion;
        public ushort wReserved;
        public DCB dcb;
        public uint dwProviderSubType;
        public uint dwProviderOffset;
        public uint dwProviderSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ushort[] wcProviderData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMMPROP
    {
        public ushort wPacketLength;
        public ushort wPacketVersion;
        public uint dwServiceMask;
        public uint dwReserved1;
        public uint dwMaxTxQueue;
        public uint dwMaxRxQueue;
        public uint dwMaxBaud;
        public uint dwProvSubType;
        public uint dwProvCapabilities;
        public uint dwSettableParams;
        public uint dwSettableBaud;
        public ushort wSettableData;
        public ushort wSettableStopParity;
        public uint dwCurrentTxQueue;
        public uint dwCurrentRxQueue;
        public uint dwProvSpec1;
        public uint dwProvSpec2;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ushort[] wcProvChar;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MODEMDEVCAPS
    {
        public uint dwActualSize;
        public uint dwRequiredSize;
        public uint dwDevSpecificOffset;
        public uint dwDevSpecificSize;
        public uint dwModemProviderVersion;
        public uint dwModemManufacturerOffset;
        public uint dwModemManufacturerSize;
        public uint dwModemModelOffset;
        public uint dwModemModelSize;
        public uint dwModemVersionOffset;
        public uint dwModemVersionSize;
        public uint dwDialOptions;
        public uint dwCallSetupFailTimer;
        public uint dwInactivityTimeout;
        public uint dwSpeakerVolume;
        public uint dwSpeakerMode;
        public uint dwModemOptions;
        public uint dwMaxDTERate;
        public uint dwMaxDCERate;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] avVariablePortion;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MODEMSETTINGS
    {
        public uint dwActualSize;
        public uint dwRequiredSize;
        public uint dwDevSpecificOffset;
        public uint dwDevSpecificSize;

        public uint dwCallSetupFailTimer;
        public uint dwInactivityTimeout;
        public uint dwSpeakerVolume;
        public uint dwSpeakerMode;
        public uint dwPreferredModemOptions;

        public uint dwNegotiatedModemOptions;
        public uint dwNegotiatedDCERate;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] avVariablePortion;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DISK_GEOMETRY
    {
        public LARGE_INTEGER Cylinders;
        public MEDIA_TYPE MediaType;
        public uint TracksPerCylinder;
        public uint SectorsPerTrack;
        public uint BytesPerSector;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DISK_PERFORMANCE
    {
        public LARGE_INTEGER BytesRead;
        public LARGE_INTEGER BytesWritten;
        public LARGE_INTEGER ReadTime;
        public LARGE_INTEGER WriteTime;
        public uint ReadCount;
        public uint WriteCount;
        public uint QueueDepth;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PARTITION_INFORMATION
    {
        public LARGE_INTEGER StartingOffset;
        public LARGE_INTEGER PartitionLength;
        public uint HiddenSectors;
        public uint PartitionNumber;
        public uint PartitionType;
        public byte BootIndicator;
        public byte RecognizedPartition;
        public byte RewritePartition;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DISK_LAYOUT_INFORMATION
    {
        public uint PartitionCount;
        public uint Signature;
        
        [MarshalAs(UnmanagedType.ByValArray)]
        public PARTITION_INFORMATION[] PartitionEntry;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FORMAT_PARAMETERS
    {
        public MEDIA_TYPE MediaType;
        public uint StartCylinderNumber;
        public uint EndCylinderNumber;
        public uint StartHeadNumber;
        public uint EndHeadNumber;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PREVENT_MEDIA_REMOVAL
    {
        public byte PreventMediaRemoval;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct REASSIGN_BLOCKS
    {
        public ushort Reserved;
        public ushort Count;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] BlockNumber;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct SET_PARTITION_INFORMATION
    {
        public byte PartitionType;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct VERIFY_INFORMATION
    {
        public LARGE_INTEGER StartingOffset;
        public uint Length;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CPINFO
    {
        public uint MaxCharSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] DefaultChar;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] LeadByte;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CURRENCYFMT
    {
        public uint NumDigits;
        public uint LeadingZero;
        public uint Grouping;
        public IntPtr lpDecimalSep;
        public IntPtr lpThousnadSep;
        public uint NegativeOrder;
        public uint PositiveOrder;
        public IntPtr lpCurrencySymbol;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NUMBERFMT
    {
        public uint NumDigits;
        public uint LeadingZero;
        public uint Grouping;
        public IntPtr lpDecimalSep;
        public IntPtr lpThousandSep;
        public uint NegativeOrder;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COPYDATASTRUCT
    {
        public uint dwData;
        public uint cbData;
        public IntPtr lpData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct STARTUPINFO
    {
        public uint cb;
        public IntPtr lpReserved;
        public IntPtr lpDesktop;
        public IntPtr lpTitle;
        public uint dwX;
        public uint dwY;
        public uint dwXSize;
        public uint dwYSize;
        public uint dwXCountChars;
        public uint dwYCountChars;
        public uint dwFillAttribute;
        public uint dwFlags;
        public ushort wShowWindow;
        public ushort cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public uint dwProcessId;
        public uint dwThreadId;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, Pack = 4), CLSCompliant(false)]
    public struct ACTCTX
    {
        public uint cbSize;
        public uint dwFlags;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpSource;

        public ushort wProcessorArchitecture;

        public LANGID wLangId;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpAssemblyDirectory;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpResourceName;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpApplicationName;

        public IntPtr hmodule;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACTCTX_SECTION_KEYED_DATA
    {
        public uint cbSize;
        public uint ulDataFormatVersion;
        public IntPtr lpData;
        public uint ulLength;
        public IntPtr lpSectionGlobalData;
        public uint ulSectionGlobalDataLength;
        public IntPtr lpSectionBase;
        public uint ulSectionTotalLength;
        public IntPtr hActCtx;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GUID
    {
        public uint Data1;
        public ushort Data2;
        public ushort Data3;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Data4;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
    {
        public uint ulFlags;
        public uint ulEncodedAssemblyIdentityLength;
        public uint ulManifestPathType;
        public uint ulManifestPathLength;
        public LARGE_INTEGER liManifestLastWriteTime;
        public uint ulPolicyPathType;
        public uint ulPolicyPathLength;
        public LARGE_INTEGER liPolicyLastWriteTime;
        public uint ulMetadataSatelliteRosterIndex;
        public uint ulManifestVersionMajor;
        public uint ulManifestVersionMinor;
        public uint ulPolicyVersionMajor;
        public uint ulPolicyVersionMinor;
        public uint ulAssemblyDirectoryNameLength;
        public IntPtr lpAssemblyEncodedAssemblyIdentity;
        public IntPtr lpAssemblyManifestPath;
        public IntPtr lpAssemblyPolicyPath;
        public IntPtr lpAssemblyDirectoryName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
    {
        public uint dwFlags;
        public uint ulFormatVersion;
        public uint ulAssemblyCount;
        public uint ulRootManifestPathType;
        public uint ulRootManifestPathChars;
        public uint ulRootConfigurationPathType;
        public uint ulRootConfigurationPathChars;
        public uint ulAppDirPathType;
        public uint ulAppDirPathChars;
        public IntPtr lpRootManifestPath;
        public IntPtr lpRootConfigurationPath;
        public IntPtr lpAppDirPath;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct ASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION
    {
        public uint ulFlags;
        public uint ulFilenameLength;
        public uint ulPathLength;
        public IntPtr lpFileName;
        public IntPtr lpFileLength;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
    {
        public LARGE_INTEGER TotalUserTime;
        public LARGE_INTEGER TotalKernelTime;
        public LARGE_INTEGER ThisPeriodTotalUserTime;
        public LARGE_INTEGER ThisPeriodTotalKernelTime;
        public uint TotalPageFaultCount;
        public uint TotalProcesses;
        public uint ActiveProcesses;
        public uint TotalTerminatedProcesses;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct IO_COUNTERS
    {
        public ulong ReadOperationCount;
        public ulong WriteOperationCount;
        public ulong OtherOperationCount;
        public ulong ReadTransferCount;
        public ulong WriteTransferCount;
        public ulong OtherTransferCount;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION
    {
        public JOBOBJECT_BASIC_ACCOUNTING_INFORMATION BasicInfo;
        public IO_COUNTERS IoInfo;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {
        public LARGE_INTEGER PerProcessUserTimeLimit;
        public LARGE_INTEGER PerJobUserTimeLimit;
        public uint LimitFlags;
        public uint MinimumWorkingSetSize;
        public uint MaximumWorkingSetSize;
        public uint ActiveProcessLimit;
        public uint Affinity;
        public uint PriorityClass;
        public uint SchedulingClass;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_BASIC_PROCESS_ID_LIST
    {
        public uint NumberOfAssignedProcesses;
        public uint NumberOfProcessIdsInList;

        [MarshalAs(UnmanagedType.ByValArray)]
        public uint[] ProcessIdList;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_BASIC_UI_RESTRICTIONS
    {
        public uint UIRestrictionsClass;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;
        public IO_COUNTERS IoInfo;
        public uint ProcessMemoryLimit;
        public uint JobMemoryLimit;
        public uint PeakProcessMemoryUsed;
        public uint PeakJobMemoryUsed;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
    {
        public uint SecurityLimitFlags;
        public IntPtr JobToken;
        public IntPtr SidsToDisable;
        public IntPtr PrevilegesToDelete;
        public IntPtr RestrictedSids;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SYSTEM_INFO
    {
        public uint dwOemId;
        public uint dwPageSize;
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public uint dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct OSVERSIONINFO
    {
        public uint dwOSVersionInfoSize;
        public uint dwMajorVersion;
        public uint dwMinorVersion;
        public uint dwBuildNumber;
        public uint dwPlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct OSVERSIONINFOEX
    {
        public uint dwOSVersionInfoSize;
        public uint dwMajorVersion;
        public uint dwMinorVersion;
        public uint dwBuildNumber;
        public uint dwPlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;

        public ushort wServicePackMajor;
        public ushort wServicePackMinor;
        public ushort wSuiteMask;
        public byte wProductType;
        public byte wReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TAPE_GET_MEDIA_PARAMETERS
    {
        public LARGE_INTEGER Capacity;
        public LARGE_INTEGER Remaining;
        public uint BlockSize;
        public uint PartitionCount;
        public int WriteProtected;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TAPE_GET_DRIVE_PARAMETERS
    {
        public byte ECC;
        public byte Compression;
        public byte DataPadding;
        public byte ReportSetmarks;
        public uint DefaultBlockSize;
        public uint MaximumBlockSize;
        public uint MinimumBlockSize;
        public uint MaximumPartitionCount;
        public uint FeaturesLow;
        public uint FeaturesHigh;
        public uint EOTWarningZoneSize;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_HISTORY_INFO
    {
        public uint cbSize;
        public uint HistoryBufferSize;
        public uint NumberOfHistoryBuffers;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_SCREEN_BUFFER_INFOEX
    {
        public uint cbSize;
        public COORD dwSize;
        public COORD dwCursorPosition;
        public ushort wAttributes;
        public SMALL_RECT srWindow;
        public COORD dwMaximumWindowSize;
        public ushort wPopupAttributes;
        public int bFullscreenSupported;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U4, SizeConst = 16)]
        public uint[] ColorTable; 
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct CONSOLE_FONT_INFOEX
    {
        public uint cbSize;
        public uint nFont;
        public COORD dwFontSize;
        public uint FontFamily;
        public uint FontWeight;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FaceName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CONSOLE_READCONSOLE_CONTROL
    {
        public uint nLength;
        public uint nInitialChars;
        public uint dwCtrlWakeupMask;
        public uint dwControlKeyState;
    }
}

namespace xPlatform.x86.kernel32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int HandlerRoutine([In] uint dwCtrlType);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int DllMain(IntPtr hinstDLL, uint fdwReason, IntPtr lpvReserved);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate void APCProc(uint dwParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void WaitOrTimerCallback(IntPtr lpParameter, byte TimerOrWaitFired);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate void TimerAPCProc(IntPtr lpArgToCompletionRoutine, uint dwTimerLowValue, uint dwTimerHighValue);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate uint CopyProgressRoutine(LARGE_INTEGER TotalFileSize, LARGE_INTEGER TotalBytesTransferred, LARGE_INTEGER StreamSize, LARGE_INTEGER StreamBytesTransferred, uint dwStreamNumber, uint dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate void FileIOCompletionRoutine(uint dwErrorCode, uint dwNumberOfBytesTransferred, IntPtr lpOverlapped);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)]
    public delegate int EnumCalendarInfoProc(string lpCalendarInfoString);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto), CLSCompliant(false)]
    public delegate int EnumCalendarInfoProcEx(string lpCalendarInfoString, CALID Calendar);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)]
    public delegate int EnumCodePagesProc(string lpCodePageString);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)]
    public delegate int EnumDateFormatsProc(string lpDateFormatString);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)]
    public delegate int EnumLocalesProc(string lpLocaleString);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)]
    public delegate int EnumTimeFormatsProc(string lpTimeFormatString);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate uint ThreadProc(IntPtr lpParameter);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void FiberProc(IntPtr lpParameter);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate uint ApplicationRecoveryCallback(IntPtr pvParameter);
}
