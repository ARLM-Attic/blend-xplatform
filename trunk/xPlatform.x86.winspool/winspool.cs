using System;
using System.Text;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.winspool
{
    [Serializable]
    public partial class winspool : ModuleBase
    {
        [NonSerialized]
        public const string ModuleName = "winspool.drv";
    }

    #region Printing and print spooler functions

    partial class winspool
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AbortDoc(
            [In] IntPtr hdc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AbortPrinter(
            [In] IntPtr hPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFormA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] IntPtr pForm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFormA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] byte[] pForm);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddFormA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] ref FORM_INFO_1 pForm);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddFormA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] ref FORM_INFO_2 pForm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFormW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] IntPtr pForm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddFormW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] byte[] pForm);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddFormW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] ref FORM_INFO_1 pForm);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddFormW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [In] ref FORM_INFO_2 pForm);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddJobA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] IntPtr pData,
            [In] uint cbBuf,
            [Out] IntPtr pcbNeeded);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddJobA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] byte[] pData,
            [In] uint cbBuf,
            [Out] out ADDJOB_INFO_1 pcbNeeded);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddJobA(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] out ADDJOB_INFO_1 pData,
            [In] uint cbBuf,
            [Out] out ADDJOB_INFO_1 pcbNeeded);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddJobW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] IntPtr pData,
            [In] uint cbBuf,
            [Out] IntPtr pcbNeeded);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddJobW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] byte[] pData,
            [In] uint cbBuf,
            [Out] out ADDJOB_INFO_1 pcbNeeded);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddJobW(
            [In] IntPtr hPrinter,
            [In] uint Level,
            [Out] out ADDJOB_INFO_1 pData,
            [In] uint cbBuf,
            [Out] out ADDJOB_INFO_1 pcbNeeded);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddMonitorA(
            [In] IntPtr pName,
            [In] uint Level,
            [In] IntPtr pMonitors);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddMonitorA(
            [In] string pName,
            [In] uint Level,
            [In] byte[] pMonitors);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddMonitorA(
            [In] string pName,
            [In] uint Level,
            [In] ref MONITOR_INFO_2 pMonitors);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddMonitorW(
            [In] IntPtr pName,
            [In] uint Level,
            [In] IntPtr pMonitors);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddMonitorW(
            [In] string pName,
            [In] uint Level,
            [In] byte[] pMonitors);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddMonitorW(
            [In] string pName,
            [In] uint Level,
            [In] ref MONITOR_INFO_2 pMonitors);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddPortA(
            [In] IntPtr pName,
            [In] IntPtr hWnd,
            [In] IntPtr pMonitorName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int AddPortA(
            [In] IntPtr pName,
            [In] IntPtr hWnd,
            [In] string pMonitorName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int AddPortA(
            [In] string pName,
            [In] IntPtr hWnd,
            [In] string pMonitorName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddPortW(
            [In] IntPtr pName,
            [In] IntPtr hWnd,
            [In] IntPtr pMonitorName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddPortW(
            [In] IntPtr pName,
            [In] IntPtr hWnd,
            [In] string pMonitorName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddPortW(
            [In] string pName,
            [In] IntPtr hWnd,
            [In] string pMonitorName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterA(
            [In] IntPtr pName,
            [In] uint Level,
            [In] IntPtr pPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterA(
            [In] IntPtr pName,
            [In] uint Level,
            [In] byte[] pPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterA(
            [In] IntPtr pName,
            [In] uint Level,
            [In] ref PRINTER_INFO_2 pPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterW(
            [In] IntPtr pName,
            [In] uint Level,
            [In] IntPtr pPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterW(
            [In] IntPtr pName,
            [In] uint Level,
            [In] byte[] pPrinter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AddPrinterW(
            [In] IntPtr pName,
            [In] uint Level,
            [In] ref PRINTER_INFO_2 pPrinter);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddPrinterConnectionA(
            [In] IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int AddPrinterConnectionA(
            [In] string pName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AddPrinterConnectionW(
            [In] IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddPrinterConnectionW(
            [In] string pName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddPrinterConnection2A(
            [In] IntPtr pszName,
            [In] uint dwLevel,
            [In] IntPtr pConnectionInfo);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AddPrinterConnection2A(
            [In] string pszName,
            [In] uint dwLevel,
            [In] ref PRINTER_CONNECTION_INFO_1 pConnectionInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddPrinterConnection2W(
            [In] IntPtr pszName,
            [In] uint dwLevel,
            [In] IntPtr pConnectionInfo);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AddPrinterConnection2W(
            [In] string pszName,
            [In] uint dwLevel,
            [In] ref PRINTER_CONNECTION_INFO_1 pConnectionInfo);
    }

    #endregion // Printing and print spooler functions
}
