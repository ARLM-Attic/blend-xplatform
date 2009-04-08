using System;
using System.Text;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.user32
{
    [Serializable]
    public partial class user32 : ModuleBase<user32>
    {
        [NonSerialized]
        public const string ModuleName = "user32.dll";
    }

    partial class user32
    {
        #region Error functions

        [DllImport(ModuleName)]
        public static extern int FlashWindow(IntPtr hWnd, int bInvert);

        [DllImport(ModuleName)]
        public static extern int FlashWindowEx(IntPtr pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlashWindowEx(ref FLASHWINFO pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int MessageBeep(uint uType);

        #endregion // Error functions

        #region Timer functions

        [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
        public delegate void TimerProc(IntPtr hwnd, uint uMsg, uint idEvent, uint dwTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int KillTimer(IntPtr hWnd, uint uIDEvent);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTimer(IntPtr hWnd, uint nIDEvent, uint uElpase, IntPtr lpTimerFunc);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTimer(IntPtr hWnd, uint nIDEvent, uint uElpase, TimerProc lpTimerFunc);

        #endregion // Timer functions
    }
}