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

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DebugActiveProcessStop(uint dwProcessId);

        [DllImport(ModuleName)]
        public static extern void DebugBreak();

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DebugBreakProcess(IntPtr Process);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DebugSetProcessKillOnExit(int KillOnExit);

        [DllImport(ModuleName)]
        public static extern void FatalExit(int ExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, uint dwSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadContext(IntPtr hThread, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, IntPtr lpSelectorEntry);

        [Todo("Test Required")]
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, ref LDT_ENTRY lpSelectorEntry);

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

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true), CLSCompliant(false)]
        public static extern uint FormatMessageA(uint dwFlags, [Const] IntPtr lpSource, uint dwMessageId, uint dwLanguageId, IntPtr lpBuffer, uint nSize, IntPtr Arguments);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, SetLastError = true), CLSCompliant(false)]
        public static extern uint FormatMessageA(uint dwFlags, [Const] IntPtr lpSource, uint dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, uint nSize, IntPtr Arguments);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true), CLSCompliant(false)]
        public static extern uint FormatMessageW(uint dwFlags, [Const] IntPtr lpSource, uint dwMessageId, uint dwLanguageId, IntPtr lpBuffer, uint nSize, IntPtr Arguments);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, SetLastError = true), CLSCompliant(false)]
        public static extern uint FormatMessageW(uint dwFlags, [Const] IntPtr lpSource, uint dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, uint nSize, IntPtr Arguments);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetLastError();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint SetErrorMode(uint uMode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void SetLastError(uint dwErrCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);
    }

    #endregion // Error functions

    #region Console functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AllocConsole();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int AttachConsole(uint dwProcessId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateConsoleScreenBuffer(uint dwDesiredAccess, uint dwShareMode, [Const] IntPtr lpSecurityAttributes, uint dwFlags, IntPtr lpScreenBufferData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateConsoleScreenBuffer(uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwFlags, IntPtr lpScreenBufferData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputAttribute(IntPtr hConsoleOutput, ushort wAttribute, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfAttrsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputAttribute(IntPtr hConsoleOutput, ushort wAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputCharacterA(IntPtr hConsoleOutput, sbyte cCharacter, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputCharacterA(IntPtr hConsoleOutput, sbyte cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputCharacterW(IntPtr hConsoleOutput, ushort cCharacter, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FillConsoleOutputCharacterW(IntPtr hConsoleOutput, ushort cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlushConsoleInputBuffer(IntPtr hConsoleInput);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FreeConsole();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetConsoleCP();

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetConsoleCursorInfo(IntPtr hConsoleOutput, IntPtr lpConsoleCursorInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetConsoleDisplayMode(IntPtr lpModeFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetConsoleDisplayMode(ref uint lpModeFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern COORD GetConsoleFontSize(IntPtr hConsoleOutput, uint nFont);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetConsoleMode(IntPtr hConsoleOutput, IntPtr lpMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetConsoleMode(IntPtr hConsoleOutput, ref uint lpMode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetConsoleOutputCP();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetConsoleProcessList(IntPtr lpdwProcessList, uint dwProcessCount);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetConsoleProcessList(uint[] lpdwProcessList, uint dwProcessCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, IntPtr lpConsoleScreenBufferInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetConsoleTitleA(IntPtr lpConsoleTitle, uint nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetConsoleTitleA(StringBuilder lpConsoleTitle, uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetConsoleTitleW(IntPtr lpConsoleTitle, uint nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetConsoleTitleW(StringBuilder lpConsoleTitle, uint nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, IntPtr lpcNumberOfEvents);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref uint lpcNumberOfEvents);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetNumberOfConsoleMouseButtons(IntPtr hNumberOfMouseButtons);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNumberOfConsoleMouseButtons(out uint lpNumberOfMouseButtons);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GetStdHandle(uint nStdHandle);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int PeekConsoleInputA(IntPtr hConsoleInput, IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int PeekConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int PeekConsoleInputW(IntPtr hConsoleInput, IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int PeekConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleA(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, IntPtr lpNumberOfCharsRead, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleA(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleW(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, IntPtr lpNumberOfCharsRead, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleW(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleInputA(IntPtr hConsoleInput, IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReadConsoleInputW(IntPtr hConsoleInput, IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReadConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int ReadConsoleOutputA(IntPtr hConsoleOutput, IntPtr lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, IntPtr lpReadRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ReadConsoleOutputW(IntPtr hConsoleOutput, IntPtr lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, IntPtr lpReadRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReadConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadConsoleOutputAttribute(IntPtr hConsoleOutput, IntPtr lpAttribute, uint nLength, COORD dwReadCoord, IntPtr lpNumberOfAttrsRead);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadConsoleOutputAttribute(IntPtr hConsoleOutput, ref uint lpAttribute, uint nLength, COORD dwReadCoord, ref uint lpNumberOfAttrsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleOutputCharacterA(IntPtr hConsoleOutput, IntPtr lpCharacter, uint nLength, COORD dwReadCoord, IntPtr lpNumberOfCharsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReadConsoleOutputCharacterA(IntPtr hConsoleOutput, StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReadConsoleOutputCharacterW(IntPtr hConsoleOutput, IntPtr lpCharacter, uint nLength, COORD dwReadCoord, IntPtr lpNumberOfCharsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReadConsoleOutputCharacterW(IntPtr hConsoleOutput, StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int ScrollConsoleScreenBufferA(IntPtr hConsoleOutput, [Const] IntPtr lpScrollRectangle, [Const] IntPtr lpClipRectangle, COORD dwDestinationOrigin, [Const] IntPtr lpFill);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ScrollConsoleScreenBufferA(IntPtr hConsoleOutput, [Const] ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ScrollConsoleScreenBufferW(IntPtr hConsoleOutput, [Const] IntPtr lpScrollRectangle, [Const] IntPtr lpClipRectangle, COORD dwDestinationOrigin, [Const] IntPtr lpFill);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ScrollConsoleScreenBufferW(IntPtr hConsoleOutput, [Const] ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleCP(uint wCodePageID);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleCtrlHandler(IntPtr HandlerRoutine, int Add);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleCtrlHandler(HandlerRoutine HandlerRoutine, int Add);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleCursorInfo(IntPtr hConsoleOutput, [Const] IntPtr lpConsoleCursorInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleOutputCP(uint wCodePageId);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleTextAttributes(IntPtr hConsoleOutput, ushort wAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleTitleA([Const] IntPtr lpConsoleTitle);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetConsoleTitleA(string lpConsoleTitle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleTitleW([Const] IntPtr lpConsoleTitle);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetConsoleTitleW(string lpConsoleTitle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetConsoleWindowInfo(IntPtr hConsoleOutput, int bAbsolute, [Const] IntPtr lpConsoleWindow);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetConsoleWindowInfo(IntPtr hConsoleOutput, int bAbsolute, ref SMALL_RECT lpConsoleWindow);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetStdHandle(uint nStdHandle, IntPtr nHandle);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleA(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, uint nNumberOfCharsToWrite, IntPtr lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleA(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleW(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, uint nNumberOfCharsToWrite, IntPtr lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleW(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleInputA(IntPtr hConsoleInput, [Const] IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEvnetsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleInputA(IntPtr hConsoleInput, [Const] IntPtr lpBuffer, uint nLength, ref uint lpNumberOfEvnetsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleInputW(IntPtr hConsoleInput, [Const] IntPtr lpBuffer, uint nLength, IntPtr lpNumberOfEvnetsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleInputW(IntPtr hConsoleInput, [Const] IntPtr lpBuffer, uint nLength, ref uint lpNumberOfEvnetsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int WriteConsoleOutputA(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, IntPtr lpWriteRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int WriteConsoleOutputW(IntPtr hConsoleOutput, [Const] IntPtr lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, IntPtr lpWriteRegion);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteConsoleOutputAttribute(IntPtr hConsoleOutput, [Const] IntPtr lpAttribute, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfAttrsWritten);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteConsoleOutputAttribute(IntPtr hConsoleOutput, ref ushort lpAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleOutputCharacterA(IntPtr hConsoleOutput, [Const] IntPtr lpCharacter, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WriteConsoleOutputCharacterA(IntPtr hConsoleOutput, StringBuilder lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleOutputCharacterW(IntPtr hConsoleOutput, [Const] IntPtr lpCharacter, uint nLength, COORD dwWriteCoord, IntPtr lpNumberOfCharsWritten);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WriteConsoleOutputCharacterW(IntPtr hConsoleOutput, StringBuilder lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);
    }

    #endregion // Console functions

    #region Dynamic link library functions

    partial class kernel32
    {
        [DllImport(ModuleName)]
        public static extern int DisableThreadLibraryCalls(IntPtr hModule);

        [DllImport(ModuleName)]
        public static extern int FreeLibrary(IntPtr hModule);

        [DllImport(ModuleName)]
        public static extern void FreeLibraryAndExitThread(IntPtr hModule, int dwExitCode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetModuleFileNameA(IntPtr hModule, IntPtr lpFIleName, uint nSize);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetModuleFileNameA(IntPtr hModule, StringBuilder lpFIleName, uint nSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetModuleFileNameW(IntPtr hModule, IntPtr lpFIleName, uint nSize);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetModuleFileNameW(IntPtr hModule, StringBuilder lpFIleName, uint nSize);

        [DllImport(ModuleName)]
        public static extern IntPtr GetModuleHandleA([Const] IntPtr lpModuleName);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetModuleHandleA(string lpModuleName);

        [DllImport(ModuleName)]
        public static extern IntPtr GetModuleHandleW([Const] IntPtr lpModuleName);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandleW(string lpModuleName);

        [DllImport(ModuleName)]
        public static extern IntPtr GetProcAddressA(IntPtr hModule, [Const] IntPtr lpProcName);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddressA(IntPtr hModule, string lpProcName);

        [DllImport(ModuleName)]
        public static extern IntPtr GetProcAddressW(IntPtr hModule, [Const] IntPtr lpProcName);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern IntPtr GetProcAddressW(IntPtr hModule, string lpProcName);

        [DllImport(ModuleName)]
        public static extern IntPtr LoadLibraryA([Const] IntPtr lpLibFileName);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibraryA(string lpLibFileName);

        [DllImport(ModuleName)]
        public static extern IntPtr LoadLibraryW([Const] IntPtr lpLibFileName);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadLibraryW(string lpLibFileName);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr LoadLibraryExA([Const] IntPtr lpLibFileName, IntPtr hFile, uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr LoadLibraryExA(string lpLibFileName, IntPtr hFile, uint dwFlags);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr LoadLibraryExW([Const] IntPtr lpLibFileName, IntPtr hFile, uint dwFlags);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr LoadLibraryExW(string lpLibFileName, IntPtr hFile, uint dwFlags);
    }

    #endregion // Dynamic link library functions

    #region Asynchronous functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetOverlappedResult(IntPtr hFile, IntPtr lpOverlapped, IntPtr lpNumberOfBytesTransferred, int bWait);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetOverlappedResult(IntPtr hFile, ref OVERLAPPED lpOverlapped, ref uint lpNumberOfBytesTransferred, int bWait);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueueUserAPC(IntPtr pfnAPC, IntPtr hThread, uint dwData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueueUserAPC(APCProc pfnAPC, IntPtr hThread, uint dwData);
    }

    #endregion // Asynchronous functions

    #region Critical section functions

    partial class kernel32
    {
        [DllImport(ModuleName)]
        public static extern void DeleteCriticalSection(IntPtr lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void DeleteCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        [DllImport(ModuleName)]
        public static extern void EnterCriticalSection(IntPtr lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void EnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        [DllImport(ModuleName)]
        public static extern void InitializeCriticalSection(IntPtr lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void InitializeCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void InitializeCriticalSectionAndSpinCount(IntPtr lpCriticalSection, uint dwSpinCount);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void InitializeCriticalSectionAndSpinCount(ref RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);

        [DllImport(ModuleName)]
        public static extern void LeaveCriticalSection(IntPtr lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void LeaveCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void SetCriticalSectionAndSpinCount(IntPtr lpCriticalSection, uint dwSpinCount);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void SetCriticalSectionAndSpinCount(ref RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);

        [DllImport(ModuleName)]
        public static extern int TryEnterCriticalSection(IntPtr lpCriticalSection);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int TryEnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);
    }

    #endregion // Critical section functions

    #region Event functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEventA(IntPtr lpEventAttributes, int bManualReset, int bInitialState, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateEventA(ref SECURITY_ATTRIBUTES lpEventAttributes, int bManualReset, int bInitialState, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateEventW(IntPtr lpEventAttributes, int bManualReset, int bInitialState, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateEventW(ref SECURITY_ATTRIBUTES lpEventAttributes, int bManualReset, int bInitialState, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenEventA(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr OpenEventA(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenEventW(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr OpenEventW(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int PulseEvent(IntPtr hEvent);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ResetEvent(IntPtr hEvent);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetEvent(IntPtr hEvent);
    }

    #endregion // Event functions

    #region Interlocked functions

    partial class kernel32
    {
        [DllImport(ModuleName)]
        public static extern int InterlockedCompareExchange(IntPtr Destination, int Exchange, int Comperand);

        [DllImport(ModuleName)]
        public static extern int InterlockedCompareExchange(ref int Destination, int Exchange, int Comperand);

        [DllImport(ModuleName)]
        public static extern IntPtr InterlockedCompareExchangePointer(IntPtr Destination, IntPtr Exchange, IntPtr Comperand);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr InterlockedCompareExchangePointer(ref IntPtr Destination, IntPtr Exchange, IntPtr Comperand);

        [DllImport(ModuleName)]
        public static extern int InterlockedDecrement(IntPtr lpAppend);

        [DllImport(ModuleName)]
        public static extern int InterlockedDecrement(ref int lpAppend);

        [DllImport(ModuleName)]
        public static extern int InterlockedExchange(IntPtr Target, int Value);

        [DllImport(ModuleName)]
        public static extern int InterlockedExchange(ref int Target, int Value);

        [DllImport(ModuleName)]
        public static extern int InterlockedExchangeAdd(IntPtr Addend, int Value);

        [DllImport(ModuleName)]
        public static extern int InterlockedExchangeAdd(ref int Addend, int Value);

        [DllImport(ModuleName)]
        public static extern IntPtr InterlockedExchangePointer(IntPtr Destination, IntPtr Value);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr InterlockedExchangePointer(ref IntPtr Destination, IntPtr Value);

        [DllImport(ModuleName)]
        public static extern int InterlockedIncrement(IntPtr lpAppend);

        [DllImport(ModuleName)]
        public static extern int InterlockedIncrement(ref int lpAppend);
    }

    #endregion // Interlocked functions

    #region Mutex functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateMutexA(IntPtr lpMutexAttributes, int bInitialOwner, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateMutexA(ref SECURITY_ATTRIBUTES lpMutexAttributes, int bInitialOwner, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateMutexW(IntPtr lpMutexAttributes, int bInitialOwner, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateMutexW(ref SECURITY_ATTRIBUTES lpMutexAttributes, int bInitialOwner, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenMutexA(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr OpenMutexA(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenMutexW(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr OpenMutexW(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ReleaseMutex(IntPtr hMutex);
    }

    #endregion // Mutex functions

    #region Semaphore functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateSemaphoreA(IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateSemaphoreA(ref SECURITY_ATTRIBUTES lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateSemaphoreW(IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateSemaphoreW(ref SECURITY_ATTRIBUTES lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenSemaphoreA(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr OpenSemaphoreA(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenSemaphoreW(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr OpenSemaphoreW(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ReleaseSemaphore(IntPtr hSemaphore, int lReleaseCount, IntPtr lpPreviousCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ReleaseSemaphore(IntPtr hSemaphore, int lReleaseCount, ref int lpPreviousCount);
    }

    #endregion // Semaphore functions

    #region Timer-Queue timer functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ChangeTimerQueueTimer(IntPtr TimerQueue, IntPtr Timer, uint DueTime, uint Period);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateTimerQueue();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateTimerQueueTimer(IntPtr phNewTimer, IntPtr TimerQueue, IntPtr Callback, IntPtr Parameter, uint DueTime, uint Period, uint Flags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateTimerQueueTimer(ref IntPtr phNewTimer, IntPtr TimerQueue, WaitOrTimerCallback Callback, IntPtr Parameter, uint DueTime, uint Period, uint Flags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteTimerQueue(IntPtr TimerQueue);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteTimerQueue(IntPtr TimerQueue, IntPtr CompletionEvent);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteTimerQueueTimer(IntPtr TimerQueue, IntPtr Timer, IntPtr CompletionEvent);
    }

    #endregion // Timer-Queue timer functions

    #region Wait functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint MsgWaitForMultipleObjects(uint nCount, [Const] IntPtr pHandles, int bWaitAll, uint dwMilliseconds, uint dwWakeMask);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint MsgWaitForMultipleObjects(uint nCount, IntPtr[] pHandles, int bWaitAll, uint dwMilliseconds, uint dwWakeMask);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, [Const] IntPtr pHandles, uint dwMilliseconds, uint dwWakeMask, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, IntPtr[] pHandles, uint dwMilliseconds, uint dwWakeMask, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RegisterWaitForSingleObject(IntPtr phNewWaitObject, IntPtr hObject, IntPtr Callback, IntPtr Context, uint dwMilliseconds, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int RegisterWaitForSingleObject(ref IntPtr phNewWaitObject, IntPtr hObject, WaitOrTimerCallback Callback, IntPtr Context, uint dwMilliseconds, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SignalObjectAndWait(IntPtr hObjectToSignal, IntPtr hObjectToWaitOn, uint dwMilliseconds, int bAlertable);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UnregisterWait(IntPtr WaitHandle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int UnregisterWaitEx(IntPtr WaitHandle, IntPtr CompletionEvent);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WaitForMultipleObjects(uint nCount, [Const] IntPtr lpHandles, int bWaitAll, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WaitForMultipleObjects(uint nCount, IntPtr[] lpHandles, int bWaitAll, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WaitForMultipleObjectsEx(uint nCount, [Const] IntPtr lpHandles, int bWaitAll, uint dwMilliseconds, int bAlertable);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WaitForMultipleObjectsEx(uint nCount, IntPtr[] lpHandles, int bWaitAll, uint dwMilliseconds, int bAlertable);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitForSingleObjectEx(IntPtr hHandle, uint dwMilliseconds, int bAlertable);
    }

    #endregion // Wait functions

    #region Waitable timer functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CancelWaitableTimer(IntPtr hTimer);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateWaitableTimerA(IntPtr lpTimerAttributes, int bManualReset, [Const] IntPtr lpTimerName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateWaitableTimerA(ref SECURITY_ATTRIBUTES lpTimerAttributes, int bManualReset, string lpTimerName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CreateWaitableTimerW(IntPtr lpTimerAttributes, int bManualReset, [Const] IntPtr lpTimerName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateWaitableTimerW(ref SECURITY_ATTRIBUTES lpTimerAttributes, int bManualReset, string lpTimerName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenWaitableTimerA(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpTimerName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr OpenWaitableTimerA(uint dwDesiredAccess, int bInheritHandle, string lpTimerName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenWaitableTimerW(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpTimerName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr OpenWaitableTimerW(uint dwDesiredAccess, int bInheritHandle, string lpTimerName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetWaitableTimer(IntPtr hTimer, [Const] IntPtr pDueTime, int lPeriod, IntPtr pfnCompletionRoutine, IntPtr lpArgToCompletionRoutine, int fResume);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetWaitableTimer(IntPtr hTimer, ref LARGE_INTEGER pDueTime, int lPeriod, TimerAPCProc pfnCompletionRoutine, IntPtr lpArgToCompletionRoutine, int fResume);
    }

    #endregion // Waitable timer functions

    #region File I/O functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'ReadFile' function instead.", false)]
        public static extern int _hread(IntPtr hFile, IntPtr lpBuffer, int lBytes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'WriteFile' function instead.", false)]
        public static extern int _hwrite(IntPtr hFile, [Const] IntPtr lpBuffer, int lBytes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'WriteFile' function instead.", false)]
        public static extern int _hwrite(IntPtr hFile, string lpBuffer, int lBytes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CloseHandle' function instead.", false)]
        public static extern IntPtr _lclose(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr _lcreat([Const] IntPtr lpPathName, int iAttribute);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr _lcreat(string lpPathName, int iAttribute);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'SetFilePointer' function instead.", false)]
        public static extern int _llseek(IntPtr hFile, int lOffset, int iOrigin);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr _lopen([Const] IntPtr lpPathName, int iReadWrite);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr _lopen(string lpPathName, int iReadWrite);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'ReadFile' function instead.", false)]
        public static extern int _lread(IntPtr hFile, IntPtr lpBuffer, uint uBytes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'WriteFile' function instead.", false)]
        public static extern int _lwrite(IntPtr hFile, [Const] IntPtr lpBuffer, uint uBytes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'WriteFile' function instead.", false)]
        public static extern int _lwrite(IntPtr hFile, string lpBuffer, uint uBytes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int AreFileApisANSI();

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CancelIo(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CopyFileA([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, int bFailIfExists);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int CopyFileA(string lpExistingFileName, string lpNewFileName, int bFailIfExists);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CopyFileW([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, int bFailIfExists);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int CopyFileW(string lpExistingFileName, string lpNewFileName, int bFailIfExists);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CopyFileExA([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, IntPtr lpProgressRoutine, IntPtr lpData, IntPtr pbCancel, uint dwCopyFlags);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CopyFileExA(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref int pbCancel, uint dwCopyFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CopyFileExW([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, IntPtr lpProgressRoutine, IntPtr lpData, IntPtr pbCancel, uint dwCopyFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CopyFileExW(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref int pbCancel, uint dwCopyFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateDirectoryA([Const] IntPtr lpPathName, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateDirectoryA(string lpPathName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateDirectoryW([Const] IntPtr lpPathName, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateDirectoryW(string lpPathName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateDirectoryExA([Const] IntPtr lpTemplateDirectory, [Const] IntPtr lpNewDirectory, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateDirectoryExA(string lpTemplateDirectory, string lpNewDirectory, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateDirectoryExW([Const] IntPtr lpTemplateDirectory, [Const] IntPtr lpNewDirectory, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateDirectoryExW(string lpTemplateDirectory, string lpNewDirectory, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFileA([Const] IntPtr lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateFileA(string lpFileName, uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFileW([Const] IntPtr lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateIoCompletionPort(IntPtr FileHandle, IntPtr ExistingCompletionPort, uint CompletionKey, uint NumberOfConcurrentThreads);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DefineDosDeviceA(uint dwFlags, [Const] IntPtr lpDeviceName, [Const] IntPtr lpTargetPath);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DefineDosDeviceA(uint dwFlags, string lpDeviceName, string lpTargetPath);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DefineDosDeviceW(uint dwFlags, [Const] IntPtr lpDeviceName, [Const] IntPtr lpTargetPath);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DefineDosDeviceW(uint dwFlags, string lpDeviceName, string lpTargetPath);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteFileA([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int DeleteFileA(string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteFileW([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DeleteFileW(string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindClose(IntPtr hFindFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindCloseChangeNotification(IntPtr hChangeHandle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstChangeNotificationA([Const] IntPtr lpPathName, int bWatchSubtree, uint dwNotifyFilter);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr FindFirstChangeNotificationA(string lpPathName, int bWatchSubtree, uint dwNotifyFilter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstChangeNotificationW([Const] IntPtr lpPathName, int bWatchSubtree, uint dwNotifyFilter);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr FindFirstChangeNotificationW(string lpPathName, int bWatchSubtree, uint dwNotifyFilter);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr FindFirstFileA([Const] IntPtr lpFileName, IntPtr lpFindFileData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileA(string lpFileName, ref WIN32_FIND_DATA lpFindFileData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr FindFirstFileW([Const] IntPtr lpFileName, IntPtr lpFindFileData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileW(string lpFileName, ref WIN32_FIND_DATA lpFindFileData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileExA([Const] IntPtr lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlag);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileExA(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlag);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileExW([Const] IntPtr lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlag);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr FindFirstFileExW(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlag);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindNextChangeNotification(IntPtr hChangeHandle);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindNextFileA(IntPtr hFindFile, IntPtr lpFindFileData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int FindNextFileA(IntPtr hFindFile, ref WIN32_FIND_DATA lpFindFileData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindNextFileW(IntPtr hFindFile, IntPtr lpFindFileData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FindNextFileW(IntPtr hFindFile, ref WIN32_FIND_DATA lpFindFileData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FlushFileBuffers(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetBinaryTypeA([Const] IntPtr lpApplicationName, IntPtr lpBinaryType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetBinaryTypeA(string lpApplicationName, ref uint lpBinaryType);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetBinaryTypeW([Const] IntPtr lpApplicationName, IntPtr lpBinaryType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetBinaryTypeW(string lpApplicationName, ref uint lpBinaryType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCurrentDirectoryA(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetCurrentDirectoryA(uint nBufferLength, StringBuilder lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCurrentDirectoryW(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetCurrentDirectoryW(uint nBufferLength, StringBuilder lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDriveTypeA([Const] IntPtr lpRootPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetDriveTypeA(string lpRootPathName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetDriveTypeW([Const] IntPtr lpRootPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetDriveTypeW(string lpRootPathName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileAttributesA([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetFileAttributesA(string lpFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileAttributesW([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetFileAttributesW(string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetFileAttributesExA([Const] IntPtr lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int GetFileAttributesExA(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetFileAttributesExW([Const] IntPtr lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetFileAttributesExW(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetFileInformationByHandle(IntPtr hFile, IntPtr lpFileInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetFileInformationByHandle(IntPtr hFile, ref BY_HANDLE_FILE_INFORMATION lpFileInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileType(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFullPathNameA([Const] IntPtr lpFileName, uint nBufferLength, IntPtr lpBuffer, IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFullPathNameA([Const] IntPtr lpFileName, uint nBufferLength, IntPtr lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetFullPathNameA(string lpFileName, uint nBufferLength, StringBuilder lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFullPathNameW([Const] IntPtr lpFileName, uint nBufferLength, IntPtr lpBuffer, IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFullPathNameW([Const] IntPtr lpFileName, uint nBufferLength, IntPtr lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetFullPathNameW(string lpFileName, uint nBufferLength, StringBuilder lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLongPathNameA([Const] IntPtr lpszShortPath, IntPtr lpszLongPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetLongPathNameA(string lpszShortPath, StringBuilder lpszLongPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLongPathNameW([Const] IntPtr lpszShortPath, IntPtr lpszLongPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetLongPathNameW(string lpszShortPath, StringBuilder lpszLongPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetQueuedCompletionStatus(IntPtr CompletionPort, IntPtr lpNumberOfBytes, IntPtr lpCompletionKey, IntPtr lpOverlapped, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetQueuedCompletionStatus(IntPtr CompletionPort, ref uint lpNumberOfBytes, ref uint lpCompletionKey, ref OVERLAPPED lpOverlapped, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetShortPathNameA([Const] IntPtr lpszLongPath, IntPtr lpszShortPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetShortPathNameA(string lpszLongPath, StringBuilder lpszShortPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetShortPathNameW([Const] IntPtr lpszLongPath, IntPtr lpszShortPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetShortPathNameW(string lpszLongPath, StringBuilder lpszShortPath, uint cchBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTempFileNameA([Const] IntPtr lpPathName, [Const] IntPtr lpPrefixString, uint uUnique, IntPtr lpTempFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetTempFileNameA(string lpPathName, string lpPrefixString, uint uUnique, StringBuilder lpTempFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTempFileNameW([Const] IntPtr lpPathName, [Const] IntPtr lpPrefixString, uint uUnique, IntPtr lpTempFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetTempFileNameW(string lpPathName, string lpPrefixString, uint uUnique, StringBuilder lpTempFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTempPathA(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetTempPathA(uint nBufferLength, StringBuilder lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTempPathW(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetTempPathW(uint nBufferLength, StringBuilder lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LockFile(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LockFileEx(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LockFileEx(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MoveFileA([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int MoveFileA(string lpExistingFileName, string lpNewFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int MoveFileW([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int MoveFileW(string lpExistingFileName, string lpNewFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MoveFileExA([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int MoveFileExA(string lpExistingFileName, string lpNewFileName, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MoveFileExW([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int MoveFileExW(string lpExistingFileName, string lpNewFileName, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MoveFileWithProgressA([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, IntPtr lpProgressRoutine, IntPtr lpData, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int MoveFileWithProgressA(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MoveFileWithProgressW([Const] IntPtr lpExistingFileName, [Const] IntPtr lpNewFileName, IntPtr lpProgressRoutine, IntPtr lpData, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int MoveFileWithProgressW(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr OpenFile([Const] IntPtr lpFileName, IntPtr lpReOpenBuff, uint uStyle);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        [Obsolete("This function is provided only for compatibility with 16-bit versions of Windows. Use 'CreateFile' function instead.", false)]
        public static extern IntPtr OpenFile(string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PostQueuedCompletionStatus(IntPtr CompletionPort, uint dwNumberOfBytesTransferred, uint dwCompletionKey, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PostQueuedCompletionStatus(IntPtr CompletionPort, uint dwNumberOfBytesTransferred, uint dwCompletionKey, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryDosDeviceA([Const] IntPtr lpDeviceName, IntPtr lpTargetPath, uint ucchMax);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint QueryDosDeviceA(string lpDeviceName, StringBuilder lpTargetPath, uint ucchMax);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryDosDeviceW([Const] IntPtr lpDeviceName, IntPtr lpTargetPath, uint ucchMax);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint QueryDosDeviceW(string lpDeviceName, StringBuilder lpTargetPath, uint ucchMax);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadDirectoryChangeW(IntPtr hDirectory, IntPtr lpBuffer, uint nBufferLength, int bWatchSubtree, uint dwNotifyFilter, IntPtr lpBytesReturned, IntPtr lpOverlapped, IntPtr lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadDirectoryChangeW(IntPtr hDirectory, IntPtr lpBuffer, uint nBufferLength, int bWatchSubtree, uint dwNotifyFilter, ref uint lpBytesReturned, ref OVERLAPPED lpOverlapped, FileIOCompletionRoutine lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFile(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFile(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref uint lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFileEx(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, IntPtr lpOverlapped, IntPtr lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFileEx(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref OVERLAPPED lpOverlapped, FileIOCompletionRoutine lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFileScatter(IntPtr hFile, FILE_SEGMENT_ELEMENT[] aSegmentArray, uint nNumberOfBytesToRead, IntPtr lpReserved, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReadFileScatter(IntPtr hFile, FILE_SEGMENT_ELEMENT[] aSegmentArray, uint nNumberOfBytesToRead, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RemoveDirectoryA([Const] IntPtr lpPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int RemoveDirectoryA(string lpPathName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int RemoveDirectoryW([Const] IntPtr lpPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RemoveDirectoryW(string lpPathName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReplaceFileA([Const] IntPtr lpReplacedFileName, [Const] IntPtr lpReplacementFileName, [Const] IntPtr lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int ReplaceFileA(string lpReplacedFileName, string lpReplacementFileName, string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ReplaceFileW([Const] IntPtr lpReplacedFileName, [Const] IntPtr lpReplacementFileName, [Const] IntPtr lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int ReplaceFileW(string lpReplacedFileName, string lpReplacementFileName, string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SearchPathA([Const] IntPtr lpPath, [Const] IntPtr lpFileName, [Const] IntPtr lpExtension, uint nBufferLength, IntPtr lpBuffer, IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SearchPathA([Const] IntPtr lpPath, [Const] IntPtr lpFileName, [Const] IntPtr lpExtension, uint nBufferLength, IntPtr lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint SearchPathA(string lpPath, string lpFileName, string lpExtension, uint nBufferLength, StringBuilder lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SearchPathW([Const] IntPtr lpPath, [Const] IntPtr lpFileName, [Const] IntPtr lpExtension, uint nBufferLength, IntPtr lpBuffer, IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SearchPathW([Const] IntPtr lpPath, [Const] IntPtr lpFileName, [Const] IntPtr lpExtension, uint nBufferLength, IntPtr lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint SearchPathW(string lpPath, string lpFileName, string lpExtension, uint nBufferLength, StringBuilder lpBuffer, ref IntPtr lpFilePart);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetCurrentDirectoryA([Const] IntPtr lpPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetCurrentDirectoryA(string lpPathName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetCurrentDirectoryW([Const] IntPtr lpPathName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetCurrentDirectoryW(string lpPathName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetEndOfFile(IntPtr hFile);

        [DllImport(ModuleName)]
        public static extern void SetFileApisToANSI();

        [DllImport(ModuleName)]
        public static extern void SetFileApisToOEM();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFileAttributesA([Const] IntPtr lpFileName, uint dwFileAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int SetFileAttributesA(string lpFileName, uint dwFileAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFileAttributesW([Const] IntPtr lpFileName, uint dwFileAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int SetFileAttributesW(string lpFileName, uint dwFileAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetFilePointer(IntPtr hFile, int lDistanceToMove, IntPtr lpDistanceToMoveHigh, uint dwMoveMethod);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetFilePointer(IntPtr hFile, int lDistanceToMove, ref int lpDistanceToMoveHigh, uint dwMoveMethod);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFilePointerEx(IntPtr hFile, LARGE_INTEGER liDistanceToMove, IntPtr lpNewFilePointer, uint dwMoveMethod);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFilePointerEx(IntPtr hFile, LARGE_INTEGER liDistanceToMove, ref LARGE_INTEGER lpNewFilePointer, uint dwMoveMethod);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFileSecurityA([Const] IntPtr lpFileName, SECURITY_INFORMATION SecurityInformation, IntPtr pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int SetFileSecurityA(string lpFileName, SECURITY_INFORMATION SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFileSecurityW([Const] IntPtr lpFileName, SECURITY_INFORMATION SecurityInformation, IntPtr pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int SetFileSecurityW(string lpFileName, SECURITY_INFORMATION SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetFileShortNameA(IntPtr hFile, [Const] IntPtr lpShortName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetFileShortNameA(IntPtr hFile, string lpShortName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetFileShortNameW(IntPtr hFile, [Const] IntPtr lpShortName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetFileShortNameW(IntPtr hFile, string lpShortName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetFileValidData(IntPtr hFile, long ValidDataLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int UnlockFile(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int UnlockFileEx(IntPtr hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int UnlockFileEx(IntPtr hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFile(IntPtr hFile, [Const] IntPtr lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFile(IntPtr hFile, [Const] IntPtr lpBuffer, uint nNumberOfBytesToWrite, ref uint lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFileEx(IntPtr hFile, [Const] IntPtr lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpOverlapped, IntPtr lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFileEx(IntPtr hFile, [Const] IntPtr lpBuffer, uint nNumberOfBytesToWrite, ref OVERLAPPED lpOverlapped, FileIOCompletionRoutine lpCompletionRoutine);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFileGather(IntPtr hFile, FILE_SEGMENT_ELEMENT[] aSegmentArray, uint nNumberOfBytesToWrite, IntPtr lpReserved, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WriteFileGather(IntPtr hFile, FILE_SEGMENT_ELEMENT[] aSegmentArray, uint nNumberOfBytesToWrite, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);
    }

    #endregion // File I/O functions

    #region File mapping functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFileMappingA(IntPtr hFile, IntPtr lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateFileMappingA(IntPtr hFile, ref SECURITY_ATTRIBUTES lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFileMappingW(IntPtr hFile, IntPtr lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateFileMappingW(IntPtr hFile, ref SECURITY_ATTRIBUTES lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FlushViewOfFile([Const] IntPtr lpBaseAddress, uint dwNumberOfBytesToFlush);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr MapViewOfFileEx(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap, IntPtr lpBaseAddress);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenFileMappingA(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr OpenFileMappingA(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenFileMappingW(uint dwDesiredAccess, int bInheritHandle, [Const] IntPtr lpName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr OpenFileMappingW(uint dwDesiredAccess, int bInheritHandle, string lpName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int UnmapViewOfFile([Const] IntPtr lpBaseAddress);
    }

    #endregion // File mapping functions

    #region File system functions (general)

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateHardLinkA([Const] IntPtr lpFileName, [Const] IntPtr lpExistingFileName, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateHardLinkA(string lpFileName, string lpExistingFileName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CreateHardLinkW([Const] IntPtr lpFileName, [Const] IntPtr lpExistingFileName, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateHardLinkW(string lpFileName, string lpExistingFileName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCompressedFileSizeA([Const] IntPtr lpFileName, IntPtr lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetCompressedFileSizeA(string lpFileName, ref uint lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetCompressedFileSizeW([Const] IntPtr lpFileName, IntPtr lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetCompressedFileSizeW(string lpFileName, ref uint lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDiskFreeSpaceA([Const] IntPtr lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters, IntPtr lpTotalNumberOfClusters);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetDiskFreeSpaceA(string lpRootPathName, ref uint lpSectorsPerCluster, ref uint lpBytesPerSector, ref uint lpNumberOfFreeClusters, ref uint lpTotalNumberOfClusters);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDiskFreeSpaceW([Const] IntPtr lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters, IntPtr lpTotalNumberOfClusters);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetDiskFreeSpaceW(string lpRootPathName, ref uint lpSectorsPerCluster, ref uint lpBytesPerSector, ref uint lpNumberOfFreeClusters, ref uint lpTotalNumberOfClusters);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDiskFreeSpaceExA([Const] IntPtr lpDirectoryName, IntPtr lpFreeBytesAvailable, IntPtr lpTotalNumberOfBytes, IntPtr lpTotalNumberOfFreeBytes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetDiskFreeSpaceExA(string lpDirectoryName, ref ULARGE_INTEGER lpFreeBytesAvailable, ref ULARGE_INTEGER lpTotalNumberOfBytes, ref ULARGE_INTEGER lpTotalNumberOfFreeBytes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDiskFreeSpaceExW([Const] IntPtr lpDirectoryName, IntPtr lpFreeBytesAvailable, IntPtr lpTotalNumberOfBytes, IntPtr lpTotalNumberOfFreeBytes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetDiskFreeSpaceExW(string lpDirectoryName, ref ULARGE_INTEGER lpFreeBytesAvailable, ref ULARGE_INTEGER lpTotalNumberOfBytes, ref ULARGE_INTEGER lpTotalNumberOfFreeBytes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileSize(IntPtr hFile, IntPtr lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileSize(IntPtr hFile, ref uint lpFileSizeHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileSizeEx(IntPtr hFile, IntPtr lpFileSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetFileSizeEx(IntPtr hFile, ref LARGE_INTEGER lpFileSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLogicalDrives();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLogicalDriveStringsA(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetLogicalDriveStringsW(uint nBufferLength, IntPtr lpBuffer);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumeInformationA([Const] IntPtr lpRootPathName, IntPtr lpVolumeNameBuffer, uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags, IntPtr lpFileSystemNameBuffer, uint nFileSystemNameSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetVolumeInformationA(string lpRootPathName, StringBuilder lpVolumeNameBuffer, uint nVolumeNameSize, ref uint lpVolumeSerialNumber, ref uint lpMaximumComponentLength, ref uint lpFileSystemFlags, StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumeInformationW([Const] IntPtr lpRootPathName, IntPtr lpVolumeNameBuffer, uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags, IntPtr lpFileSystemNameBuffer, uint nFileSystemNameSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetVolumeInformationW(string lpRootPathName, StringBuilder lpVolumeNameBuffer, uint nVolumeNameSize, ref uint lpVolumeSerialNumber, ref uint lpMaximumComponentLength, ref uint lpFileSystemFlags, StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetVolumeLabelA([Const] IntPtr lpRootPathName, [Const] IntPtr lpVolumeName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetVolumeLabelA(string lpRootPathName, string lpVolumeName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetVolumeLabelW([Const] IntPtr lpRootPathName, [Const] IntPtr lpVolumeName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetVolumeLabelW(string lpRootPathName, string lpVolumeName);
    }

    #endregion // File system functions (general)

    #region File system functions (mount points)

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteVolumeMountPointA([Const] IntPtr lpszVolumeMountPoint);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int DeleteVolumeMountPointA(string lpszVolumeMountPoint);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DeleteVolumeMountPointW([Const] IntPtr lpszVolumeMountPoint);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int DeleteVolumeMountPointW(string lpszVolumeMountPoint);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeA(IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeA(StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeW(IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeW(StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeMountPointA(IntPtr lpszRootPathName, IntPtr lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeMountPointA(string lpszRootPathName, StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeMountPointW(IntPtr lpszRootPathName, IntPtr lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr FindFirstVolumeMountPointW(string lpszRootPathName, StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FindNextVolumeA(IntPtr hFindVolume, IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int FindNextVolumeA(IntPtr hFindVolume, StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FindNextVolumeW(IntPtr hFindVolume, IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FindNextVolumeW(IntPtr hFindVolume, StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FindNextVolumeMountPointA(IntPtr hFindVolumeMountPoint, IntPtr lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int FindNextVolumeMountPointA(IntPtr hFindVolumeMountPoint, StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FindNextVolumeMountPointW(IntPtr hFindVolumeMountPoint, IntPtr lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FindNextVolumeMountPointW(IntPtr hFindVolumeMountPoint, StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindVolumeClose(IntPtr hFindVolume);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FindVolumeMountPointClose(IntPtr hFindVolume);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumeNameForVolumeMountPointA([Const] IntPtr lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetVolumeNameForVolumeMountPointA(string lpszVolumeMountPoint, StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumeNameForVolumeMountPointW([Const] IntPtr lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetVolumeNameForVolumeMountPointW(string lpszVolumeMountPoint, StringBuilder lpszVolumeName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumePathNameA([Const] IntPtr lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetVolumePathNameA(string lpszFileName, StringBuilder lpszVolumePathName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumePathNameW([Const] IntPtr lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetVolumePathNameW(string lpszFileName, StringBuilder lpszVolumePathName, uint cchBufferLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumePathNamesForVolumeNameA([Const] IntPtr lpszVolumeName, IntPtr lpszVolumePathNames, uint cchBufferLength, IntPtr lpcchReturnLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetVolumePathNamesForVolumeNameA(string lpszVolumeName, StringBuilder lpszVolumePathNames, uint cchBufferLength, ref uint lpcchReturnLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetVolumePathNamesForVolumeNameW([Const] IntPtr lpszVolumeName, IntPtr lpszVolumePathNames, uint cchBufferLength, IntPtr lpcchReturnLength);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetVolumePathNamesForVolumeNameW(string lpszVolumeName, StringBuilder lpszVolumePathNames, uint cchBufferLength, ref uint lpcchReturnLength);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetVolumeMountPointA([Const] IntPtr lpszVolumeMountPoint, [Const] IntPtr lpszVolumeName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetVolumeMountPointA(string lpszVolumeMountPoint, string lpszVolumeName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetVolumeMountPointW([Const] IntPtr lpszVolumeMountPoint, [Const] IntPtr lpszVolumeName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetVolumeMountPointW(string lpszVolumeMountPoint, string lpszVolumeName);
    }

    #endregion // File system functions (mount points)

    #region Tape backup functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupRead(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, int bAbort, int bProcessSecurity, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupRead(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref uint lpNumberOfBytesRead, int bAbort, int bProcessSecurity, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupSeek(IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, IntPtr lpdwLowBytesSeeked, IntPtr lpdwHighBytesSeeked, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupSeek(IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, ref uint lpdwLowBytesSeeked, ref uint lpdwHighBytesSeeked, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupWrite(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, int bAbort, int bProcessSecurity, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int BackupWrite(IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToWrite, ref uint lpNumberOfBytesWritten, int bAbort, int bProcessSecurity, IntPtr lpContext);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint CreateTapePartition(IntPtr hDevice, uint dwPartitionMethod, uint dwCount, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint EraseType(IntPtr hDevice, uint dwEraseType, int bImmediate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTapeParameters(IntPtr hDevice, uint dwOperation, IntPtr lpdwSize, IntPtr lpTapeInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTapeParameters(IntPtr hDevice, uint dwOperation, ref uint lpdwSize, IntPtr lpTapeInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTapePosition(IntPtr hDevice, uint dwPositionType, IntPtr lpdwPartition, IntPtr lpdwOffsetLow, IntPtr lpdwOffsetHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTapePosition(IntPtr hDevice, uint dwPositionType, ref uint lpdwPartition, ref uint lpdwOffsetLow, ref uint lpdwOffsetHigh);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTapeStatus(IntPtr hDevice);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint PrepareTape(IntPtr hDevice, uint dwOperation, int bImmediate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTapeParameters(IntPtr hDevice, uint dwOperation, IntPtr lpTapeInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetTapePosition(IntPtr hDevice, uint dwPositionMethod, uint dwPartition, uint dwOffsetLow, uint dwOffsetHigh, int bImmediate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WriteTapemark(IntPtr hDevice, uint dwTapemarkType, uint dwTapemarkCount, int bImmediate);
    }

    #endregion // Tape backup functions

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

        #region advapi32.dll - File system functions (cryptions)

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct EFS_CERTIFICATE_BLOB
        {
            public uint dwCertEncodingType;
            public uint cbData;
            public IntPtr pbData;
        }

        [Serializable, StructLayout(LayoutKind.Sequential)]
        public struct SID_IDENTIFIER_AUTHORITY
        {
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeConst = 6)]
            public byte[] Value;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct SID
        {
            public byte Revision;
            public byte SubAuthorityCount;
            public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

            [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)]
            public uint[] SubAuthority;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct ENCRYPTION_CERTIFICATE
        {
            public uint cbTotalLength;
            public IntPtr pUserSid;
            public IntPtr pCertBlob;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct ENCRYPTION_CERTIFICATE_LIST
        {
            public uint nUsers;
            public IntPtr pUsers;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct EFS_HASH_BLOB
        {
            public uint cbData;
            public IntPtr pbData;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct ENCRYPTION_CERTIFICATE_HASH
        {
            public uint cbTotalLength;
            public IntPtr pUserSid;
            public IntPtr pHash;
            public IntPtr lpDisplayInformation;
        }

        [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
        public struct ENCRYPTION_CERTIFICATE_HASH_LIST
        {
            public uint nCert_Hash;
            public IntPtr pUsers;
        }

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint AddUsersToEncryptedFile([Const] IntPtr lpFileName, IntPtr pUsers);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint AddUsersToEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_LIST pUsers);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DecryptFileA([Const] IntPtr lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int DecryptFileA(string lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DecryptFileW([Const] IntPtr lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int DecryptFileW(string lpFileName, uint dwReserved);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint DuplicateEncryptionInfoFile([Const] IntPtr SrcFileName, [Const] IntPtr DstFileName, uint dwCreationDistribution, uint dwAttributes, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint DuplicateEncryptionInfoFile(string SrcFileName, string DstFileName, uint dwCreationDistribution, uint dwAttributes, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EncryptFileA([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EncryptFileA(string lpFileName);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EncryptFileW([Const] IntPtr lpFileName);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EncryptFileW(string lpFileName);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int EncryptionDisable([Const] IntPtr DirPath, int Disable);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int EncryptionDisable(string DirPath, int Disable);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FileEncryptionStatus([Const] IntPtr lpFileName, IntPtr lpStatus);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FileEncryptionStatus(string lpFileName, ref uint lpStatus);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void FreeEncryptionCertificateHashList(IntPtr pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void FreeEncryptionCertificateHashList(ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryRecoveryAgentsOnEcryptedFile([Const] IntPtr lpFileName, IntPtr pRecoveryAgents);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint QueryRecoveryAgentsOnEcryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pRecoveryAgents);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint QueryUsersOnEncryptedFile([Const] IntPtr lpFileName, IntPtr pHasehs);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint QueryUsersOnEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint RemoveUsersFromEncryptedFile([Const] IntPtr lpFileName, IntPtr pHasehs);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint RemoveUsersFromEncryptedFile(string lpFileName, ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetUserFileEncryptionKey(IntPtr pEncryptionCertificate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SetUserFileEncryptionKey(ref ENCRYPTION_CERTIFICATE pEncryptionCertificate);

        #endregion // advapi32.dll - File system functions (cryptions)
    }
}
