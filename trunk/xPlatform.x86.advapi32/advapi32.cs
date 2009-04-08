using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.advapi32
{
    [Serializable]
    public partial class advapi32 : ModuleBase<advapi32>
    {
        [NonSerialized]
        public const string ModuleName = "advapi32.dll";
    }

    #region File system functions (cryptions)

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint AddUsersToEncryptedFile([Const] IntPtr lpFileName, IntPtr pUsers);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint AddUsersToEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_LIST pUsers);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DecryptFileA([Const] IntPtr lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DecryptFileA(string lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DecryptFileW([Const] IntPtr lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DecryptFileW(string lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint DuplicateEncryptionInfoFile([Const] IntPtr SrcFileName, [Const] IntPtr DstFileName, uint dwCreationDistribution, uint dwAttributes, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint DuplicateEncryptionInfoFile(string SrcFileName, string DstFileName, uint dwCreationDistribution, uint dwAttributes, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EncryptFileA([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EncryptFileA(string lpFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EncryptFileW([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EncryptFileW(string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EncryptionDisable([Const] IntPtr DirPath, int Disable);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EncryptionDisable(string DirPath, int Disable);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FileEncryptionStatus([Const] IntPtr lpFileName, IntPtr lpStatus);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FileEncryptionStatus(string lpFileName, ref uint lpStatus);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void FreeEncryptionCertificateHashList(IntPtr pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void FreeEncryptionCertificateHashList(ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryRecoveryAgentsOnEcryptedFile([Const] IntPtr lpFileName, IntPtr pRecoveryAgents);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint QueryRecoveryAgentsOnEcryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pRecoveryAgents);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryUsersOnEncryptedFile([Const] IntPtr lpFileName, IntPtr pHasehs);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint QueryUsersOnEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint RemoveUsersFromEncryptedFile([Const] IntPtr lpFileName, IntPtr pHasehs);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint RemoveUsersFromEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetUserFileEncryptionKey(IntPtr pEncryptionCertificate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetUserFileEncryptionKey(ref ENCRYPTION_CERTIFICATE pEncryptionCertificate);
    }

    #endregion // File system functions (cryptions)

    #region System information functions

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCurrentHwProfileA(IntPtr lpHwProfileInfo);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetCurrentHwProfileA(ref HW_PROFILE_INFO lpHwProfileInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCurrentHwProfileW(IntPtr lpHwProfileInfo);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetCurrentHwProfileW(ref HW_PROFILE_INFO lpHwProfileInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetUserNameA(IntPtr lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetUserNameA(StringBuilder lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetUserNameW(IntPtr lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetUserNameW(StringBuilder lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetUserNameExA(EXTENDED_NAME_FORMAT NameFormat, IntPtr lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetUserNameExA(EXTENDED_NAME_FORMAT NameFormat, StringBuilder lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetUserNameExW(EXTENDED_NAME_FORMAT NameFormat, IntPtr lpBuffer, uint uSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetUserNameExW(EXTENDED_NAME_FORMAT NameFormat, StringBuilder lpBuffer, uint uSize);
    }

    #endregion // System information functions
}
