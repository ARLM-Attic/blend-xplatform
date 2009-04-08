using System;
using System.Text;
using xPlatform.Flags;
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
}