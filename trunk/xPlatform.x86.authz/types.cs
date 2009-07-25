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

    [Serializable, StructLayout(LayoutKind.Explicit)]
    public struct AnonymousUnion1
    {
        [FieldOffset(0)]
        public IntPtr pReserved;

        [FieldOffset(0)]
        public IntPtr pProviderGuid;
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
}
