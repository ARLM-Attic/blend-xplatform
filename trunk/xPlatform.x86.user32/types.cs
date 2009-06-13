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
}
