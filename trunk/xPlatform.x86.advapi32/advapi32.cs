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
    }

    #endregion // Authorization functions
}
