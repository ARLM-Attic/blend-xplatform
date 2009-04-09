using System;
using System.Text;
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
        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeConst = 6)]
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
    public struct SID_IDENTIFIER_AUTHORITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Value;
    }
}
