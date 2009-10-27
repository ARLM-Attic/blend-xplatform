using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.dssec
{
    [Serializable]
    public partial class dssec : ModuleBase
    {
        [NonSerialized]
        public const string ModuleName = "dssec.dll";
    }

    #region Authorization functions

    partial class dssec
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DSCreateSecurityPage(
            [In] IntPtr pwszObjectPath,
            [In] IntPtr pwszObjectClass,
            [In] uint dwFlags,
            [Out] IntPtr phPage,
            [In] IntPtr pfnReadSD,
            [In] IntPtr pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DSCreateSecurityPage(
            [In] string pwszObjectPath,
            [In] string pwszObjectClass,
            [In] uint dwFlags,
            [Out] out IntPtr phPage,
            [In] PFNREADOBJECTSECURITY pfnReadSD,
            [In] PFNWRITEOBJECTSECURITY pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DSCreateISecurityInfoObject(
            [In] IntPtr pwszObjectPath,
            [In] IntPtr pwszObjectClass,
            [In] uint dwFlags,
            [Out] IntPtr ppSI,
            [In] IntPtr pfnReadSD,
            [In] IntPtr pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DSCreateISecurityInfoObject(
            [In] string pwszObjectPath,
            [In] string pwszObjectClass,
            [In] uint dwFlags,
            [Out] out IntPtr ppSI,
            [In] PFNREADOBJECTSECURITY pfnReadSD,
            [In] PFNREADOBJECTSECURITY pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DSCreateISecurityInfoObjectEx(
            [In] IntPtr pwszObjectPath,
            [In] IntPtr pwszObjectClass,
            [In] IntPtr pwszServer,
            [In] IntPtr pwszUserName,
            [In] IntPtr pwszPassword,
            [In] uint dwFlags,
            [Out] IntPtr ppSI,
            [In] IntPtr pfnReadSD,
            [In] IntPtr pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DSCreateISecurityInfoObjectEx(
            [In] string pwszObjectPath,
            [In] string pwszObjectClass,
            [In] string pwszServer,
            [In] string pwszUserName,
            [In] string pwszPassword,
            [In] uint dwFlags,
            [Out] out IntPtr ppSI,
            [In] PFNREADOBJECTSECURITY pfnReadSD,
            [In] PFNWRITEOBJECTSECURITY pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DSEditSecurity(
            [In] IntPtr pwszObjectPath,
            [In] IntPtr pwszObjectClass,
            [In] uint dwFlags,
            [Out] IntPtr pwszCaption,
            [In] IntPtr pfnReadSD,
            [In] IntPtr pfnWriteSD,
            [In] ushort lpContext);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DSEditSecurity(
            [In] string pwszObjectPath,
            [In] string pwszObjectClass,
            [In] uint dwFlags,
            [Out] out IntPtr pwszCaption,
            [In] PFNREADOBJECTSECURITY pfnReadSD,
            [In] PFNWRITEOBJECTSECURITY pfnWriteSD,
            [In] ushort lpContext);
    }

    #endregion
}
