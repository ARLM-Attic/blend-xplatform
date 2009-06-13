using System;
using System.Text;
using xPlatform.x86.gdi32;
using xPlatform.x86.kernel32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.user32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EditWordBreakProc(
        [In] IntPtr lpch,
        [In] int ichCurrent,
        [In] int cch,
        [In] int code);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int LVGroupCompare(
        [In] int Group1_ID,
        [In] int Group2_ID,
        [In] IntPtr pvData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AddPropSheetPageProc(
        [In] IntPtr hpage,
        [In] IntPtr lParam);
}

namespace xPlatform.x86.user32
{
    [Serializable, Flags, CLSCompliant(false)]
    public enum COLORREF : uint { }
}

namespace xPlatform.x86.user32
{
    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FLASHWINFO
    {
        public uint cbSize;
        public IntPtr hwnd;
        public uint dwFlags;
        public uint uCount;
        public uint dwTimeout;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BUTTON_IMAGELIST
    {
        public IntPtr himl;
        public RECT margin;
        public uint uAlign;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BUTTON_SPLITINFO
    {
        public uint mask;
        public IntPtr himlGlyph;
        public uint uSplitStyle;
        public SIZE size;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMHDR
    {
        public IntPtr hwndFrom;
        public uint idFrom;
        public uint code;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMBCDROPDOWN
    {
        public NMHDR hdr;
        public RECT rcButton;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMBCHOTITEM
    {
        public NMHDR hdr;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMBOBOXINFO
    {
        public uint cbSize;
        public RECT rcItem;
        public RECT rcButton;
        public uint stateButton;
        public IntPtr hwndCombo;
        public IntPtr hwndItem;
        public IntPtr hwndList;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMPAREITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint hwndItem;
        public uint itemID1;
        public uint itemData1;
        public uint itemID2;
        public uint itemData2;
        public uint dwLocaleId;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DRAWITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public uint itemAction;
        public uint itemState;
        public IntPtr hwndItem;
        public IntPtr hDC;
        public RECT rcItem;
        public uint itemData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MEASUREITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public uint itemWidth;
        public uint itemHeight;
        public uint itemData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COMBOBOXEXITEM
    {
        public uint mask;
        public int iItem;
        public IntPtr pszText;
        public int cchTextMax;
        public int iImage;
        public int iSelectedImage;
        public int iOverlay;
        public int iIndent;
        public IntPtr lParam;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMCBEDRAGBEGIN
    {
        public NMHDR hdr;
        public int iItemid;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string szText;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMCBEENDEDIT
    {
        public NMHDR hdr;
        public int fChanged;
        public int iNewSelection;
        
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string szText;
        
        public int iWhy;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMCOMBOBOXEX
    {
        public NMHDR hdr;
        public COMBOBOXEXITEM ceItem;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DATETIMEPICKERINFO
    {
        public uint cbSize;
        public RECT rcCheck;
        public uint stateCheck;
        public RECT rcButton;
        public uint stateButton;
        public IntPtr hwndEdit;
        public IntPtr hwndUD;
        public IntPtr hwndDropDown;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDATETIMECHANGE
    {
        public NMHDR nmhdr;
        public uint dwFlags;
        public SYSTEMTIME st;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDATETIMEFORMAT
    {
        public NMHDR hdr;
        public IntPtr pszFormat;
        public SYSTEMTIME st;
        public IntPtr pszDisplay;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string szDisplay;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDATETIMEFORMATQUERY
    {
        public NMHDR nmhdr;
        public IntPtr pszFormat;
        public SIZE szMax;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDATETIMESTRING
    {
        public NMHDR nmhdr;
        public IntPtr pszUserString;
        public SYSTEMTIME st;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NMDATETIMEWMKEYDOWN
    {
        public NMHDR nmhdr;
        public int nVirtKey;
        public IntPtr pszFormat;
        public SYSTEMTIME st;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DRAGLISTINFO
    {
        public uint uNotification;
        public IntPtr hWnd;
        public POINT ptCursor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SCROLLINFO
    {
        public uint cbSize;
        public uint fMask;
        public int nMin;
        public int nMax;
        public uint nPage;
        public int nPos;
        public int nTrackPos;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct WINDOWPOS
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public uint flags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DELETEITEMSTRUCT
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public IntPtr hwndItem;
        public uint itemData;
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
        public int cchTextMax;
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
}
