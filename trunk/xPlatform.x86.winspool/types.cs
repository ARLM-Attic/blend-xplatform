using System;
using xPlatform.Flags;
using xPlatform.x86.gdi32;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.winspool
{
    using FILETIME = xPlatform.x86.kernel32.FILETIME;

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FORM_INFO_1
    {
        public uint Flags;
        public IntPtr pName;
        public SIZEL Size;
        public RECTL ImageableArea;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FORM_INFO_2
    {
        public uint Flags;
        public IntPtr pName;
        public SIZEL Size;
        public RECTL ImageableArea;
        public IntPtr pKeyword;
        public uint StringType;
        public IntPtr pMuiDll;
        public uint dwResourceId;
        public IntPtr pDisplayName;
        public ushort wLangId;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ADDJOB_INFO_1
    {
        public IntPtr Path;
        public uint JobId;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MONITOR_INFO_1
    {
        public IntPtr pName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MONITOR_INFO_2
    {
        public IntPtr pName;
        public IntPtr pEnvironment;
        public IntPtr pDLLName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PRINTER_INFO_1
    {
        public uint Flags;
        public IntPtr pDescription;
        public IntPtr pName;
        public IntPtr pComment;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PRINTER_INFO_2
    {
        public IntPtr pServerName;
        public IntPtr pPrinterName;
        public IntPtr pShareName;
        public IntPtr pPortName;
        public IntPtr pDriverName;
        public IntPtr pComment;
        public IntPtr pLocation;
        public IntPtr pDevMode;
        public IntPtr pSepFile;
        public IntPtr pPrintProcessor;
        public IntPtr pDatatype;
        public IntPtr pParameters;
        public IntPtr pSecurityDescriptor;
        public uint Attributes;
        public uint Priority;
        public uint DefaultPriority;
        public uint StartTime;
        public uint UntilTime;
        public uint Status;
        public uint cJobs;
        public uint AveragePPM;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_3
    {
        public IntPtr pSecurityDescriptor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PRINTER_INFO_4
    {
        public IntPtr pPrinterName;
        public IntPtr pServerName;
        public uint Attributes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PRINTER_CONNECTION_INFO_1
    {
        public uint dwFlags;
        public IntPtr pszDriverName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct CORE_PRINTER_DRIVER
    {
        public Guid CoreDriverGuid;
        public FILETIME ftDriverDate;
        public ulong dwlDriverVersion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szPackageID;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct DATATYPES_INFO_1
    {
        public IntPtr pName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_1
    {
        public IntPtr pDocName;
        public IntPtr pOutputFile;
        public IntPtr pDatatype;
    }
}
