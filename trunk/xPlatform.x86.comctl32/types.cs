using System;
using System.Text;
using xPlatform.x86.gdi32;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.comctl32
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EDITBALLOONTIP
    {
        public uint cbStruct;
        public IntPtr pszTitle;
        public IntPtr pszText;
        public int ttiIcon;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DRAGLISTINFO
    {
        public uint uNotification;
        public IntPtr hWnd;
        public POINT ptCursor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct HDHITTESTINFO
    {
        public POINT pt;
        public uint flags;
        public int iItem;
    }

    // HDITEM
}
