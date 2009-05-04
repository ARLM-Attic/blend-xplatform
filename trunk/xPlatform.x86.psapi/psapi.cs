using System;
using System.Text;
using xPlatform.Flags;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xPlatform.x86.psapi
{
    [Serializable]
    public partial class psapi : ModuleBase<psapi>
    {
        [NonSerialized]
        public const string ModuleName = "psapi.dll";
    }

    partial class psapi
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EmptyWorkingSet(
            [In] IntPtr hProcess);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumDeviceDrivers(
            [Out] IntPtr lpImageBase,
            [In] IntPtr hProcess,
            [Out] IntPtr lpcbNeeded);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDeviceDrivers(
            [Out] IntPtr[] lpImageBase,
            [In] IntPtr hProcess,
            [Out] out uint lpcbNeeded);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EnumPageFiles(
            [Out] IntPtr pCallbackRoutine,
            [In] IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumPageFiles(
            [Out] out ENUM_PAGE_FILE_INFORMATION pCallbackRoutine,
            [In] IntPtr lpContext);
    }
}
