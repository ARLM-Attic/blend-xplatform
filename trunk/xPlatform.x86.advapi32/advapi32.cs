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

    #region Access control functions

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(IntPtr TokenHandle, int ResetToDefault, IntPtr NewState, uint BufferLength, IntPtr PrviousState, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(IntPtr TokenHandle, int ResetToDefault, ref TOKEN_GROUPS NewState, uint BufferLength, ref TOKEN_GROUPS PrviousState, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(IntPtr TokenHandle, int DisableAllPrivileges, IntPtr NewState, uint BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(IntPtr TokenHandle, int DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint BufferLength, ref TOKEN_PRIVILEGES PreviousState, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CheckTokenMembership(IntPtr TokenHandle, IntPtr SidToCheck, IntPtr IsMember);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CheckTokenMembership(IntPtr TokenHandle, IntPtr SidToCheck, ref int IsMember);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateRestrictedToken(IntPtr ExistingTokenHandle, uint Flags, uint DisableSidCount, IntPtr SidsToDisable, uint DeletePrivilegeCount, IntPtr PrivilegesToDelete, uint RestrictedSidCount, IntPtr SidsToRestrict, IntPtr NewTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateRestrictedToken(IntPtr ExistingTokenHandle, uint Flags, uint DisableSidCount, SID_AND_ATTRIBUTES[] SidsToDisable, uint DeletePrivilegeCount, LUID_AND_ATTRIBUTES[] PrivilegesToDelete, uint RestrictedSidCount, SID_AND_ATTRIBUTES[] SidsToRestrict, out IntPtr NewTokenHandle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DuplicateToken(IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateToken(IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, ref IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, ref IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, ref SECURITY_ATTRIBUTES lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, ref IntPtr phNewToken);

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

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetThreadToken(IntPtr Thread, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadToken(ref IntPtr Thread, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetTokenInformation(IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength);

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
        public static extern int AllocateAndInitializeSid(IntPtr pIdentifierAuthority, byte nSubAuthorityCount, uint dwSubAuthority0, uint dwSubAuthority1, uint dwSubAuthority2, uint dwSubAuthority3, uint dwSubAuthority4, uint dwSubAuthority5, uint dwSubAuthority6, uint dwSubAuthority7, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AllocateAndInitializeSid(ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount, uint dwSubAuthority0, uint dwSubAuthority1, uint dwSubAuthority2, uint dwSubAuthority3, uint dwSubAuthority4, uint dwSubAuthority5, uint dwSubAuthority6, uint dwSubAuthority7, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConvertSidToStringSidA(IntPtr Sid, IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSidToStringSidA(IntPtr Sid, ref IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConvertSidToStringSidW(IntPtr Sid, IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSidToStringSidW(IntPtr Sid, ref IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConvertStringSidToSidA([Const] IntPtr StringSid, IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int ConvertStringSidToSidA(string StringSid, ref IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConvertStringSidToSidW([Const] IntPtr StringSid, IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ConvertStringSidToSidW(string StringSid, ref IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CopySid(uint nDestinationSidLength, IntPtr pDestinationSid, IntPtr pSourceSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnwonSidType, IntPtr DomainSid, IntPtr pSid, IntPtr cbSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnwonSidType, IntPtr DomainSid, IntPtr pSid, ref uint cbSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualPrefixSid(IntPtr pSid1, IntPtr pSid2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualSid(IntPtr pSid1, IntPtr pSid2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr FreeSid(IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLengthSid(IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetSidIdentifierAuthority(IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSidLengthRequired(byte nSubAuthorityCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GetSidAuthority(IntPtr pSid, uint nSubAuthority);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetSidSubAuthorityCount(IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InitializeSid(IntPtr Sid, IntPtr pIdentifierAuthority, byte nSubAuthorityCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int InitializeSid(IntPtr Sid, ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int IsValidSid(IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupAccountNameA([Const] IntPtr lpSystemName, [Const] IntPtr lpAccountName, IntPtr Sid, IntPtr cbSid, IntPtr DomainName, IntPtr cbDomainName, IntPtr peUse);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LookupAccountNameA(string lpSystemName, string lpAccountName, IntPtr Sid, ref uint cbSid, StringBuilder DomainName, ref uint cbDomainName, ref SID_NAME_USE peUse);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupAccountNameW([Const] IntPtr lpSystemName, [Const] IntPtr lpAccountName, IntPtr Sid, IntPtr cbSid, IntPtr DomainName, IntPtr cbDomainName, IntPtr peUse);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LookupAccountNameW(string lpSystemName, string lpAccountName, IntPtr Sid, ref uint cbSid, StringBuilder DomainName, ref uint cbDomainName, ref SID_NAME_USE peUse);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LookupAccountSidA([Const] IntPtr lpSystemName, IntPtr Sid, IntPtr Name, IntPtr cbName, IntPtr DomainName, IntPtr cbDomainName, IntPtr peUse);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LookupAccountSidA(string lpSystemName, IntPtr Sid, StringBuilder Name, ref uint cbName, StringBuilder DomainName, ref uint cbDomainName, ref SID_NAME_USE peUse);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSecurityDescriptorToStringSecurityDescriptorA(IntPtr SecurityDescriptor, uint RequestedStringSDRevision, SECURITY_INFORMATION SecurityInformation, IntPtr StringSecurityDescriptor, IntPtr StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSecurityDescriptorToStringSecurityDescriptorA(ref SECURITY_DESCRIPTOR SecurityDescriptor, uint RequestedStringSDRevision, SECURITY_INFORMATION SecurityInformation, ref IntPtr StringSecurityDescriptor, ref uint StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSecurityDescriptorToStringSecurityDescriptorW(IntPtr SecurityDescriptor, uint RequestedStringSDRevision, SECURITY_INFORMATION SecurityInformation, IntPtr StringSecurityDescriptor, IntPtr StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertSecurityDescriptorToStringSecurityDescriptorW(ref SECURITY_DESCRIPTOR SecurityDescriptor, uint RequestedStringSDRevision, SECURITY_INFORMATION SecurityInformation, ref IntPtr StringSecurityDescriptor, ref uint StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorA([Const] IntPtr StringSecurityDescriptor, uint StringSDRevision, IntPtr SecurityDescriptor, IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorA(string StringSecurityDescriptor, uint StringSDRevision, ref IntPtr SecurityDescriptor, ref uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorW([Const] IntPtr StringSecurityDescriptor, uint StringSDRevision, IntPtr SecurityDescriptor, IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorW(string StringSecurityDescriptor, uint StringSDRevision, ref IntPtr SecurityDescriptor, ref uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetNamedSecurityInfoA(IntPtr pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr ppsidOwner, IntPtr ppsidGroup, IntPtr ppDacl, IntPtr ppSacl, IntPtr ppSEcurityDescriptor);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetNamedSecurityInfoA(StringBuilder pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, ref IntPtr ppsidOwner, ref IntPtr ppsidGroup, ref IntPtr ppDacl, ref IntPtr ppSacl, ref IntPtr ppSEcurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetNamedSecurityInfoW(IntPtr pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr ppsidOwner, IntPtr ppsidGroup, IntPtr ppDacl, IntPtr ppSacl, IntPtr ppSEcurityDescriptor);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetNamedSecurityInfoW(StringBuilder pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, ref IntPtr ppsidOwner, ref IntPtr ppsidGroup, ref IntPtr ppDacl, ref IntPtr ppSacl, ref IntPtr ppSEcurityDescriptor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetSecurityDescriptorControl(IntPtr pSecurityDescriptor, IntPtr pControl, IntPtr lpdwRevision);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetSecurityDescriptorControl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref SECURITY_DESCRIPTOR_CONTROL pControl, ref uint lpdwRevision);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSecurityDescriptorRMControl(IntPtr SecurityDescriptor, IntPtr RMControl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSecurityDescriptorRMControl(ref SECURITY_DESCRIPTOR SecurityDescriptor, ref byte RMControl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSecurityInfo(IntPtr handle, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr ppsidOwner, IntPtr ppsidGroup, IntPtr ppDacl, IntPtr ppSacl, IntPtr ppSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSecurityInfo(IntPtr handle, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, ref IntPtr ppsidOwner, ref IntPtr ppsidGroup, ref IntPtr ppDacl, ref IntPtr ppSacl, ref IntPtr ppSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetNamedSecurityInfoA(IntPtr pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, IntPtr pDacl, IntPtr pSacl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint SetNamedSecurityInfoA(StringBuilder pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, ref ACL pDacl, ref ACL pSacl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetNamedSecurityInfoW(IntPtr pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, IntPtr pDacl, IntPtr pSacl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint SetNamedSecurityInfoW(StringBuilder pObjectName, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, ref ACL pDacl, ref ACL pSacl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetSecurityDescriptorControl(IntPtr pSecurityDescriptor, SECURITY_DESCRIPTOR_CONTROL ControlBitsOfInterest, SECURITY_DESCRIPTOR_CONTROL ControlBitsToSet);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetSecurityDescriptorControl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, SECURITY_DESCRIPTOR_CONTROL ControlBitsOfInterest, SECURITY_DESCRIPTOR_CONTROL ControlBitsToSet);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetSecurityDescriptorRMControl(IntPtr SecurityDescriptor, IntPtr RMControl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetSecurityDescriptorRMControl(ref SECURITY_DESCRIPTOR SecurityDescriptor, ref byte RMControl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetSecurityInfo(IntPtr handle, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, IntPtr pDacl, IntPtr pSacl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetSecurityInfo(IntPtr handle, SE_OBJECT_TYPE ObjectType, SECURITY_INFORMATION SecurityInfo, IntPtr psidOwner, IntPtr psidGroup, ref ACL pDacl, ref ACL pSacl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameA(IntPtr pExplicitAccess, IntPtr pTrusteeName, uint AccessPermissions, ACCESS_MODE AccessMode, uint Inheritance);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameA(ref EXPLICIT_ACCESS pExplicitAccess, StringBuilder pTrusteeName, uint AccessPermissions, ACCESS_MODE AccessMode, uint Inheritance);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameW(IntPtr pExplicitAccess, IntPtr pTrusteeName, uint AccessPermissions, ACCESS_MODE AccessMode, uint Inheritance);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameW(ref EXPLICIT_ACCESS pExplicitAccess, StringBuilder pTrusteeName, uint AccessPermissions, ACCESS_MODE AccessMode, uint Inheritance);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithNameA(IntPtr pTrustee, IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern void BuildTrusteeWithNameA(ref TRUSTEE pTrustee, StringBuilder pName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithNameW(IntPtr pTrustee, IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void BuildTrusteeWithNameW(ref TRUSTEE pTrustee, StringBuilder pName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndNameA(IntPtr pTrustee, IntPtr pObjName, SE_OBJECT_TYPE ObjectType, IntPtr ObjectTypeName, IntPtr InheritedObjectTypeName, IntPtr Name);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndNameA(ref TRUSTEE pTrustee, ref OBJECTS_AND_NAME pObjName, SE_OBJECT_TYPE ObjectType, StringBuilder ObjectTypeName, StringBuilder InheritedObjectTypeName, StringBuilder Name);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndNameW(IntPtr pTrustee, IntPtr pObjName, SE_OBJECT_TYPE ObjectType, IntPtr ObjectTypeName, IntPtr InheritedObjectTypeName, IntPtr Name);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndNameW(ref TRUSTEE pTrustee, ref OBJECTS_AND_NAME pObjName, SE_OBJECT_TYPE ObjectType, StringBuilder ObjectTypeName, StringBuilder InheritedObjectTypeName, StringBuilder Name);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndSidA(IntPtr pTrustee, IntPtr pObjSid, IntPtr pObjectGuid, IntPtr pInheritedObjectGuid, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndSidA(ref TRUSTEE pTrustee, ref OBJECTS_AND_SID pObjSid, ref GUID pObjectGuid, ref GUID pInheritedObjectGuid, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndSidW(IntPtr pTrustee, IntPtr pObjSid, IntPtr pObjectGuid, IntPtr pInheritedObjectGuid, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndSidW(ref TRUSTEE pTrustee, ref OBJECTS_AND_SID pObjSid, ref GUID pObjectGuid, ref GUID pInheritedObjectGuid, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithSidA(IntPtr pTrustee, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern void BuildTrusteeWithSidA(ref TRUSTEE pTrustee, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithSidW(IntPtr pTrustee, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void BuildTrusteeWithSidW(ref TRUSTEE pTrustee, IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAclA(IntPtr pacl, IntPtr pTrustee, IntPtr pSuccessfulAuditedRights, IntPtr pFailedAuditRights);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAclA(ref ACL pacl, ref TRUSTEE pTrustee, ref ACCESS_MASK pSuccessfulAuditedRights, ref ACCESS_MASK pFailedAuditRights);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAclW(IntPtr pacl, IntPtr pTrustee, IntPtr pSuccessfulAuditedRights, IntPtr pFailedAuditRights);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAclW(ref ACL pacl, ref TRUSTEE pTrustee, ref ACCESS_MASK pSuccessfulAuditedRights, ref ACCESS_MASK pFailedAuditRights);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAclA(IntPtr pacl, IntPtr pTrustee, IntPtr pAccessRights);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAclA(ref ACL pacl, ref TRUSTEE pTrustee, ref ACCESS_MASK pAccessRights);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAclW(IntPtr pacl, IntPtr pTrustee, IntPtr pAccessRights);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAclW(ref ACL pacl, ref TRUSTEE pTrustee, ref ACCESS_MASK pAccessRights);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetExplicitEntriesFromAclA(IntPtr pacl, IntPtr pcCountOfExplicitEntries, IntPtr pListOFExplicitEntries);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetExplicitEntriesFromAclA(ref ACL pacl, ref uint pcCountOfExplicitEntries, IntPtr[] pListOFExplicitEntries);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetExplicitEntriesFromAclW(IntPtr pacl, IntPtr pcCountOfExplicitEntries, IntPtr pListOFExplicitEntries);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetExplicitEntriesFromAclW(ref ACL pacl, ref uint pcCountOfExplicitEntries, IntPtr[] pListOFExplicitEntries);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern TRUSTEE_FORM GetTrusteeFormA(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern TRUSTEE_FORM GetTrusteeFormA(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern TRUSTEE_FORM GetTrusteeFormW(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern TRUSTEE_FORM GetTrusteeFormW(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetTrusteeNameA(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetTrusteeNameA(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetTrusteeNameW(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetTrusteeNameW(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern TRUSTEE_TYPE GetTrusteeTypeA(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern TRUSTEE_TYPE GetTrusteeTypeA(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern TRUSTEE_TYPE GetTrusteeTypeW(IntPtr pTrustee);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern TRUSTEE_TYPE GetTrusteeTypeW(ref TRUSTEE pTrustee);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetEntriesInAclA(uint cCountOfExplicitEntries, IntPtr pListOfExplicitEntries, IntPtr OldAcl, IntPtr NewAcl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint SetEntriesInAclA(uint cCountOfExplicitEntries, EXPLICIT_ACCESS[] pListOfExplicitEntries, ref ACL OldAcl, ref IntPtr NewAcl);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetEntriesInAclW(uint cCountOfExplicitEntries, IntPtr pListOfExplicitEntries, IntPtr OldAcl, IntPtr NewAcl);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint SetEntriesInAclW(uint cCountOfExplicitEntries, EXPLICIT_ACCESS[] pListOfExplicitEntries, ref ACL OldAcl, ref IntPtr NewAcl);
    }

    #endregion // Access control functions

    #region Client and server access control functions

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, [Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, string lpApplicationName, StringBuilder lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, string lpApplicationName, StringBuilder lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, [Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, string lpApplicationName, StringBuilder lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, string lpApplicationName, StringBuilder lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessWithLogonW([Const] IntPtr lpUserName, [Const] IntPtr lpDomain, [Const] IntPtr lpPassword, uint dwLogonFlags, [Const] IntPtr lpApplicationName, IntPtr lpCommandLine, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInfo);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessWithLogonW(string lpUserName, string lpDomain, string lpPassword, uint dwLogonFlags, string lpApplicationName, StringBuilder lpCommandLine, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ImpersonateLoggedOnUser(IntPtr hToken);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ImpersonateNamePipeClient(IntPtr hNamedPipe);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ImpersonateSelf(SECURITY_IMPERSONATION_LEVEL ImpersonationLevel);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LogonUserA(IntPtr lpszUserName, IntPtr lpszDomain, IntPtr lpszPassword, uint dwLogonType, uint dwLogonProvider, IntPtr phToken);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LogonUserA(StringBuilder lpszUserName, StringBuilder lpszDomain, StringBuilder lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LogonUserW(IntPtr lpszUserName, IntPtr lpszDomain, IntPtr lpszPassword, uint dwLogonType, uint dwLogonProvider, IntPtr phToken);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LogonUserW(StringBuilder lpszUserName, StringBuilder lpszDomain, StringBuilder lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LogonUserExA(IntPtr lpszUserName, IntPtr lpszDomain, IntPtr lpszPassword, uint dwLogonType, uint dwLogonProvider, IntPtr phToken, IntPtr ppLogonSid, IntPtr ppProfileBuffer, IntPtr pdwProfileLength, IntPtr pQuotaLimits);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LogonUserExA(StringBuilder lpszUserName, StringBuilder lpszDomain, StringBuilder lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken, ref IntPtr ppLogonSid, ref IntPtr ppProfileBuffer, ref uint pdwProfileLength, ref QUOTA_LIMITS pQuotaLimits);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LogonUserExW(IntPtr lpszUserName, IntPtr lpszDomain, IntPtr lpszPassword, uint dwLogonType, uint dwLogonProvider, IntPtr phToken, IntPtr ppLogonSid, IntPtr ppProfileBuffer, IntPtr pdwProfileLength, IntPtr pQuotaLimits);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LogonUserExW(StringBuilder lpszUserName, StringBuilder lpszDomain, StringBuilder lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken, ref IntPtr ppLogonSid, ref IntPtr ppProfileBuffer, ref uint pdwProfileLength, ref QUOTA_LIMITS pQuotaLimits);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RevertToSelf();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheck(IntPtr pSecurityDescriptor, IntPtr ClientToken, uint DesiredAccess, IntPtr GenericMapping, IntPtr PrivilegeSet, IntPtr PrivilegeSetLength, IntPtr GrantedAccess, IntPtr AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheck(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr ClientToken, uint DesiredAccess, ref GENERIC_MAPPING GenericMapping, ref PRIVILEGE_SET PrivilegeSet, ref uint PrivilegeSetLength, ref uint GrantedAccess, ref int AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmA([Const] IntPtr SubsystemName, IntPtr HandleId, IntPtr ObjectTypeName, IntPtr ObjectName, IntPtr SecurityDescriptor, uint DesiredAccess, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatus, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmA(string SubsystemName, IntPtr HandleId, StringBuilder ObjectTypeName, StringBuilder ObjectName, ref SECURITY_DESCRIPTOR SecurityDescriptor, uint DesiredAccess, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, ref int AccessStatus, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmW([Const] IntPtr SubsystemName, IntPtr HandleId, IntPtr ObjectTypeName, IntPtr ObjectName, IntPtr SecurityDescriptor, uint DesiredAccess, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatus, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmW(string SubsystemName, IntPtr HandleId, StringBuilder ObjectTypeName, StringBuilder ObjectName, ref SECURITY_DESCRIPTOR SecurityDescriptor, uint DesiredAccess, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, ref int AccessStatus, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByType(IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, IntPtr ClientToken, uint DesiredAccess, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, IntPtr PrivilegeSet, IntPtr PrivilegeSetLength, IntPtr GrantedAccess, IntPtr AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByType(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, IntPtr ClientToken, uint DesiredAccess, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, ref PRIVILEGE_SET PrivilegeSet, ref uint PrivilegeSetLength, ref uint GrantedAccess, ref int AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmA([Const] IntPtr SubsystemName, IntPtr HandleId, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescritor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatus, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmA(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescritor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, ref int AccessStatus, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmW([Const] IntPtr SubsystemName, IntPtr HandleId, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescritor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatus, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmW(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescritor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, ref int AccessStatus, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultList(IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, IntPtr ClientToken, uint DesiredAccess, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, IntPtr PrivilegeSet, IntPtr PrivilegeSetLength, IntPtr GrantedAccessList, IntPtr AccessStatusList);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultList(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, IntPtr ClientToken, uint DesiredAccess, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, ref PRIVILEGE_SET PrivilegeSet, ref uint PrivilegeSetLength, uint[] GrantedAccessList, uint[] AccessStatusList);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA([Const] IntPtr SubsystemName, IntPtr HandleId, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatusList, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, uint[] AccessStatusList, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmW([Const] IntPtr SubsystemName, IntPtr HandleId, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatusList, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmW(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, uint[] AccessStatusList, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA([Const] IntPtr SubsystemName, IntPtr HandleId, IntPtr ClientToken, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatusList, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA(string SubsystemName, IntPtr HandleId, IntPtr ClientToken, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, uint[] AccessStatusList, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleW([Const] IntPtr SubsystemName, IntPtr HandleId, IntPtr ClientToken, [Const] IntPtr ObjectTypeName, [Const] IntPtr ObjectName, IntPtr pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, IntPtr ObjectTypeList, uint ObjectTypeListLength, IntPtr GenericMapping, int ObjectCreation, IntPtr GrantedAccess, IntPtr AccessStatusList, IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleW(string SubsystemName, IntPtr HandleId, IntPtr ClientToken, string ObjectTypeName, string ObjectName, ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr PrincipalSelfSid, uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, uint Flags, ref OBJECT_TYPE_LIST ObjectTypeList, uint ObjectTypeListLength, ref GENERIC_MAPPING GenericMapping, int ObjectCreation, ref uint GrantedAccess, uint[] AccessStatusList, ref int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AreAllAccessesGranted(uint GrantedAccess, uint DesiredAccess);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AreAnyAccessesGranted(uint GrantedAccess, uint DesiredAccess);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorA(IntPtr pOwner, IntPtr pGroup, uint cCountOfAccessEntries, IntPtr pListOfAccessEntries, uint cCountOfAuditEntries, IntPtr pListOfAuditEntries, IntPtr pOldSD, IntPtr pSizeNewSD, IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorA(ref TRUSTEE pOwner, ref TRUSTEE pGroup, uint cCountOfAccessEntries, EXPLICIT_ACCESS[] pListOfAccessEntries, uint cCountOfAuditEntries, EXPLICIT_ACCESS[] pListOfAuditEntries, ref SECURITY_DESCRIPTOR pOldSD, ref uint pSizeNewSD, ref IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorW(IntPtr pOwner, IntPtr pGroup, uint cCountOfAccessEntries, IntPtr pListOfAccessEntries, uint cCountOfAuditEntries, IntPtr pListOfAuditEntries, IntPtr pOldSD, IntPtr pSizeNewSD, IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorW(ref TRUSTEE pOwner, ref TRUSTEE pGroup, uint cCountOfAccessEntries, EXPLICIT_ACCESS[] pListOfAccessEntries, uint cCountOfAuditEntries, EXPLICIT_ACCESS[] pListOfAuditEntries, ref SECURITY_DESCRIPTOR pOldSD, ref uint pSizeNewSD, ref IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertToAutoInheritPrivateObjectSecurity(IntPtr ParentDescriptor, IntPtr CurrentSecurityDescriptor, IntPtr NewSecurityDescriptor, IntPtr ObjectType, int IsDirectoryObject, IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertToAutoInheritPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ParentDescriptor, ref SECURITY_DESCRIPTOR CurrentSecurityDescriptor, ref IntPtr NewSecurityDescriptor, ref GUID ObjectType, int IsDirectoryObject, ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreatePrivateObjectSecurity(IntPtr ParentDescriptor, IntPtr CreatorDescriptor, IntPtr NewDescriptor, int IsDirectoryObject, IntPtr Token, IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurity(ref SECURITY_DESCRIPTOR ParentDescriptor, ref SECURITY_DESCRIPTOR CreatorDescriptor, ref IntPtr NewDescriptor, int IsDirectoryObject, IntPtr Token, ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityEx(IntPtr ParentDescriptor, IntPtr CreatorDescriptor, IntPtr NewDescriptor, IntPtr ObejctType, int IsContainerObject, uint AutoInheritFlags, IntPtr Token, IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityEx(ref SECURITY_DESCRIPTOR ParentDescriptor, ref SECURITY_DESCRIPTOR CreatorDescriptor, ref IntPtr NewDescriptor, ref GUID ObejctType, int IsContainerObject, uint AutoInheritFlags, IntPtr Token, ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityWithMultipleInheritance(IntPtr ParentDescriptor, IntPtr CreatorDescriptor, IntPtr NewDescriptor, IntPtr ObjectType, uint GuidCount, int IsContainerObject, uint AutoInheritFlags, IntPtr Token, IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityWithMultipleInheritance(ref SECURITY_DESCRIPTOR ParentDescriptor, IntPtr CreatorDescriptor, ref SECURITY_DESCRIPTOR NewDescriptor, ref GUID[] ObjectType, uint GuidCount, int IsContainerObject, uint AutoInheritFlags, IntPtr Token, ref GENERIC_MAPPING GenericMapping);
        
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DestroyPrivateObjectSecurity(IntPtr ObjectDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DestroyPrivateObjectSecurity(ref IntPtr ObjectDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetPrivateObjectSecurity(IntPtr ObjectDescriptor, SECURITY_INFORMATION SecurityInformation, IntPtr ResultantDescriptor, uint DescriptorLength, IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor, SECURITY_INFORMATION SecurityInformation, ref SECURITY_DESCRIPTOR ResultantDescriptor, uint DescriptorLength, ref uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint LookupSecurityDescriptorPartsA(IntPtr pOwner, IntPtr pGroup, IntPtr cCountOfAccessEntries, IntPtr pListOfAccessEntries, IntPtr cCountOfAuditEntries, IntPtr pListOfAuditEntries, IntPtr pSD);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint LookupSecurityDescriptorPartsW(IntPtr pOwner, IntPtr pGroup, IntPtr cCountOfAccessEntries, IntPtr pListOfAccessEntries, IntPtr cCountOfAuditEntries, IntPtr pListOfAuditEntries, IntPtr pSD);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void MapGenericMask(IntPtr AccessMask, IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void MapGenericMask(ref uint AccessMask, ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PrivilegeCheck(IntPtr ClientToken, PRIVILEGE_SET RequiredPrivileges, IntPtr pfResult);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PrivilegeCheck(IntPtr ClientToken, PRIVILEGE_SET RequiredPrivileges, ref int pfResult);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPrivateObjectSecurity(SECURITY_INFORMATION SecurityInformation, IntPtr ModificationDescriptor, IntPtr ObjectSecurityDescriptor, IntPtr GenericMapping, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPrivateObjectSecurity(SECURITY_INFORMATION SecurityInformation, ref SECURITY_DESCRIPTOR ModificationDescriptor, ref IntPtr ObjectSecurityDescriptor, ref GENERIC_MAPPING GenericMapping, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPrivateObjectSecurityEx(SECURITY_INFORMATION SecurityInformation, IntPtr ModificationDescriptor, IntPtr SecurityDescriptor, uint AutoInheritFlags, IntPtr GenericMapping, IntPtr Token);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPrivateObjectSecurityEx(SECURITY_INFORMATION SecurityInformation, ref SECURITY_DESCRIPTOR ModificationDescriptor, ref IntPtr SecurityDescriptor, uint AutoInheritFlags, ref GENERIC_MAPPING GenericMapping, IntPtr Token);
    }

    #endregion // Client and server access control functions
}
