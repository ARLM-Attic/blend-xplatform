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
}
