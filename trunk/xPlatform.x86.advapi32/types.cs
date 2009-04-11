using System;
using System.Text;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.advapi32
{
    [Serializable]
    public enum EXTENDED_NAME_FORMAT : int
    {
        NameUnknown = 0,
        NameFullyQualifiedDN = 1,
        NameSamCompatible = 2,
        NameDisplay = 3,
        NameUniqueId = 6,
        NameCanonical = 7,
        NameUserPrincipal = 8,
        NameCanonicalEx = 9,
        NameServicePrincipal = 10
    }

    [Serializable]
    public enum SECURITY_IMPERSONATION_LEVEL : int
    {
        SecurityAnonymous,
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation 
    }

    [Serializable]
    public enum TOKEN_INFORMATION_CLASS : int
    {
        TokenUser = 1,
        TokenGroups,
        TokenPrivileges,
        TokenOwner,
        TokenPrimaryGroup,
        TokenDefaultDacl,
        TokenSource,
        TokenType,
        TokenImpersonationLevel,
        TokenStatistics,
        TokenRestrictedSids 
    }

    [Serializable]
    public enum TOKEN_TYPE : int
    {
        TokenPrimary = 1,
        TokenImpersonation 
    }

    [Serializable]
    public enum WELL_KNOWN_SID_TYPE : int
    {
        WinNullSid = 0,
        WinWorldSid = 1,
        WinLocalSid = 2,
        WinCreatorOwnerSid = 3,
        WinCreatorGroupSid = 4,
        WinCreatorOwnerServerSid = 5,
        WinCreatorGroupServerSid = 6,
        WinNtAuthoritySid = 7,
        WinDialupSid = 8,
        WinNetworkSid = 9,
        WinBatchSid = 10,
        WinInteractiveSid = 11,
        WinServiceSid = 12,
        WinAnonymousSid = 13,
        WinProxySid = 14,
        WinEnterpriseControllersSid = 15,
        WinSelfSid = 16,
        WinAuthenticatedUserSid = 17,
        WinRestrictedCodeSid = 18,
        WinTerminalServerSid = 19,
        WinRemoteLogonIdSid = 20,
        WinLogonIdsSid = 21,
        WinLocalSystemSid = 22,
        WinLocalServiceSid = 23,
        WinNetworkServiceSid = 24,
        WinBuiltinDomainSid = 25,
        WinBuiltinAdministratorsSid = 26,
        WinBuiltinUsersSid = 27,
        WinBuiltinGuestsSid = 28,
        WinBuiltinPowerUsersSid = 29,
        WinBuiltinAccountOperatorsSid = 30,
        WinBuiltinSystemOperatorsSid = 31,
        WinBuiltinPrintOperatorsSid = 32,
        WinBuiltinBackupOperatorsSid = 33,
        WinBuiltinReplicatorSid = 34,
        WinBuiltinPreWindows2000CompatibleAccessSid = 35,
        WinBuiltinRemoteDesktopUsersSid = 36,
        WinBuiltinNetworkConfigurationOperatorsSid = 37,
        WinAccountAdministratorSid = 38,
        WinAccountGuestSid = 39,
        WinAccountKrbtgtSid = 40,
        WinAccountDomainAdminsSid = 41,
        WinAccountDomainUsersSid = 42,
        WinAccountDomainGuestsSid = 43,
        WinAccountComputersSid = 44,
        WinAccountControllersSid = 45,
        WinAccountCertAdminsSid = 46,
        WinAccountSchemaAdminsSid = 47,
        WinAccountEnterpriseAdminsSid = 48,
        WinAccountPolicyAdminsSid = 49,
        WinAccountRasAndIasServersSid = 50,
    }

    [Serializable]
    public enum SID_NAME_USE
    {
        SidTypeUser = 1,
        SidTypeGroup,
        SidTypeDomain,
        SidTypeAlias,
        SidTypeWellKnownGroup,
        SidTypeDeletedAccount,
        SidTypeInvalid,
        SidTypeUnknown,
        SidTypeComputer
    }

    [Serializable]
    public enum SE_OBJECT_TYPE : int
    {
        SE_UNKNOWN_OBJECT_TYPE = 0,
        SE_FILE_OBJECT,
        SE_SERVICE,
        SE_PRINTER,
        SE_REGISTRY_KEY,
        SE_LMSHARE,
        SE_KERNEL_OBJECT,
        SE_WINDOW_OBJECT,
        SE_DS_OBJECT,
        SE_DS_OBJECT_ALL,
        SE_PROVIDER_DEFINED_OBJECT,
        SE_WMIGUID_OBJECT,
        SE_REGISTRY_WOW64_32KEY
    }

    [Serializable, Flags, CLSCompliant(false)]
    public enum ACCESS_MASK : uint
    {
        SPECIFIC_RIGHTS_ALL = 0x0000FFFFu,
        STANDARD_RIGHTS_REQUIRED = 0x000F0000u,
        STANDARD_RIGHTS_ALL = 0x001F0000u
    }

    [Serializable]
    public enum ACCESS_MODE : int
    {
        NOT_USED_ACCESS = 0,
        GRANT_ACCESS,
        SET_ACCESS,
        DENY_ACCESS,
        REVOKE_ACCESS,
        SET_AUDIT_SUCCESS,
        SET_AUDIT_FAILURE
    }

    [Serializable]
    public enum MULTIPLE_TRUSTEE_OPERATION : int
    {
        NO_MULTIPLE_TRUSTEE,
        TRUSTEE_IS_IMPERSONATE
    }

    [Serializable]
    public enum TRUSTEE_FORM : int
    {
        TRUSTEE_IS_SID,
        TRUSTEE_IS_NAME,
        TRUSTEE_BAD_FORM,
        TRUSTEE_IS_OBJECTS_AND_SID,
        TRUSTEE_IS_OBJECTS_AND_NAME
    }

    [Serializable]
    public enum TRUSTEE_TYPE : int
    {
        TRUSTEE_IS_UNKNOWN,
        TRUSTEE_IS_USER,
        TRUSTEE_IS_GROUP,
        TRUSTEE_IS_DOMAIN,
        TRUSTEE_IS_ALIAS,
        TRUSTEE_IS_WELL_KNOWN_GROUP,
        TRUSTEE_IS_DELETED,
        TRUSTEE_IS_INVALID,
        TRUSTEE_IS_COMPUTER
    }
}

