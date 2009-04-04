﻿using System;
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

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr FindFirstFileA(string lpFileName, ref WIN32_FIND_DATA lpFindFileData);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr FindFirstFileW([Const] IntPtr lpFileName, IntPtr lpFindFileData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
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
    }

    #endregion // File I/O functions

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
