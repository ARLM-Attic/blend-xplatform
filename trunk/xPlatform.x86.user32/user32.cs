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
    }

    #endregion // Common control functions
}