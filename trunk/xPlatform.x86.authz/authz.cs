using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.kernel32;
using xPlatform.x86.advapi32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.authz
{
    [Serializable]
    public partial class authz : ModuleBase<authz>
    {
        [NonSerialized]
        public const string ModuleName = "authz.dll";
    }

    #region Authorization functions

    partial class authz
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzAccessCheck(
            [In] uint flags,
            [In] IntPtr AuthzClientContext,
            [In] IntPtr pRequest,
            [In] IntPtr AuditInfo,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr OptionalSecurityDescriptorArray,
            [In] uint OptionalSecurityDescriptorCount,
            [In, Out] IntPtr pReply,
            [Out] IntPtr pAuthzHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzAccessCheck(
            [In] uint flags,
            [In] IntPtr AuthzClientContext,
            [In] ref AUTHZ_ACCESS_REQUEST pRequest,
            [In] IntPtr AuditInfo,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] SECURITY_DESCRIPTOR[] OptionalSecurityDescriptorArray,
            [In] uint OptionalSecurityDescriptorCount,
            [In, Out] ref AUTHZ_ACCESS_REPLY pReply,
            [Out] out IntPtr pAuthzHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzAddSidsToContext(
            [In] IntPtr OrigClientContext,
            [In] IntPtr Sids,
            [In] uint SidCount,
            [In] IntPtr RestrictedSids,
            [In] uint RestrictedSidCount,
            [Out] IntPtr pNewClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzAddSidsToContext(
            [In] IntPtr OrigClientContext,
            [In] ref SID_AND_ATTRIBUTES Sids,
            [In] uint SidCount,
            [In] ref SID_AND_ATTRIBUTES RestrictedSids,
            [In] uint RestrictedSidCount,
            [Out] out IntPtr pNewClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzCachedAccessCheck(
            [In] uint Flags,
            [In] IntPtr AuthzHandle,
            [In] IntPtr pRequest,
            [In] IntPtr AuditInfo,
            [Out] IntPtr pReply);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzCachedAccessCheck(
            [In] uint Flags,
            [In] IntPtr AuthzHandle,
            [In] ref AUTHZ_ACCESS_REQUEST pRequest,
            [In] IntPtr AuditInfo,
            [Out] out AUTHZ_ACCESS_REPLY pReply);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzEnumerateSecurityEventSources(
            [In] uint dwFlags,
            [Out] IntPtr Buffer,
            [Out] uint pdwCount,
            [In, Out] IntPtr pdwLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzEnumerateSecurityEventSources(
            [In] uint dwFlags,
            [Out] AUTHZ_SOURCE_SCHEMA_REGISTRATION[] Buffer,
            [Out] uint pdwCount,
            [In, Out] ref uint pdwLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuthzFreeAuditEvent(
            [In] IntPtr pAuditEventInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuthzFreeContext(
            [In] IntPtr AuthzClientContext);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuthzFreeHandle(
            [In] IntPtr AuthzHandle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuthzFreeResourceManager(
            [In] IntPtr AuthzResourceManager);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzGetInformationFromContext(
            [In] IntPtr hAuthzClientContext,
            [In] AUTHZ_CONTEXT_INFORMATION_CLASS InfoClass,
            [In] uint BufferSize,
            [Out] IntPtr pSizeRequired,
            [Out] IntPtr buffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzGetInformationFromContext(
            [In] IntPtr hAuthzClientContext,
            [In] AUTHZ_CONTEXT_INFORMATION_CLASS InfoClass,
            [In] uint BufferSize,
            [Out] out uint pSizeRequired,
            [Out] IntPtr buffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromAuthzContext(
            [In] uint flags,
            [In] IntPtr AuthzHandle,
            [In] IntPtr ExpirationTime,
            [In] LUID Identifier,
            IntPtr DynamicGroupArgs,
            [Out] IntPtr phNewAuthzHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromAuthzContext(
            [In] uint flags,
            [In] IntPtr AuthzHandle,
            [In] ref LARGE_INTEGER ExpirationTime,
            [In] LUID Identifier,
            IntPtr DynamicGroupArgs,
            [Out] out IntPtr phNewAuthzHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromSid(
            [In] uint Flags,
            [In] IntPtr UserSid,
            [In] IntPtr hAuthzResourceManager,
            [In] IntPtr pExpirationTime,
            [In] LUID Identifier,
            [In] IntPtr DynamicGroupArgs,
            [Out] IntPtr pAuthzClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromSid(
            [In] uint Flags,
            [In] ref SID UserSid,
            [In] IntPtr hAuthzResourceManager,
            [In] ref LARGE_INTEGER pExpirationTime,
            [In] LUID Identifier,
            [In] IntPtr DynamicGroupArgs,
            [Out] out IntPtr pAuthzClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromToken(
            [In] uint Flags,
            [In] IntPtr TokenHandle,
            [In] IntPtr AuthzResourceManager,
            [In] IntPtr pExpirationTime,
            [In] LUID Identifier,
            [In] IntPtr DynamicGroupArgs,
            [Out] IntPtr pAuthzClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeContextFromToken(
            [In] uint Flags,
            [In] IntPtr TokenHandle,
            [In] IntPtr AuthzResourceManager,
            [In] ref LARGE_INTEGER pExpirationTime,
            [In] LUID Identifier,
            [In] IntPtr DynamicGroupArgs,
            [Out] out IntPtr pAuthzClientContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeObjectAccessAuditEvent(
            [In] uint Flags,
            [In] IntPtr hAuditEventType,
            [In] IntPtr szOperationType,
            [In] IntPtr szObjectType,
            [In] IntPtr szObjectName,
            [In] IntPtr szAdditionalInfo,
            [Out] IntPtr phAuditEvent,
            [In] uint dwAdditionalParamCount);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AuthzInitializeObjectAccessAuditEvent(
            [In] uint Flags,
            [In] IntPtr hAuditEventType,
            [In] string szOperationType,
            [In] string szObjectType,
            [In] string szObjectName,
            [In] string szAdditionalInfo,
            [Out] out IntPtr phAuditEvent,
            [In] uint dwAdditionalParamCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeObjectAccessAuditEvent2(
            [In] uint Flags,
            [In] IntPtr hAuditEventType,
            [In] IntPtr szOperationType,
            [In] IntPtr szObjectType,
            [In] IntPtr szObjectName,
            [In] IntPtr szAdditionalInfo,
            [In] IntPtr szAdditionalInfo2,
            [Out] IntPtr phAuditEvent,
            [In] uint dwAdditionalParameterCount);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AuthzInitializeObjectAccessAuditEvent2(
            [In] uint Flags,
            [In] IntPtr hAuditEventType,
            [In] string szOperationType,
            [In] string szObjectType,
            [In] string szObjectName,
            [In] string szAdditionalInfo,
            [In] string szAdditionalInfo2,
            [Out] out IntPtr phAuditEvent,
            [In] uint dwAdditionalParameterCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInitializeResourceManager(
            [In] uint flags,
            [In] IntPtr pfnAccessCheck,
            [In] IntPtr pfnComputeDynamicGroups,
            [In] IntPtr pfnFreeDynamicGroups,
            [In] IntPtr ResourceManagerName,
            [Out] IntPtr pAuthzResourceManager);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AuthzInitializeResourceManager(
            [In] uint flags,
            [In] AuthzAccessCheckCallback pfnAccessCheck,
            [In] AuthzComputeGroupsCallback pfnComputeDynamicGroups,
            [In] AuthzFreeGroupsCallback pfnFreeDynamicGroups,
            [In] string ResourceManagerName,
            [Out] out IntPtr pAuthzResourceManager);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInstallSecurityEventSource(
            [In] uint dwFlags,
            [In] IntPtr pRegistration);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuthzInstallSecurityEventSource(
            [In] uint dwFlags,
            [In] ref AUTHZ_SOURCE_SCHEMA_REGISTRATION pRegistration);

        // AuthzOpenObjectAudit
    }

    #endregion // Authorization functions
}
