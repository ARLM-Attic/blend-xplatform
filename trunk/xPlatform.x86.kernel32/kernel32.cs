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

        // GetModuleFileName
    }

    #endregion // Dynamic link library functions

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
