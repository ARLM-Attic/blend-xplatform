using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.psapi
{
    [Serializable, CLSCompliant(false)]
    public struct ENUM_PAGE_FILE_INFORMATION
    {
        public uint cb;
        public uint Reserved;
        public uint TotalSize;
        public uint TotalInUse;
        public uint PeakUsage;
    }
}

namespace xPlatform.x86.psapi
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int EnumPageFilesProc(
        [In] IntPtr pContext,
        [In] ref ENUM_PAGE_FILE_INFORMATION pPageFileInfo,
        [In] string lpFilename);
}
