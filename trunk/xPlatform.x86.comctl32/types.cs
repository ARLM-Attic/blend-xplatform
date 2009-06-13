using System;
using System.Text;
using xPlatform.x86.gdi32;
using xPlatform.x86.user32;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.comctl32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int LVGroupCompare(
        [In] int Group1_ID,
        [In] int Group2_ID,
        [In] IntPtr pvData);
}

namespace xPlatform.x86.comctl32
{
    [Serializable, Flags]
    public enum IMAGELISTDRAWFLAGS : int
    {
        ILD_NORMAL = 0x00000000,
        ILD_TRANSPARENT = 0x00000001,
        ILD_BLEND25 = 0x00000002,
        ILD_FOCUS = ILD_BLEND25,
        ILD_BLEND50 = 0x00000004,
        ILD_SELECTED = ILD_BLEND50,
        ILD_BLEND = 0x00000004,
        ILD_MASK = 0x00000010,
        ILD_IMAGE = 0x00000020,
        ILD_ROP = 0x00000040,
        ILD_OVERLAYMASK = 0x00000F00,
        ILD_PRESERVEALPHA = 0x00001000,
        ILD_SCALE = 0x00002000,
        ILD_DPISCALE = 0x00004000,
        ILD_ASYNC = 0x00008000
    }

    [Serializable, Flags]
    public enum IMAGELISTSTATEFLAGS : int
    {
        ILS_NORMAL = 0x00000000,

        [Obsolete("Not supported.")]
        ILS_GLOW = 0x00000001,

        [Obsolete("Not supported.")]
        ILS_SHADOW = 0x00000002,

        ILS_SATURATE = 0x00000004,
        ILS_ALPHA = 0x00000008
    }
}

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

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct HDITEM
    {
        public uint mask;
        public int cxy;
        public IntPtr pszText;
        public IntPtr hbm;
        public int cchTextMax;
        public int fmt;
        public IntPtr lParam;
        public int iImage;
        public int iOrder;
        public uint type;
        public IntPtr pvFilter;
        public uint state;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct HDLAYOUT
    {
        public IntPtr prc;
        public IntPtr pwpos;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct HDTEXTFILTER
    {
        public IntPtr psztext;
        public int cchTextMax;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMHDDISPINFO
    {
        public NMHDR hdr;
        public int iItem;
        public uint mask;
        public IntPtr pszText;
        public int cchTextMax;
        public int iImage;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMHDFILTERBTNCLICK
    {
        public NMHDR hdr;
        public int iItem;
        public RECT rc;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMHEADER
    {
        public NMHDR hdr;
        public int iItem;
        public int iButton;
        public IntPtr pItem;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct IMAGELISTDRAWPARAMS
    {
        public uint cbSize;
        public IntPtr himl;
        public int i;
        public IntPtr hdcDst;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public int xBitmap;
        public int yBitmap;
        public uint rgbBk;
        public uint rgbFg;
        public uint fStyle;
        public uint dwRop;
        public uint fState;
        public uint Frame;
        public uint crEffect;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct IMAGEINFO
    {
        public IntPtr hbmImage;
        public IntPtr hbmMask;
        public int Unused1;
        public int Unused2;
        public RECT rcImage;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMIPADDRESS
    {
        public NMHDR hdr;
        public int iField;
        public int iValue;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVBKIMAGE
    {
        public uint ulFlags;
        public IntPtr hbm;
        public IntPtr pszImage;
        public uint cchImageMax;
        public int xOffsetPercent;
        public int yOffsetPercent;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVCOLUMN
    {
        public uint mask;
        public int fmt;
        public int cx;
        public IntPtr pszText;
        public int cchTextMax;
        public int iSubItem;
        public int iImage;
        public int iOrder;
        public int cxMin;
        public int cxDefault;
        public int cxIdeal;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVFINDINFO
    {
        public uint flags;
        public IntPtr psz;
        public IntPtr lParam;
        public POINT pt;
        public uint vkDirection;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVFOOTERINFO
    {
        public uint mask;
        public IntPtr pszText;
        public int cchTextMax;
        public uint cItems;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVFOOTERITEM
    {
        public uint mask;
        public int iItem;
        public IntPtr pszText;
        public uint state;
        public uint stateMask;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVGROUP
    {
        public uint cbSize;
        public uint mask;
        public IntPtr pszHeader;
        public int cchHeader;
        public IntPtr pszFooter;
        public int cchFooter;
        public int iGroupId;
        public uint stateMask;
        public uint state;
        public uint uAlign;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVGROUPMETRICS
    {
        public uint cbSize;
        public uint mask;
        public uint Left;
        public uint Top;
        public uint Right;
        public uint Bottom;
        public uint crLeft;
        public uint crTop;
        public uint crRight;
        public uint crBottom;
        public uint crHeader;
        public uint crFooter;
    }
}
