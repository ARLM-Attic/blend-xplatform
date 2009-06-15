using System;
using System.Text;
using xPlatform.Flags;
using xPlatform.x86.gdi32;
using xPlatform.x86.advapi32;
using System.Runtime.InteropServices;

namespace xPlatform.x86.user32
{
    [Serializable]
    public partial class user32 : ModuleBase<user32>
    {
        [NonSerialized]
        public const string ModuleName = "user32.dll";
    }

    #region Error functions

    partial class user32
    {
        [DllImport(ModuleName)]
        public static extern int FlashWindow(IntPtr hWnd, int bInvert);

        [DllImport(ModuleName)]
        public static extern int FlashWindowEx(IntPtr pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlashWindowEx(ref FLASHWINFO pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int MessageBeep(uint uType);
    }

    #endregion // Error functions

    #region Timer functions

    partial class user32
    {
        [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
        public delegate void TimerProc(IntPtr hwnd, uint uMsg, uint idEvent, uint dwTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int KillTimer(IntPtr hWnd, uint uIDEvent);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTimer(IntPtr hWnd, uint nIDEvent, uint uElpase, IntPtr lpTimerFunc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTimer(IntPtr hWnd, uint nIDEvent, uint uElpase, TimerProc lpTimerFunc);
    }

    #endregion // Timer functions

    #region System information functions

    partial class user32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetSysColor(int nIndex);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetSysColors(int cElements, [Const] IntPtr lpaElements, [Const] IntPtr lpaRgbValues);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetSysColors(int cElements, int[] lpaElements, COLORREF[] lpaRgbValues);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SystemParametersInfoA(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern byte TranslateNameA([Const] IntPtr lpAccountName, EXTENDED_NAME_FORMAT AccountNameFormat, EXTENDED_NAME_FORMAT DesiredNameFormat, IntPtr lpTranslatedName, IntPtr nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern byte TranslateNameA(string lpAccountName, EXTENDED_NAME_FORMAT AccountNameFormat, EXTENDED_NAME_FORMAT DesiredNameFormat, StringBuilder lpTranslatedName, ref uint nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern byte TranslateNameW([Const] IntPtr lpAccountName, EXTENDED_NAME_FORMAT AccountNameFormat, EXTENDED_NAME_FORMAT DesiredNameFormat, IntPtr lpTranslatedName, IntPtr nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern byte TranslateNameW(string lpAccountName, EXTENDED_NAME_FORMAT AccountNameFormat, EXTENDED_NAME_FORMAT DesiredNameFormat, StringBuilder lpTranslatedName, ref uint nSize);
    }

    #endregion // System information functions

    #region Common control functions

    partial class user32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CheckDlgButton(
            [In] IntPtr hDlg,
            [In] int nIDButton,
            [In] uint uCheck);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CheckRadioButton(
            [In] IntPtr hDlg,
            [In] int nIDFirstButton,
            [In] int nIDLastButton,
            [In] int nIDCheckButton);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint IsDlgButtonChecked(
            [In] IntPtr hDlg,
            [In] int nIDButton);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DlgDirListComboBoxA(
            [In] IntPtr hDlg,
            [In] IntPtr lpPathSpec,
            [In] int nIDComboBox,
            [In] int nIDStaticPath,
            [In] uint uFiletype);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DlgDirListComboBoxA(
            [In] IntPtr hDlg,
            [In] string lpPathSpec,
            [In] int nIDComboBox,
            [In] int nIDStaticPath,
            [In] uint uFiletype);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DlgDirListComboBoxW(
            [In] IntPtr hDlg,
            [In] IntPtr lpPathSpec,
            [In] int nIDComboBox,
            [In] int nIDStaticPath,
            [In] uint uFiletype);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DlgDirListComboBoxW(
            [In] IntPtr hDlg,
            [In] string lpPathSpec,
            [In] int nIDComboBox,
            [In] int nIDStaticPath,
            [In] uint uFiletype);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DlgDirSelectComboBoxExA(
            [In] IntPtr hDlg,
            [In] IntPtr lpString,
            [In] int nCount,
            [In] int nIDComboBox);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int DlgDirSelectComboBoxExA(
            [In] IntPtr hDlg,
            [In] string lpString,
            [In] int nCount,
            [In] int nIDComboBox);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DlgDirSelectComboBoxExW(
            [In] IntPtr hDlg,
            [In] IntPtr lpString,
            [In] int nCount,
            [In] int nIDComboBox);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DlgDirSelectComboBoxExW(
            [In] IntPtr hDlg,
            [In] string lpString,
            [In] int nCount,
            [In] int nIDComboBox);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetComboBoxInfo(
            [In] IntPtr hwndCombo,
            [Out] IntPtr pcbi);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetComboBoxInfo(
            [In] IntPtr hwndCombo,
            [Out] out COMBOBOXINFO pcbi);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void DrawInsert(
            [In] IntPtr handParent,
            [In] IntPtr hLB,
            [In] int nItem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LBItemFromPt(
            [In] IntPtr hLB,
            [In] POINT pt,
            [In] int bAutoScroll);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MakeDragList(
            [In] IntPtr hLB);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DlgDirListA(
            [In] IntPtr hDlg,
            [In, Out] IntPtr lpPathSpec,
            [In] int nIDListBox,
            [In] int nIDStaticPath,
            [In] uint uFileType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DlgDirListA(
            [In] IntPtr hDlg,
            [In, Out] StringBuilder lpPathSpec,
            [In] int nIDListBox,
            [In] int nIDStaticPath,
            [In] uint uFileType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DlgDirListW(
            [In] IntPtr hDlg,
            [In, Out] IntPtr lpPathSpec,
            [In] int nIDListBox,
            [In] int nIDStaticPath,
            [In] uint uFileType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DlgDirListW(
            [In] IntPtr hDlg,
            [In, Out] StringBuilder lpPathSpec,
            [In] int nIDListBox,
            [In] int nIDStaticPath,
            [In] uint uFileType);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DlgDirSelectExA(
            [In] IntPtr hDlg,
            [Out] IntPtr lpString,
            [In] int nCount,
            [In] int nIDListBox);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int DlgDirSelectExA(
            [In] IntPtr hDlg,
            [Out] StringBuilder lpString,
            [In] int nCount,
            [In] int nIDListBox);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DlgDirSelectExW(
            [In] IntPtr hDlg,
            [Out] IntPtr lpString,
            [In] int nCount,
            [In] int nIDListBox);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DlgDirSelectExW(
            [In] IntPtr hDlg,
            [Out] StringBuilder lpString,
            [In] int nCount,
            [In] int nIDListBox);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetListBoxInfo(
            [In] IntPtr hwnd);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnableScrollBar(
            [In] IntPtr hWnd,
            [In] uint wSBflags,
            [In] uint wArrows);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetScrollBarInfo(
            [In] IntPtr hwnd,
            [In] int idObject,
            [Out] IntPtr psbi);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetScrollBarInfo(
            [In] IntPtr hwnd,
            [In] int idObject,
            [Out] out SCROLLBARINFO psbi);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] IntPtr lpsi);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [Out] out SCROLLINFO lpsi);

        [DllImport(ModuleName, SetLastError = true), Obsolete]
        public static extern int GetScrollPos(
            [In] IntPtr hwnd,
            [In] int nBar);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetScrollRange(
            [In] IntPtr hWnd,
            [In] int nBar,
            [Out] IntPtr lpMinPos,
            [Out] IntPtr lpMaxPos);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetScrollRange(
            [In] IntPtr hWnd,
            [In] int nBar,
            [Out] out int lpMinPos,
            [Out] out int lpMaxPos);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScrollDC(
            [In] IntPtr hDC,
            [In] int dx,
            [In] int dy,
            [Const, In] IntPtr lprcScroll,
            [Const, In] IntPtr lprcClip,
            [In] IntPtr hrgnUpdate,
            [Out] IntPtr lprcUpdate);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScrollDC(
            [In] IntPtr hDC,
            [In] int dx,
            [In] int dy,
            [In] ref RECT lprcScroll,
            [In] ref RECT lprcClip,
            [In] IntPtr hrgnUpdate,
            [Out] out RECT lprcUpdate);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScrollWindow(
            [In] IntPtr hWnd,
            [In] int XAmount,
            [In] int YAmount,
            [Const, In] IntPtr lpRect,
            [Const, In] IntPtr lpClipRect);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ScrollWindow(
            [In] IntPtr hWnd,
            [In] int XAmount,
            [In] int YAmount,
            [In] ref RECT lpRect,
            [In] ref RECT lpClipRect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ScrollWindowEx(
            [In] IntPtr hWnd,
            [In] int dx,
            [In] int dy,
            [In, Const] IntPtr prcScroll,
            [In, Const] IntPtr prcClip,
            [In] IntPtr hrgnUpdate,
            [Out] IntPtr prcUpdate,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ScrollWindowEx(
            [In] IntPtr hWnd,
            [In] int dx,
            [In] int dy,
            [In] ref RECT prcScroll,
            [In] ref RECT prcClip,
            [In] IntPtr hrgnUpdate,
            [Out] out RECT prcUpdate,
            [In] uint flags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In, Const] IntPtr lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetScrollInfo(
            [In] IntPtr hwnd,
            [In] int fnBar,
            [In] ref SCROLLINFO lpsi,
            [In] int fRedraw);

        [DllImport(ModuleName, SetLastError = true), Obsolete]
        public static extern int SetScrollPos(
            [In] IntPtr hWnd,
            [In] int nBar,
            [In] int nPos,
            [In] int bRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetScrollRange(
            [In] IntPtr hWnd,
            [In] int nBar,
            [In] int nMinPos,
            [In] int nMaxPos,
            [In] int bRedraw);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ShowScrollBar(
            [In] IntPtr hWnd,
            [In] int wBar,
            [In] int bShow);
    }

    #endregion // Common control functions
}