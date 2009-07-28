using System;
using System.Text;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.dssec
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int PFNREADOBJECTSECURITY(
        [In] IntPtr adPathOfObj,
        [In] SECURITY_INFORMATION securityInfo,
        [In] IntPtr lpReturnedSecurityDescriptor,
        [In] ushort contextParameter);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int PFNWRITEOBJECTSECURITY(
        [In] IntPtr adPathOfObj,
        [In] SECURITY_INFORMATION securityInfo,
        [In, Out] IntPtr lpReturnedSecurityDescriptor,
        [In] ushort contextParameter);
}
