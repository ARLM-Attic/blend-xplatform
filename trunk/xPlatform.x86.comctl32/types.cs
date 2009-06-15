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

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AddPropSheetPageProc(
        [In] IntPtr hpage,
        [In] IntPtr lParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate uint PropSheetPageProc(
        [In] IntPtr hwnd,
        [In] uint uMsg,
        [In] IntPtr ppsp);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int PropSheepProc(
        [In] IntPtr hwndDlg,
        [In] uint uMsg,
        [In] IntPtr lParam);
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

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVHITTESTINFO
    {
        public POINT pt;
        public uint flags;
        public int iItem;
        public int iSubItem;
        public int iGroup;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVINSERTGROUPSORTED
    {
        public IntPtr pfnGroupCompare;
        public IntPtr pvData;
        public LVGROUP lvGroup;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVINSERTMARK
    {
        public uint cbSize;
        public uint dwFlags;
        public int iItem;
        public uint dwReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVITEM
    {
        public uint mask;
        public int iItem;
        public int iSubItem;
        public uint state;
        public uint stateMask;
        public IntPtr pszText;
        public int cchTextMax;
        public int iImage;
        public IntPtr lParam;
        public int iIndent;
        public int iGroupId;
        public uint cColumns;
        public IntPtr puColumns;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct LVITEMINDEX
    {
        public int iItem;
        public int iGroup;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVSETINFOTIP
    {
        public uint cbSize;
        public uint dwFlags;
        public IntPtr pszText;
        public int iItem;
        public int iSubitem;
        public IntPtr hbmp;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVTILEINFO
    {
        public uint cbSize;
        public int iItem;
        public uint cColumns;
        public IntPtr puColumns;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LVTILEVIEWINFO
    {
        public uint cbSize;
        public uint dwMask;
        public uint dwFlags;
        public SIZE sizeTile;
        public int cLines;
        public RECT rcLabelMargin;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMITEMACTIVATE
    {
        public NMHDR hdr;
        public int iItem;
        public int iSubItem;
        public uint uNewState;
        public uint uOldState;
        public uint uChanged;
        public POINT ptAction;
        public IntPtr lParam;
        public uint uKeyFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLISTVIEW
    {
        public NMHDR hdr;
        public int iItem;
        public int iSubItem;
        public uint uNewState;
        public uint uOldState;
        public uint uChanged;
        public POINT ptAction;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVCACHEHINT
    {
        public NMHDR hdr;
        public int iFrom;
        public int iTo;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMCUSTOMDRAW
    {
        public NMHDR hdr;
        public uint dwDrawStage;
        public IntPtr hdc;
        public RECT rc;
        public uint dwItemSpec;
        public uint uItemState;
        public IntPtr lItemlParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVCUSTOMDRAW
    {
        public NMCUSTOMDRAW nmcd;
        public uint clrText;
        public uint clrTextBk;
        public int iSubItem;
        public uint dwItemType;
        public uint clrFace;
        public int iIconEffect;
        public int iIconPhase;
        public int iPartId;
        public int iStateId;
        public RECT rcText;
        public uint uAlign;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVDISPINFO
    {
        public NMHDR hdr;
        public LVITEM item;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct NMLVEMPTYMARKUP
    {
        public NMHDR hdr;
        public uint dwFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048 + 32 + 4)]
        public string szMarkup;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVFINDITEM
    {
        public NMHDR hdr;
        public int iStart;
        public LVFINDINFO lvfi;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVGETINFOTIP
    {
        public NMHDR hdr;
        public uint dwFlags;
        public IntPtr pszText;
        public int cchTextMax;
        public int iItem;
        public int iSubItem;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVKEYDOWN
    {
        public NMHDR hdr;
        public ushort wVKey;
        public uint flags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LITEM
    {
        public uint mask;
        public int iLink;
        public uint state;
        public uint stateMask;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
        public string szID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048 + 32 + 4)]
        public string szUrl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVLINK
    {
        public NMHDR hdr;
        public LITEM link;
        public int iItem;
        public int iSubItem;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVODSTATECHANGE
    {
        public NMHDR hdr;
        public int iFrom;
        public int iTo;
        public uint uNewState;
        public uint uOldState;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLVSCROLL
    {
        public NMHDR hdr;
        public int dx;
        public int dy;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MCGRIDINFO
    {
        public uint cbSize;
        public uint dwPart;
        public uint dwFlags;
        public int iCalendar;
        public int iRow;
        public int iCol;
        public int bSelected;
        public SYSTEMTIME stStart;
        public SYSTEMTIME stEnd;
        public RECT rc;
        public IntPtr pszName;
        public uint cchName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MCHITTESTINFO
    {
        public uint cbSize;
        public POINT pt;
        public uint uHit;
        public SYSTEMTIME st;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDAYSTATE
    {
        public NMHDR nmhdr;
        public SYSTEMTIME stStart;
        public int cDayState;
        public IntPtr prgDayState;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMSELCHANGE
    {
        public NMHDR nmhdr;
        public SYSTEMTIME stSelStart;
        public SYSTEMTIME stSelEnd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMVIEWCHANGE
    {
        public NMHDR nmhdr;
        public uint dwOldView;
        public uint dwNewView;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMPGCALCSIZE
    {
        public NMHDR hdr;
        public uint dwFlag;
        public int iWidth;
        public int iHeight;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMPGHOTITEM
    {
        public NMHDR hdr;
        public int idOld;
        public int idNew;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMPGSCROLL
    {
        public NMHDR hdr;
        public int fwKeys;
        public RECT rcParent;
        public int iDir;
        public int iXpos;
        public int iYpos;
        public int iScroll;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PBRANGE
    {
        public int iLow;
        public int iHigh;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct PROPSHEETPAGE
    {
        [FieldOffset(0)]
        public uint dwSize;

        [FieldOffset(4)]
        public uint dwFlags;

        [FieldOffset(8)]
        public IntPtr hInstance;

        [FieldOffset(12)]
        public IntPtr pszTemplate;

        [FieldOffset(12)]
        public IntPtr pResource;

        [FieldOffset(16)]
        public IntPtr hIcon;

        [FieldOffset(16)]
        public IntPtr pszIcon;

        [FieldOffset(20)]
        public IntPtr pszTitle;

        [FieldOffset(24)]
        public IntPtr pfnDlgProc;

        [FieldOffset(28)]
        public IntPtr lParam;

        [FieldOffset(32)]
        public IntPtr pfnCallback;

        [FieldOffset(36)]
        public IntPtr pcRefParent;

        [FieldOffset(40)]
        public IntPtr pszHeaderTitle;

        [FieldOffset(44)]
        public IntPtr pszHeaderSubtitle;

        [FieldOffset(48)]
        public IntPtr hActCtx;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct PROPSHEETHEADER
    {
        [FieldOffset(0)]
        public uint dwSize;

        [FieldOffset(4)]
        public uint dwFlags;

        [FieldOffset(8)]
        public IntPtr hwndParent;

        [FieldOffset(12)]
        public IntPtr hInstance;

        [FieldOffset(16)]
        public IntPtr hIcon;

        [FieldOffset(16)]
        public IntPtr pszIcon;

        [FieldOffset(20)]
        public IntPtr pszCaption;

        [FieldOffset(24)]
        public uint nPages;

        [FieldOffset(28)]
        public uint nStartPage;

        [FieldOffset(28)]
        public IntPtr pStartPage;

        [FieldOffset(32)]
        public IntPtr ppsp;

        [FieldOffset(32)]
        public IntPtr phpage;

        [FieldOffset(36)]
        public IntPtr pfnCallback;
        
        [FieldOffset(40)]
        public IntPtr hbmWatermark;

        [FieldOffset(40)]
        public IntPtr pszbmWatermark;

        [FieldOffset(44)]
        public IntPtr hplWatermark;

        [FieldOffset(48)]
        public IntPtr hbmHeader;

        [FieldOffset(48)]
        public IntPtr pszbmHeader;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PSHNOTIFY
    {
        public NMHDR hdr;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMBRAUTOSIZE
    {
        public NMHDR hdr;
        public int fChanged;
        public RECT rcTarget;
        public RECT rcActual;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMREBAR
    {
        public NMHDR hdr;
        public uint dwMask;
        public uint uBand;
        public uint fStyle;
        public uint wID;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMREBARAUTOBREAK
    {
        public NMHDR hdr;
        public uint uBand;
        public uint wID;
        public IntPtr lParam;
        public uint uMsg;
        public uint fStyleCurrent;
        public int fAutoBreak;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMREBARCHEVRON
    {
        public NMHDR hdr;
        public uint uBand;
        public uint wID;
        public IntPtr lParam;
        public RECT rc;
        public IntPtr lParamNM;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMREBARCHILDSIZE
    {
        public NMHDR hdr;
        public uint uBand;
        public uint wID;
        public RECT rcChild;
        public RECT rcBand;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMREBARSPLITTER
    {
        public NMHDR hdr;
        public RECT rcSizing;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct RBHITTESTINFO
    {
        public POINT pt;
        public uint flags;
        public int iBand;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct REBARBANDINFO
    {
        public uint cbSize;
        public uint fMask;
        public uint fStyle;
        public uint clrFore;
        public uint clrBack;
        public IntPtr lpText;
        public uint cch;
        public int iImage;
        public IntPtr hwndChild;
        public uint cxMinChild;
        public uint cyMinChild;
        public uint cx;
        public IntPtr hbmBack;
        public uint wID;
        public uint cyChild;
        public uint cyMaxChild;
        public uint cxIdeal;
        public IntPtr lParam;
        public uint cxHeader;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct REBARINFO
    {
        public uint cbSize;
        public uint fMask;
        public IntPtr himl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LHITTESTINFO
    {
        public POINT pt;
        public LITEM item;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMLINK
    {
        public NMHDR hdr;
        public LITEM item;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMTCKEYDOWN
    {
        public NMHDR hdr;
        public ushort wVKey;
        public uint flags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TCHITTESTINFO
    {
        public POINT pt;
        public uint flags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TCITEM
    {
        public uint mask;
        public uint dwState;
        public uint dwStateMask;
        public IntPtr pszText;
        public int cchTextMax;
        public int iImage;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TCITEMHEADER
    {
        public uint mask;
        public uint lpReserved1;
        public uint lpReserved2;
        public IntPtr pszText;
        public int cchTextMax;
        public int iImage;
    }
}
