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

        // BuildExplicitAccessWithName
    }

    #endregion // Access control functions
}
