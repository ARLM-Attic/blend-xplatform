using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.advapi32
{
    [Serializable]
    public partial class advapi32 : ModuleBase
    {
        [NonSerialized]
        public const string ModuleName = "advapi32.dll";
    }

    #region Authorization functions

    partial class advapi32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheck(
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In] IntPtr GenericMapping,
            [Out] IntPtr PrivilegeSet,
            [In, Out] IntPtr PrivilegeSetLength,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheck(
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In] ref GENERIC_MAPPING GenericMapping,
            [Out] out PRIVILEGE_SET PrivilegeSet,
            [In, Out] ref PRIVILEGE_SET PrivilegeSetLength,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmA(
            [In, Const] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr SecurityDescriptor,
            [In] uint DesiredAccess,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus,
            [Out] IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmA(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR SecurityDescriptor,
            [In] uint DesiredAccess,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus,
            [Out] out int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmW(
            [In, Const] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr SecurityDescriptor,
            [In] uint DesiredAccess,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus,
            [Out] IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckAndAuditAlarmW(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR SecurityDescriptor,
            [In] uint DesiredAccess,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus,
            [Out] out int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeA(
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] IntPtr GenericMapping,
            [Out] IntPtr PrivilegeSet,
            [In, Out] IntPtr PrivilegeSetLength,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeA(
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] out GENERIC_MAPPING GenericMapping,
            [Out] out PRIVILEGE_SET PrivilegeSet,
            [In, Out] ref uint PrivilegeSetLength,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeW(
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] IntPtr GenericMapping,
            [Out] IntPtr PrivilegeSet,
            [In, Out] IntPtr PrivilegeSetLength,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeW(
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] out GENERIC_MAPPING GenericMapping,
            [Out] out PRIVILEGE_SET PrivilegeSet,
            [In, Out] ref uint PrivilegeSetLength,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmA(
            [In] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus,
            [Out] IntPtr pfGeneratedOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmA(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus,
            [Out] out int pfGeneratedOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmW(
            [In] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatus,
            [Out] IntPtr pfGeneratedOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeAndAuditAlarmW(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] out int AccessStatus,
            [Out] out int pfGeneratedOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultList(
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] IntPtr GenericMapping,
            [Out] IntPtr PrivilegeSet,
            [In, Out] IntPtr PrivilegeSetLength,
            [Out] IntPtr GrantedAccessList,
            [Out] IntPtr AccessStatusList);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultList(
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] out GENERIC_MAPPING GenericMapping,
            [Out] out PRIVILEGE_SET PrivilegeSet,
            [In, Out] ref uint PrivilegeSetLength,
            [Out] uint[] GrantedAccessList,
            [Out] uint[] AccessStatusList);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultList(
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] IntPtr ClientToken,
            [In] uint DesiredAccess,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [Out] out GENERIC_MAPPING GenericMapping,
            [Out] out PRIVILEGE_SET PrivilegeSet,
            [In, Out] ref uint PrivilegeSetLength,
            [Out] uint[] GrantedAccessList,
            [Out] out uint AccessStatusList);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA(
            [In] IntPtr SubsytemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatusList,
            [Out] IntPtr pfgenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA(
            [In] string SubsytemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] uint[] AccessStatusList,
            [Out] out int pfgenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmW(
            [In] IntPtr SubsytemName,
            [In] IntPtr HandleId,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatusList,
            [Out] IntPtr pfgenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmW(
            [In] string SubsytemName,
            [In] IntPtr HandleId,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] uint[] AccessStatusList,
            [Out] out int pfgenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA(
            [In] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ClientToken,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatusList,
            [Out] IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ClientToken,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] uint[] AccessStatusList,
            [Out] out int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleW(
            [In] IntPtr SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ClientToken,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr ObjectName,
            [In] IntPtr pSecurityDescriptor,
            [In] IntPtr PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] IntPtr ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] IntPtr GenericMapping,
            [In] int ObjectCreation,
            [Out] IntPtr GrantedAccess,
            [Out] IntPtr AccessStatusList,
            [Out] IntPtr pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleW(
            [In] string SubsystemName,
            [In] IntPtr HandleId,
            [In] IntPtr ClientToken,
            [In] string ObjectTypeName,
            [In] string ObjectName,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor,
            [In] ref SID PrincipalSelfSid,
            [In] uint DesiredAccess,
            [In] AUDIT_EVENT_TYPE AuditType,
            [In] uint Flags,
            [In, Out] OBJECT_TYPE_LIST[] ObjectTypeList,
            [In] uint ObjectTypeListLength,
            [In] ref GENERIC_MAPPING GenericMapping,
            [In] int ObjectCreation,
            [Out] out uint GrantedAccess,
            [Out] uint[] AccessStatusList,
            [Out] out int pfGenerateOnClose);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AccessMask,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AccessMask,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedAceEx(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedAceEx(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedObjectAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] IntPtr ObjectTypeGuid,
            [In] IntPtr InheritedObjectTypeGuid,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessAllowedObjectAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] ref GUID ObjectTypeGuid,
            [In] ref GUID InheritedObjectTypeGuid,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AccessMask,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AccessMask,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedAceEx(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedAceEx(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedObjectAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] IntPtr ObjectTypeGuid,
            [In] IntPtr InheritedObjectTypeGuid,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAccessDeniedObjectAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] ref GUID ObjectTypeGuid,
            [In] ref GUID InheritedObjectTypeGuid,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint dwStartingAceIndex,
            [In] IntPtr pAceList,
            [In] uint nAceListLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint dwStartingAceIndex,
            [In] IntPtr pAceList,
            [In] uint nAceListLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint dwAccessMask,
            [In] IntPtr pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint dwAccessMask,
            [In] ref SID pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessAceEx(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint dwAccessMask,
            [In] IntPtr pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessAceEx(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint dwAccessMask,
            [In] ref SID pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessObjectAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] IntPtr ObjectTypeGuid,
            [In] IntPtr InheritedObjectTypeGuid,
            [In] IntPtr pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddAuditAccessObjectAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint AccessMask,
            [In] ref GUID ObjectTypeGuid,
            [In] ref GUID InheritedObjectTypeGuid,
            [In] ref SID pSid,
            [In] int bAuditSuccess,
            [In] int bAuditFailure);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddMandatoryAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint MandatoryPolicy,
            [In] IntPtr pLabelSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AddMandatoryAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceRevision,
            [In] uint AceFlags,
            [In] uint MandatoryPolicy,
            [In] ref SID pLabelSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(
            [In] IntPtr TokenHandle,
            [In] int ResetToDefault,
            [In] IntPtr NewState,
            [In] uint BufferLength,
            [Out] IntPtr PreviousState,
            [Out] IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenGroups(
            [In] IntPtr TokenHandle,
            [In] int ResetToDefault,
            [In] ref TOKEN_GROUPS NewState,
            [In] uint BufferLength,
            [Out] out TOKEN_GROUPS PreviousState,
            [Out] out uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(
            [In] IntPtr TokenHandle,
            [In] int DisableAllPrivileges,
            [In] IntPtr NewState,
            [In] uint BufferLength,
            [Out] IntPtr PreviousState,
            [Out] IntPtr ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AdjustTokenPrivileges(
            [In] IntPtr TokenHandle,
            [In] int DisableAllPrivileges,
            [In] ref TOKEN_PRIVILEGES NewState,
            [In] uint BufferLength,
            [Out] out TOKEN_PRIVILEGES PreviousState,
            [Out] out uint ReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AllocateAndInitializeSid(
            [In] IntPtr pIdentifierAuthority,
            [In] byte nSubAuthorityCount,
            [In] uint dwSubAuthority0,
            [In] uint dwSubAuthority1,
            [In] uint dwSubAuthority2,
            [In] uint dwSubAuthority3,
            [In] uint dwSubAuthority4,
            [In] uint dwSubAuthority5,
            [In] uint dwSubAuthority6,
            [In] uint dwSubAuthority7,
            [Out] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AllocateAndInitializeSid(
            [In] ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority,
            [In] byte nSubAuthorityCount,
            [In] uint dwSubAuthority0,
            [In] uint dwSubAuthority1,
            [In] uint dwSubAuthority2,
            [In] uint dwSubAuthority3,
            [In] uint dwSubAuthority4,
            [In] uint dwSubAuthority5,
            [In] uint dwSubAuthority6,
            [In] uint dwSubAuthority7,
            [Out] out SID pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AllocateLocallyUniqueId(
            [Out] IntPtr Luid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AllocateLocallyUniqueId(
            [Out] out LUID Luid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AreAllAccessesGranted(
            [In] uint GrantedAccess,
            [In] uint DesiredAccess);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AreAnyAccessesGranted(
            [In] uint GrantedAccess,
            [In] uint DesiredAccess);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditComputeEffectivePolicyBySid(
            [In] IntPtr pSid,
            [In] IntPtr pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditComputeEffectivePolicyBySid(
            [In] ref SID pSid,
            [In] ref GUID pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] out IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditComputeEffectivePolicyByToken(
            [In] IntPtr hTokenHandle,
            [In] IntPtr pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditComputeEffectivePolicyByToken(
            [In] IntPtr hTokenHandle,
            [In] ref GUID pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] out IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditEnumerateCategories(
            [Out] IntPtr ppAuditCategoriesArray,
            [Out] IntPtr pCountReturned);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditEnumerateCategories(
            [Out] out IntPtr ppAuditCategoriesArray,
            [Out] out uint pCountReturned);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr AuditEnumeratePerUserPolicy(
            [Out] IntPtr ppAuditSidArray);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr AuditEnumeratePerUserPolicy(
            [Out] out IntPtr ppAuditSidArray);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditEnumerateSubCategories(
            [In] IntPtr pAuditCategoryGuid,
            [In] int bRetrieveAllSubCategories,
            [Out] IntPtr ppAuditSubCategoriesArray,
            [Out] IntPtr pCountReturned);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditEnumerateSubCategories(
            [In] ref GUID pAuditCategoryGuid,
            [In] int bRetrieveAllSubCategories,
            [Out] out IntPtr ppAuditSubCategoriesArray,
            [Out] out uint pCountReturned);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void AuditFree(
            [In] IntPtr Buffer);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupCategoryGuidFromCategoryId(
            [In] POLICY_AUDIT_EVENT_TYPE AuditCategoryId,
            [Out] IntPtr pAuditCategoryGuid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupCategoryGuidFromCategoryId(
            [In] POLICY_AUDIT_EVENT_TYPE AuditCategoryId,
            [Out] out GUID pAuditCategoryGuid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupCategoryidFromCategoryGuid(
            [In] IntPtr pAuditCategoryGuid,
            [Out] IntPtr pAuditCategoryId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupCategoryidFromCategoryGuid(
            [In] ref GUID pAuditCategoryGuid,
            [Out] out POLICY_AUDIT_EVENT_TYPE pAuditCategoryId);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupCategoryNameA(
            [In] IntPtr pAuditCategoryGuid,
            [Out] IntPtr ppszCategoryName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupCategoryNameA(
            [In] ref GUID pAuditCategoryGuid,
            [Out] out IntPtr ppszCategoryName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupCategoryNameW(
            [In] IntPtr pAuditCategoryGuid,
            [Out] IntPtr ppszCategoryName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupCategoryNameW(
            [In] ref GUID pAuditCategoryGuid,
            [Out] out IntPtr ppszCategoryName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupSubCategoryNameA(
            [In] IntPtr pAuditSubCategoryGuid,
            [Out] IntPtr ppszSubCategoryName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupSubCategoryNameA(
            [In] IntPtr pAuditSubCategoryGuid,
            [Out] out IntPtr ppszSubCategoryName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AuditLookupSubCategoryNameW(
            [In] IntPtr pAuditSubCategoryGuid,
            [Out] IntPtr ppszSubCategoryName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditLookupSubCategoryNameW(
            [In] IntPtr pAuditSubCategoryGuid,
            [Out] out IntPtr ppszSubCategoryName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQueryPerUserPolicy(
            [In] IntPtr pSid,
            [In] IntPtr pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQueryPerUserPolicy(
            [In] ref SID pSid,
            [In] ref GUID pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] out IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQuerySecurity(
            [In] SECURITY_INFORMATION SecurityInformation,
            [Out] IntPtr ppSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQuerySecurity(
            [In] SECURITY_INFORMATION SecurityInformation,
            [Out] out SECURITY_DESCRIPTOR ppSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQuerySystemPolicy(
            [In] IntPtr pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditQuerySystemPolicy(
            [In] GUID[] pSubCategoryGuids,
            [In] uint PolicyCount,
            [Out] out IntPtr ppAuditPolicy);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetPerUserPolicy(
            [In] IntPtr pSid,
            [In] IntPtr pAuditPolicy,
            [In] uint PolicyCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetPerUserPolicy(
            [In] ref SID pSid,
            [In] AUDIT_POLICY_INFORMATION[] pAuditPolicy,
            [In] uint PolicyCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetSecurity(
            [In] SECURITY_INFORMATION SecurityInformation,
            [In] IntPtr pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetSecurity(
            [In] SECURITY_INFORMATION SecurityInformation,
            [In] ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetSystemPolicy(
            [In] IntPtr pAuditPolicy,
            [In] uint PolicyCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AuditSetSystemPolicy(
            [In] ref AUDIT_POLICY_INFORMATION pAuditPolicy,
            [In] uint PolicyCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameA(
            [In, Out] IntPtr pExplicitAccess,
            [In] IntPtr pTrusteeName,
            [In] uint AccessPermissions,
            [In] ACCESS_MODE AccessMode,
            [In] uint Inheritance);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameA(
            [In, Out] ref EXPLICIT_ACCESS pExplicitAccess,
            [In] string pTrusteeName,
            [In] uint AccessPermissions,
            [In] ACCESS_MODE AccessMode,
            [In] uint Inheritance);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameW(
            [In, Out] IntPtr pExplicitAccess,
            [In] IntPtr pTrusteeName,
            [In] uint AccessPermissions,
            [In] ACCESS_MODE AccessMode,
            [In] uint Inheritance);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildExplicitAccessWithNameW(
            [In, Out] ref EXPLICIT_ACCESS pExplicitAccess,
            [In] string pTrusteeName,
            [In] uint AccessPermissions,
            [In] ACCESS_MODE AccessMode,
            [In] uint Inheritance);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorA(
            [In] IntPtr pOwner,
            [In] IntPtr pGroup,
            [In] uint cCountOfAccessEntries,
            [In] IntPtr pListOfAccessEntries,
            [In] uint cCountOfAuditEntries,
            [In] IntPtr pListOfAuditEntries,
            [In] IntPtr pOldSD,
            [In] IntPtr pSizeNewSD,
            [In] IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorA(
            [In] ref TRUSTEE pOwner,
            [In] ref TRUSTEE pGroup,
            [In] uint cCountOfAccessEntries,
            [In] EXPLICIT_ACCESS[] pListOfAccessEntries,
            [In] uint cCountOfAuditEntries,
            [In] EXPLICIT_ACCESS[] pListOfAuditEntries,
            [In] ref SECURITY_DESCRIPTOR pOldSD,
            [In] ref uint pSizeNewSD,
            [In] ref SECURITY_DESCRIPTOR pNewSD);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorW(
            [In] IntPtr pOwner,
            [In] IntPtr pGroup,
            [In] uint cCountOfAccessEntries,
            [In] IntPtr pListOfAccessEntries,
            [In] uint cCountOfAuditEntries,
            [In] IntPtr pListOfAuditEntries,
            [In] IntPtr pOldSD,
            [In] IntPtr pSizeNewSD,
            [In] IntPtr pNewSD);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint BuildSecurityDescriptorW(
            [In] ref TRUSTEE pOwner,
            [In] ref TRUSTEE pGroup,
            [In] uint cCountOfAccessEntries,
            [In] EXPLICIT_ACCESS[] pListOfAccessEntries,
            [In] uint cCountOfAuditEntries,
            [In] EXPLICIT_ACCESS[] pListOfAuditEntries,
            [In] ref SECURITY_DESCRIPTOR pOldSD,
            [In] ref uint pSizeNewSD,
            [In] ref SECURITY_DESCRIPTOR pNewSD);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithNameA(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern void BuildTrusteeWithNameA(
            [In, Out] ref TRUSTEE pTrustee,
            [In] string pName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithNameW(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern void BuildTrusteeWithNameW(
            [In, Out] ref TRUSTEE pTrustee,
            [In] string pName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndNameA(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pObjName,
            [In] SE_OBJECT_TYPE ObjectType,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr InheritedObjectTypeName,
            [In] IntPtr Name);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndNameA(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref OBJECTS_AND_NAME pObjName,
            [In] SE_OBJECT_TYPE ObjectType,
            [In] string ObjectTypeName,
            [In] string InheritedObjectTypeName,
            [In] string Name);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndNameW(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pObjName,
            [In] SE_OBJECT_TYPE ObjectType,
            [In] IntPtr ObjectTypeName,
            [In] IntPtr InheritedObjectTypeName,
            [In] IntPtr Name);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndNameW(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref OBJECTS_AND_NAME pObjName,
            [In] SE_OBJECT_TYPE ObjectType,
            [In] string ObjectTypeName,
            [In] string InheritedObjectTypeName,
            [In] string Name);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndSidA(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pObjSid,
            [In] IntPtr pObjectGuid,
            [In] IntPtr pInheritedObjectGuid,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndSidA(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref OBJECTS_AND_SID pObjSid,
            [In] ref GUID pObjectGuid,
            [In] ref GUID pInheritedObjectGuid,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithObjectsAndSidW(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pObjSid,
            [In] IntPtr pObjectGuid,
            [In] IntPtr pInheritedObjectGuid,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildTrusteeWithObjectsAndSidW(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref OBJECTS_AND_SID pObjSid,
            [In] ref GUID pObjectGuid,
            [In] ref GUID pInheritedObjectGuid,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithSidA(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void BuildTrusteeWithSidA(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void BuildTrusteeWithSidW(
            [In, Out] IntPtr pTrustee,
            [In] IntPtr pSid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void BuildTrusteeWithSidW(
            [In, Out] ref TRUSTEE pTrustee,
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CheckTokenMembership(
            [In] IntPtr TokenHandle,
            [In] IntPtr SidToCheck,
            [Out] IntPtr IsMember);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CheckTokenMembership(
            [In] IntPtr TokenHandle,
            [In] ref SID SidToCheck,
            [Out] out int IsMember);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSecurityDescriptorToStringSecurityDescriptorA(
            [In] IntPtr SecurityDescriptor,
            [In] uint RequestedStringSDRevision,
            [In] IntPtr SecurityInformation,
            [Out] IntPtr StringSecurityDescriptor,
            [Out] IntPtr StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSecurityDescriptorToStringSecurityDescriptorA(
            [In] ref SECURITY_DESCRIPTOR SecurityDescriptor,
            [In] uint RequestedStringSDRevision,
            [In] SECURITY_INFORMATION SecurityInformation,
            [Out] out IntPtr StringSecurityDescriptor,
            [Out] out uint StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSecurityDescriptorToStringSecurityDescriptorW(
            [In] IntPtr SecurityDescriptor,
            [In] uint RequestedStringSDRevision,
            [In] IntPtr SecurityInformation,
            [Out] IntPtr StringSecurityDescriptor,
            [Out] IntPtr StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSecurityDescriptorToStringSecurityDescriptorW(
            [In] ref SECURITY_DESCRIPTOR SecurityDescriptor,
            [In] uint RequestedStringSDRevision,
            [In] SECURITY_INFORMATION SecurityInformation,
            [Out] out IntPtr StringSecurityDescriptor,
            [Out] out uint StringSecurityDescriptorLen);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConverSidToStringSidA(
            [In] IntPtr Sid,
            [Out] IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSidToStringSidA(
            [In] ref SID Sid,
            [Out] out IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConverSidToStringSidW(
            [In] IntPtr Sid,
            [Out] IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConverSidToStringSidW(
            [In] ref SID Sid,
            [Out] out IntPtr StringSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSDToSDDomainA(
            [In] IntPtr DomainSid,
            [In] IntPtr RootDomainSid,
            [In] IntPtr StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] IntPtr SecurityDescriptor,
            [Out] IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ConvertStringSDToSDDomainA(
            [In] ref SID DomainSid,
            [In] ref SID RootDomainSid,
            [In] string StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] out IntPtr SecurityDescriptor,
            [Out] out uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSDToSDDomainW(
            [In] IntPtr DomainSid,
            [In] IntPtr RootDomainSid,
            [In] IntPtr StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] IntPtr SecurityDescriptor,
            [Out] IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ConvertStringSDToSDDomainW(
            [In] ref SID DomainSid,
            [In] ref SID RootDomainSid,
            [In] string StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] out IntPtr SecurityDescriptor,
            [Out] out uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorA(
            [In] IntPtr StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] IntPtr SecurityDescriptor,
            [Out] IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorA(
            [In] string StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] out IntPtr SecurityDescriptor,
            [Out] out uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorW(
            [In] IntPtr StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] IntPtr SecurityDescriptor,
            [Out] IntPtr SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ConvertStringSecurityDescriptorToSecurityDescriptorW(
            [In] string StringSecurityDescriptor,
            [In] uint StringSDRevision,
            [Out] out IntPtr SecurityDescriptor,
            [Out] out uint SecurityDescriptorSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSidToSidA(
            [In] IntPtr StringSid,
            [Out] IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ConvertStringSidToSidA(
            [In] string StringSid,
            [Out] out IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertStringSidToSidW(
            [In] IntPtr StringSid,
            [Out] IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ConvertStringSidToSidW(
            [In] string StringSid,
            [Out] out IntPtr Sid);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConvertToAutoInheritPrivateObjectSecurity(
            [In] IntPtr ParentDescriptor,
            [In] IntPtr CurrentSecurityDescriptor,
            [Out] IntPtr NewSecurityDescriptor,
            [In] IntPtr ObjectType,
            [In] int IsDirectoryObject,
            [In] IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConvertToAutoInheritPrivateObjectSecurity(
            [In] ref SECURITY_DESCRIPTOR ParentDescriptor,
            [In] ref SECURITY_DESCRIPTOR CurrentSecurityDescriptor,
            [Out] out IntPtr NewSecurityDescriptor,
            [In] ref GUID ObjectType,
            [In] int IsDirectoryObject,
            [In] ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CopySid(
            [In] uint nDestinationSidLength,
            [Out] IntPtr pDestinationSid,
            [In] IntPtr pSourceSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CopySid(
            [In] uint nDestinationSidLength,
            [Out] out SID pDestinationSid,
            [In] ref SID pSourceSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurity(
            [In] IntPtr ParentDescriptor,
            [In] IntPtr CreatorDescriptor,
            [Out] IntPtr NewDescriptor,
            [In] int IsDirectoryObject,
            [In] IntPtr Token,
            [In] IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurity(
            [In] ref SECURITY_DESCRIPTOR ParentDescriptor,
            [In] ref SECURITY_DESCRIPTOR CreatorDescriptor,
            [Out] out IntPtr NewDescriptor,
            [In] int IsDirectoryObject,
            [In] IntPtr Token,
            [In] ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityEx(
            [In] IntPtr ParentDescriptor,
            [In] IntPtr CreatorDescriptor,
            [Out] IntPtr NewDescriptor,
            [In] IntPtr ObjectType,
            [In] int IsContainerObject,
            [In] uint AutoInheritFlags,
            [In] IntPtr Token,
            [In] IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityEx(
            [In] ref SECURITY_DESCRIPTOR ParentDescriptor,
            [In] ref SECURITY_DESCRIPTOR CreatorDescriptor,
            [Out] out IntPtr NewDescriptor,
            [In] ref GUID ObjectType,
            [In] int IsContainerObject,
            [In] uint AutoInheritFlags,
            [In] IntPtr Token,
            [In] ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityWithMultipleInheritance(
            [In] IntPtr ParentDescriptor,
            [In] IntPtr CreatorDescriptor,
            [Out] IntPtr NewDescriptor,
            [In] IntPtr ObjectTypes,
            [In] uint GuidCount,
            [In] int IsContainerObject,
            [In] uint AutoInheritFlags,
            [In] IntPtr Token,
            [In] IntPtr GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePrivateObjectSecurityWithMultipleInheritance(
            [In] ref SECURITY_DESCRIPTOR ParentDescriptor,
            [In] ref SECURITY_DESCRIPTOR CreatorDescriptor,
            [Out] out IntPtr NewDescriptor,
            [In] IntPtr[] ObjectTypes,
            [In] uint GuidCount,
            [In] int IsContainerObject,
            [In] uint AutoInheritFlags,
            [In] IntPtr Token,
            [In] ref GENERIC_MAPPING GenericMapping);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateRestrictedToken(
            [In] IntPtr ExistingTokenHandle,
            [In] uint Flags,
            [In] uint DisableSidCount,
            [In] IntPtr SidsToDisable,
            [In] uint DeletePrivilegeCount,
            [In] IntPtr PrivilegesToDelete,
            [In] uint RestrictedSidCount,
            [In] IntPtr SidsToRestrict,
            [Out] IntPtr NewTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateRestrictedToken(
            [In] IntPtr ExistingTokenHandle,
            [In] uint Flags,
            [In] uint DisableSidCount,
            [In] SID_AND_ATTRIBUTES[] SidsToDisable,
            [In] uint DeletePrivilegeCount,
            [In] LUID_AND_ATTRIBUTES[] PrivilegesToDelete,
            [In] uint RestrictedSidCount,
            [In] SID_AND_ATTRIBUTES[] SidsToRestrict,
            [Out] out IntPtr NewTokenHandle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateSecurityPage(
            [In] IntPtr psi);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateWellKnownSid(
            [In] WELL_KNOWN_SID_TYPE WellKnownSidType,
            [In] IntPtr DomainSid,
            [Out] IntPtr pSid,
            [In, Out] IntPtr cbSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateWellKnownSid(
            [In] WELL_KNOWN_SID_TYPE WellKnownSidType,
            [In] ref SID DomainSid,
            [Out] out SID pSid,
            [In, Out] ref uint cbSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DeleteAce(
            [In, Out] IntPtr pAcl,
            [In] uint dwAceIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DeleteAce(
            [In, Out] ref ACL pAcl,
            [In] uint dwAceIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DestroyPrivateObjectSecurity(
            [In, Out] IntPtr ObjectDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DestroyPrivateObjectSecurity(
            [In, Out] ref SECURITY_DESCRIPTOR ObjectDescriptor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DuplicateToken(
            [In] IntPtr ExistingTokenHandle,
            [In] SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            [Out] IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateToken(
            [In] IntPtr ExistingTokenHandle,
            [In] SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            [Out] out IntPtr DuplicateTokenHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(
            [In] IntPtr hExistingToken,
            [In] uint dwDesiredAccess,
            [In] IntPtr lpTokenAttributes,
            [In] SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            [In] TOKEN_TYPE TokenType,
            [Out] IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateTokenEx(
            [In] IntPtr hExistingToken,
            [In] uint dwDesiredAccess,
            [In] ref SECURITY_ATTRIBUTES lpTokenAttributes,
            [In] SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            [In] TOKEN_TYPE TokenType,
            [Out] out IntPtr phNewToken);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualDomainSid(
            [In] IntPtr pSid1,
            [In] IntPtr pSid2,
            [Out] IntPtr pfEqual);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EqualDomainSid(
            [In] ref SID pSid1,
            [In] ref SID pSid2,
            [Out] out int pfEqual);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualPrefixSid(
            [In] IntPtr pSid1,
            [In] IntPtr pSid2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EqualPrefixSid(
            [In] ref SID pSid1,
            [In] ref SID pSid2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EqualSid(
            [In] IntPtr pSid1,
            [In] IntPtr pSid2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EqualSid(
            [In] ref SID pSid1,
            [In] ref SID pSid2);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindFirstFreeAce(
            [In] IntPtr pAcl,
            [Out] IntPtr pAce);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FindFirstFreeAce(
            [In] ref ACL pAcl,
            [Out] out IntPtr pAce);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint FreeInheritedFromArray(
            [In] IntPtr pInheritedArray,
            [In] ushort AceCnt,
            [In] IntPtr pfnArray);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint FreeInheritedFromArray(
            [In] INHERITED_FROM[] pInheritedArray,
            [In] ushort AceCnt,
            [In] IntPtr pfnArray);

        [DllImport(ModuleName)]
        public static extern void FreeSid(
            [In] IntPtr pSid);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void FreeSid(
            [In] ref SID pSid);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetAce(
            [In] IntPtr pAcl,
            [In] uint dwAceIndex,
            [Out] IntPtr pAce);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetAce(
            [In] ref ACL pAcl,
            [In] uint dwAceIndex,
            [Out] out IntPtr pAce);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetAclInformation(
            [In] IntPtr pAcl,
            [Out] IntPtr pAclInformation,
            [In] uint nAclInformationLength,
            [In] ACL_INFORMATION_CLASS dwAclInformationClass);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetAclInformation(
            [In] ref ACL pAcl,
            [Out] out IntPtr pAclInformation,
            [In] uint nAclInformationLength,
            [In] ACL_INFORMATION_CLASS dwAclInformationClass);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAcl(
            [In] IntPtr pAcl,
            [In] IntPtr pTrustee,
            [Out] IntPtr pSuccessfulAuditedRights,
            [Out] IntPtr pFailedAuditedRights);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAcl(
            [In] IntPtr pAcl,
            [In] IntPtr pTrustee,
            [Out] out ACCESS_MASK pSuccessfulAuditedRights,
            [Out] out ACCESS_MASK pFailedAuditedRights);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetAuditedPermissionsFromAcl(
            [In] ref ACL pAcl,
            [In] ref TRUSTEE pTrustee,
            [Out] out ACCESS_MASK pSuccessfulAuditedRights,
            [Out] out ACCESS_MASK pFailedAuditedRights);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAcl(
            [In] IntPtr pacl,
            [In] IntPtr pTrustee,
            [Out] IntPtr pAccessRights);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAcl(
            [In] IntPtr pacl,
            [In] IntPtr pTrustee,
            [Out] out ACCESS_MASK pAccessRights);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetEffectiveRightsFromAcl(
            [In] ref ACL pacl,
            [In] ref TRUSTEE pTrustee,
            [Out] out ACCESS_MASK pAccessRights);
    }

    #endregion // Authorization functions
}
