﻿using System;
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

    #region Access control functions

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AllocateLocallyUniqueId(IntPtr Luid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AllocateLocallyUniqueId(ref LUID Luid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeDisplayNameA([Const] IntPtr lpSystemName, [Const] IntPtr lpName, IntPtr lpDisplayName, IntPtr cbDisplayName, IntPtr lpLanguageId);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LookupPrivilegeDisplayNameA(string lpSystemName, string lpName, StringBuilder lpDisplayName, ref uint cbDisplayName, ref uint lpLanguageId);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeDisplayNameW([Const] IntPtr lpSystemName, [Const] IntPtr lpName, IntPtr lpDisplayName, IntPtr cbDisplayName, IntPtr lpLanguageId);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LookupPrivilegeDisplayNameW(string lpSystemName, string lpName, StringBuilder lpDisplayName, ref uint cbDisplayName, ref uint lpLanguageId);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeNameA([Const] IntPtr lpSystemName, IntPtr lpLuid, IntPtr lpName, IntPtr cbName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LookupPrivilegeNameA(string lpSystemName, ref LUID lpLuid, StringBuilder lpName, ref uint cbName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeNameW([Const] IntPtr lpSystemName, IntPtr lpLuid, IntPtr lpName, IntPtr cbName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LookupPrivilegeNameW(string lpSystemName, ref LUID lpLuid, StringBuilder lpName, ref uint cbName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeValueA([Const] IntPtr lpSystemName, [Const] IntPtr lpName, IntPtr lpLuid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int LookupPrivilegeValueA(string lpSystemName, string lpName, ref LUID lpLuid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupPrivilegeValueW([Const] IntPtr lpSystemName, [Const] IntPtr lpName, IntPtr lpLuid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int LookupPrivilegeValueW(string lpSystemName, string lpName, ref LUID lpLuid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(IntPtr TokenHandle, int ResetToDefault, IntPtr NewState, uint BufferLength, IntPtr PrviousState, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(IntPtr TokenHandle, int ResetToDefault, ref TOKEN_GROUPS NewState, uint BufferLength, ref TOKEN_GROUPS PrviousState, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(IntPtr TokenHandle, int DisableAllPrivileges, IntPtr NewState, uint BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(IntPtr TokenHandle, int DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint BufferLength, ref TOKEN_PRIVILEGES PreviousState, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DuplicateToken(IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateToken(IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, ref IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTokenInformation(IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTokenInformation(IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, IntPtr TokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, ref IntPtr TokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int OpenThreadToken(IntPtr ThreadHandle, uint DesiredAccess, int OpenAsSelf, IntPtr TokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int OpenThreadToken(IntPtr ThreadHandle, uint DesiredAccess, int OpenAsSelf, ref IntPtr TokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetTokenInformation(IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetThreadToken(IntPtr Thread, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadToken(ref IntPtr Thread, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, ref IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, ref SECURITY_ATTRIBUTES lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, ref IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AllocateAndInitializeSid(IntPtr pIdentifierAuthority, byte nSubAuthorityCount, uint dwSubAuthority0, uint dwSubAuthority1, uint dwSubAuthority2, uint dwSubAuthority3, uint dwSubAuthority4, uint dwSubAuthority5, uint dwSubAuthority6, uint dwSubAuthority7, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AllocateAndInitializeSid(ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount, uint dwSubAuthority0, uint dwSubAuthority1, uint dwSubAuthority2, uint dwSubAuthority3, uint dwSubAuthority4, uint dwSubAuthority5, uint dwSubAuthority6, uint dwSubAuthority7, IntPtr pSid);
    }

    #endregion // Access control functions
}