using System;
using System.Text;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.kernel32
{
    [Serializable]
    public partial class kernel32 : ModuleBase<kernel32>
    {
        [NonSerialized]
        public const string ModuleName = "kernel32.dll";
    }

    #region Atom functions

    partial class kernel32
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM AddAtomA([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern ATOM AddAtomA(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM AddAtomW([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern ATOM AddAtomW(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM DeleteAtom(ATOM nAtom);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM FindAtomA([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern ATOM FindAtomA(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM FindAtomW([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern ATOM FindAtomW(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetAtomNameA(ATOM nAtom, IntPtr lpBuffer, int nSize);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetAtomNameA(ATOM nAtom, StringBuilder lpBuffer, int nSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetAtomNameW(ATOM nAtom, IntPtr lpBuffer, int nSize);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetAtomNameW(ATOM nAtom, StringBuilder lpBuffer, int nSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM GlobalAddAtomA([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern ATOM GlobalAddAtomA(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM GlobalAddAtomW([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern ATOM GlobalAddAtomW(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM GlobalDeleteAtom(ATOM nAtom);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM GlobalFindAtomA([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern ATOM GlobalFindAtomA(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern ATOM GlobalFindAtomW([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern ATOM GlobalFindAtomW(string lpString);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GlobalGetAtomNameA(ATOM nAtom, IntPtr lpBuffer, int nSize);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GlobalGetAtomNameA(ATOM nAtom, StringBuilder lpBuffer, int nSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GlobalGetAtomNameW(ATOM nAtom, IntPtr lpBuffer, int nSize);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GlobalGetAtomNameW(ATOM nAtom, StringBuilder lpBuffer, int nSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int InitAtomTable(uint nSize);

        public static IntPtr MAKEINTATOM(int i)
        {
            return new IntPtr((uint)((ushort)i));
        }
    }

    #endregion // Atom functions

    #region Debugging functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ContinueDebugEvent(uint dwProcessId, uint dwThreadId, uint dwContinueStatus);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DebugActiveProcess(uint dwProcessId);

        [DllImport(ModuleName)]
        public static extern void DebugBreak();

        [DllImport(ModuleName)]
        public static extern void FatalExit(int ExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, uint dwSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadContext(IntPtr hThread, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

        [Todo("LDT_ENTRY implementation missing")]
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, IntPtr lpSelectorEntry);

        [DllImport(ModuleName)]
        public static extern int IsDebuggerPresent();

        [DllImport(ModuleName)]
        public static extern void OutputDebugStringA([Const] IntPtr lpOutputString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern void OutputDebugStringA(string lpOutputString);

        [DllImport(ModuleName)]
        public static extern void OutputDebugStringW([Const] IntPtr lpOutputString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern void OutputDebugStringW(string lpOutputString);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadProcessMemory(IntPtr hProcess, [Const] IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesRead);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadProcessMemory(IntPtr hProcess, [Const] IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, ref uint lpNumberOfBytesRead);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void SetDebugErrorLevel(uint dwLevel);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetThreadContext(IntPtr hThread, [Const] IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitForDebugEvent(IntPtr lpDebugEvent, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitForDebugEvent(ref DEBUG_EVENT lpDebugEvent, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);
    }

    #endregion // Debugging functions

    #region Error functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int Beep(uint dwFreq, uint dwDuration);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void FatalAppExitA(uint uAction, IntPtr lpMessageText);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern void FatalAppExitA(uint uAction, string lpMessageText);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void FatalAppExitW(uint uAction, IntPtr lpMessageText);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern void FatalAppExitW(uint uAction, string lpMessageText);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetLastError();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint SetErrorMode(uint uMode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void SetLastError(uint dwErrCode);
    }

    #endregion // Error functions

    // Relocation required...

    partial class kernel32
    {
        #region user32.dll - Error functions

        [DllImport(ModuleName)]
        public static extern int FlashWindow(IntPtr hWnd, int bInvert);

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct FLASHWINFO
        {
            public uint cbSize;
            public IntPtr hwnd;
            public uint dwFlags;
            public uint uCount;
            public uint dwTimeout;
        }

        [DllImport(ModuleName)]
        public static extern int FlashWindowEx(IntPtr pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int FlashWindowEx(ref FLASHWINFO pfwi);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int MessageBeep(uint uType);

        #endregion // user32.dll - Error functions
    }
}