namespace xPlatform.x86.advapi32
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EFS_CERTIFICATE_BLOB
    {
        public uint dwCertEncodingType;
        public uint cbData;
        public IntPtr pbData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct SID_IDENTIFIER_AUTHORITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Value;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SID
    {
        public byte Revision;
        public byte SubAuthorityCount;
        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

        [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)]
        public uint[] SubAuthority;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENCRYPTION_CERTIFICATE
    {
        public uint cbTotalLength;
        public IntPtr pUserSid;
        public IntPtr pCertBlob;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENCRYPTION_CERTIFICATE_LIST
    {
        public uint nUsers;
        public IntPtr pUsers;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EFS_HASH_BLOB
    {
        public uint cbData;
        public IntPtr pbData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENCRYPTION_CERTIFICATE_HASH
    {
        public uint cbTotalLength;
        public IntPtr pUserSid;
        public IntPtr pHash;
        public IntPtr lpDisplayInformation;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENCRYPTION_CERTIFICATE_HASH_LIST
    {
        public uint nCert_Hash;
        public IntPtr pUsers;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), CLSCompliant(false)]
    public struct HW_PROFILE_INFO
    {
        public uint dwDockInfo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
        public string szHwProfileGuid;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szHwProfileName;
    }

    [Serializable, StructLayout(LayoutKind.Explicit)]
    public struct LUID
    {
        [FieldOffset(0)]
        public long QuadPart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SID_AND_ATTRIBUTES
    {
        public IntPtr Sid;
        public uint Attributes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TOKEN_GROUPS
    {
        public uint GroupCount;

        [MarshalAs(UnmanagedType.ByValArray)]
        public SID_AND_ATTRIBUTES[] Groups;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LUID_AND_ATTRIBUTES
    {
        public LUID Luid;
        public uint Attributes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TOKEN_PRIVILEGES
    {
        public uint PrivilegeCount;

        [MarshalAs(UnmanagedType.ByValArray)]
        public LUID_AND_ATTRIBUTES[] Privileges;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct TRUSTEE
    {
        public IntPtr pMultipleTrustee;
        public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;
        public TRUSTEE_FORM TrusteeForm;
        public TRUSTEE_TYPE TrusteeType;
        public IntPtr ptstrName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXPLICIT_ACCESS
    {
        public ACCESS_MASK grfAccessPermission;
        public ACCESS_MODE grfAccessMode;
        public uint grfInheritance;
        public TRUSTEE Trustee;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACE_HEADER
    {
        public byte AceType;
        public byte AceFlags;
        public ushort AceSize;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_ALLOWED_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_ALLOWED_OBJECT_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint Flags;
        public GUID ObjectType;
        public GUID InheritedObjectType;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_DENIED_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_DENIED_OBJECT_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint Flags;
        public GUID ObjectType;
        public GUID InheritedObjectType;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_AUDIT_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ACCESS_AUDIT_OBJECT_ACE
    {
        public ACE_HEADER Header;
        public ACCESS_MASK Mask;
        public uint Flags;
        public GUID ObjectType;
        public GUID InheritedObjectType;
        public uint SidStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OBJECTS_AND_NAME
    {
        public uint ObjectsPresent;
        public SE_OBJECT_TYPE ObjectType;
        public IntPtr ObjectTypeName;
        public IntPtr InheritedObjectTypeName;
        public IntPtr ptstrName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OBJECTS_AND_SID
    {
        public uint ObjectsPresent;
        public GUID ObjectTypeGuid;
        public GUID InheritedObjectTypeGuid;
        public IntPtr pSID;
    }
}
