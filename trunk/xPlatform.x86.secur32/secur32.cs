using System;
using System.Text;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.secur32
{
    [Serializable]
    public partial class secur32 : ModuleBase<secur32>
    {
        [NonSerialized]
        public const string ModuleName = "secur32.dll";
    }

    #region System information functions

    partial class secur32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern byte GetComputerObjectName(EXTENDED_NAME_FORMAT NameFormat, IntPtr lpNameBuffer, IntPtr nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern byte GetComputerObjectName(EXTENDED_NAME_FORMAT NameFormat, StringBuilder lpNameBuffer, ref uint nSize);
    }

    #endregion // System information functions
}
