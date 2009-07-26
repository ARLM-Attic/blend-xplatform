using System;
using xPlatform.x86.kernel32;
using xPlatform.x86.advapi32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.authz
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUTHZ_ACCESS_REQUEST
    {
        public ACCESS_MASK DesiredAccess;
        public IntPtr PrincipalSelfSid;
        public IntPtr ObjectTypeList;
        public uint ObjectTypeListLength;
        public IntPtr OptionalArguments;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUTHZ_ACCESS_REPLY
    {
        public uint ResultListLength;
        public IntPtr GrantedAccessMask;
        public IntPtr SaclEvaluationResults;
        public IntPtr Error;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUTHZ_REGISTRATION_OBJECT_TYPE_NAME_OFFSET
    {
        public IntPtr szObjectTypeName;
        public uint dwOffset;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUTHZ_SOURCE_SCHEMA_REGISTRATION
    {
        public uint dwFlags;
        public IntPtr szEventSourceName;
        public IntPtr szEventMessageFile;
        public IntPtr szEventSourceXmlSchemaFile;
        public IntPtr szEventAccessStringsFile;
        public IntPtr szExecutableImagePath;
        public AnonymousUnion1 union1;
        public uint dwObjectTypeNameCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public AUTHZ_REGISTRATION_OBJECT_TYPE_NAME_OFFSET[] ObjectTypeNames;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUDIT_PARAM
    {
        public AUDIT_PARAM_TYPE Type;
        public uint Length;
        public uint Flags;
        public AnonymousUnion2 union1;
        public AnonymousUnion3 union2;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AUDIT_PARAMS
    {
        public uint Length;
        public uint Flags;
        public ushort Count;
        public IntPtr Parameters;
    }
}

namespace xPlatform.x86.authz
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AuthzAccessCheckCallback(
        [In] IntPtr hAuthzClientContext,
        [In] IntPtr pAce,
        [In] IntPtr pArgs,
        [In, Out] IntPtr pbAceApplicable);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AuthzComputeGroupsCallback(
        [In] IntPtr hAuthzClientContext,
        [In] IntPtr Args,
        [Out] IntPtr pSidAttrArray,
        [Out] IntPtr pSidCount,
        [Out] IntPtr pRestrictedSidAttrArray,
        [Out] IntPtr pRestrictedSidCount);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AuthzFreeGroupsCallback(
        [In] IntPtr pSidAttrArray);
}

namespace xPlatform.x86.authz
{
    [Serializable]
    public enum AUTHZ_CONTEXT_INFORMATION_CLASS : int
    {
        AuthzContextInfoUserSid = 1,
        AuthzContextInfoGroupsSids,
        AuthzContextInfoRestrictedSids,
        AuthzContextInfoPrivileges,
        AuthzContextInfoExpirationTime,
        AuthzContextInfoServerContext,
        AuthzContextInfoIdentifier,
        AuthzContextInfoSource,
        AuthzContextInfoAll,
        AuthzContextInfoAuthenticationId
    }

    [Serializable]
    public enum AUDIT_PARAM_TYPE : int
    {
        APT_None = 1,
        APT_String,
        APT_Ulong,
        APT_Pointer,
        APT_Sid,
        APT_LogonId,
        APT_ObjectTypeList,
        APT_Luid,
        APT_Guid,
        APT_Time,
        APT_Int64,
        APT_IpAddress,
        APT_LogonIdWithSid
    }
}

namespace xPlatform.x86.authz
{
    [Serializable, StructLayout(LayoutKind.Explicit)]
    public struct AnonymousUnion1
    {
        [FieldOffset(0)]
        public IntPtr pReserved;

        [FieldOffset(0)]
        public IntPtr pProviderGuid;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct AnonymousUnion2
    {
        [FieldOffset(0)]
        public uint Data0;

        [FieldOffset(0)]
        public IntPtr String;

        [FieldOffset(0)]
        public uint u;

        [FieldOffset(0)]
        public IntPtr psid;

        [FieldOffset(0)]
        public IntPtr pguid;

        [FieldOffset(0)]
        public uint LogonId_LowPart;

        [FieldOffset(0)]
        public IntPtr pObjectTypes;

        [FieldOffset(0)]
        public IntPtr pIpAddress;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct AnonymousUnion3
    {
        [FieldOffset(0)]
        public uint Data1;

        [FieldOffset(0)]
        public int LogonId_HighPart;
    }
}