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

    #region Handle and object functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CloseHandle(IntPtr hObject);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, IntPtr lpTargetHandle, uint dwDesiredAccess, int bInheritHandle, uint dwOptions);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, ref IntPtr lpTargetHandle, uint dwDesiredAccess, int bInheritHandle, uint dwOptions);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetHandleInformation(IntPtr hObject, IntPtr lpdwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetHandleInformation(IntPtr hObject, ref uint lpdwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetHandleInformation(IntPtr hObject, uint dwMask, uint dwFlags);
    }

    #endregion // Handle and object functions

    #region Large integer operation functions

    partial class kernel32
    {
        [DllImport(ModuleName)]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);
    }

    #endregion // Large integer operation functions

    #region Memory management functions

    partial class kernel32
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void CopyMemory(IntPtr Destination, [Const] IntPtr Source, uint Length);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void FillMemory(IntPtr Destination, uint Length, byte Fill);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GetProcessHeap();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetProcessHeaps(uint NumberOfHeaps, IntPtr ProcessHeaps);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetProcessHeaps(uint NumberOfHeaps, ref IntPtr ProcessHeaps);

        [DllImport(ModuleName)]
        public static extern void GlobalMemoryStatus(IntPtr lpBuffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, uint dwBytes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint HeapCompact(IntPtr hHeap, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr HeapCreate(uint flOptions, uint dwInitialSize, uint dwMaximumSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int HeapDestroy(IntPtr hHeap);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int HeapLock(IntPtr hHeap);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr HeapReAlloc(IntPtr hHeap, uint dwFlags, IntPtr lpMem, uint dwBytes);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint HeapSize(IntPtr hHeap, uint dwFlags, [Const] IntPtr lpMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int HeapUnlock(IntPtr hHeap);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int HeapValidate(IntPtr hHeap, uint dwFlags, [Const] IntPtr lpMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int HeapWalk(IntPtr hHeap, IntPtr lpEntry);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int HeapWalk(IntPtr hHeap, ref PROCESS_HEAP_ENTRY lpEntry);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int IsBadCodePtr(IntPtr lpfn);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int IsBadReadPtr([Const] IntPtr lp, uint ucb);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int IsBadStringPtrA([Const] IntPtr lpsz, uint ucchMax);

        [DllImport(ModuleName, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int IsBadStringPtrA(string lpsz, uint ucchMax);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int IsBadStringPtrW([Const] IntPtr lpsz, uint ucchMax);

        [DllImport(ModuleName, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int IsBadStringPtrW(string lpsz, uint ucchMax);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int IsBadWritePtr(IntPtr lp, uint ucb);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void MoveMemory(IntPtr Destination, [Const] IntPtr Source, uint Length);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualFree(IntPtr lpAddress, uint dwSize, uint dwFreeType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint dwFreeType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualLock(IntPtr lpAddress, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, IntPtr lpflOldProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, ref uint lpflOldProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, IntPtr lpflOldProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, ref uint lpflOldProtect);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint VirtualQuery([Const] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint VirtualQuery([Const] IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint VirtualQueryEx(IntPtr hProcess, [Const] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint VirtualQueryEx(IntPtr hProcess, [Const] IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int VirtualUnlock(IntPtr lpAddress, uint dwSize);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void ZeroMemory(IntPtr Destination, uint Length);
    }

    #endregion // Memory management functions

    #region Global and local functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GlobalAlloc(uint uFlags, uint dwBytes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GlobalDiscard(IntPtr hglbMem);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GlobalFlags(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GlobalFree(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GlobalHandle([Const] IntPtr pMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr GlobalReAlloc(IntPtr hMem, uint dwBytes, uint uFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GlobalSize(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GlobalUnlock(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr LocalAlloc(uint uFlags, uint dwBytes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LocalDiscard(IntPtr hlocMem);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint LocalFlags(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LocalFree(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LocalHandle([Const] IntPtr pMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr LocalLock(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr LocalReAlloc(IntPtr hMem, uint uBytes, uint uFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint LocalSize(IntPtr hMem);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LocalUnlock(IntPtr hMem);

        // Missing obsolete functions:
        // GlobalCompact, GlobalFix, GlobalUnfix, GlobalUnWire, GlobalWire, IsBadHugeReadPtr, IsBadHugeWritePtr, LocalCompact, LocalShrink
    }

    #endregion // Global and local functions

    #region String manipulation functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CompareStringA(LCID Locale, uint dwCmpFlags, [Const] IntPtr lpString1, int cchCount1, [Const] IntPtr lpString2, int cchCount2);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CompareStringA(LCID Locale, uint dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CompareStringW(LCID Locale, uint dwCmpFlags, [Const] IntPtr lpString1, int cchCount1, [Const] IntPtr lpString2, int cchCount2);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CompareStringW(LCID Locale, uint dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FoldStringA(uint dwMapFlags, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int FoldStringA(uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FoldStringW(uint dwMapFlags, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int FoldStringW(uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetStringTypeA(LCID Locale, uint dwInfoType, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpCharType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetStringTypeA(LCID Locale, uint dwInfoType, string lpSrcStr, int cchSrc, ref uint lpCharType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetStringTypeW(LCID Locale, uint dwInfoType, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpCharType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetStringTypeW(LCID Locale, uint dwInfoType, string lpSrcStr, int cchSrc, ref uint lpCharType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetStringTypeExA(LCID Locale, uint dwInfoType, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpCharType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetStringTypeExA(LCID Locale, uint dwInfoType, string lpSrcStr, int cchSrc, ref uint lpCharType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetStringTypeExW(LCID Locale, uint dwInfoType, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpCharType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetStringTypeExW(LCID Locale, uint dwInfoType, string lpSrcStr, int cchSrc, ref uint lpCharType);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcat(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcat(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcatA(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcatA(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcatW(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcatW(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmp([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmp(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpA([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpA(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpW([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpW(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpi([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpi(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpiA([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpiA(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpiW([Const] IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrcmpiW(string lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpy(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpy(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpyA(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpyA(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpyW(IntPtr lpString1, [Const] IntPtr lpString2);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpyW(StringBuilder lpString1, string lpString2);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpyn(IntPtr lpString1, [Const] IntPtr lpString2, int iMaxLength);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpyn(StringBuilder lpString1, string lpString2, int iMaxLength);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpynA(IntPtr lpString1, [Const] IntPtr lpString2, int iMaxLength);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpynA(StringBuilder lpString1, string lpString2, int iMaxLength);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr lstrcpynW(IntPtr lpString1, [Const] IntPtr lpString2, int iMaxLength);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern string lstrcpynW(StringBuilder lpString1, string lpString2, int iMaxLength);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlen([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlen(string lpString);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlenA([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlenA(string lpString);

        [DllImport(ModuleName, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlenW([Const] IntPtr lpString);

        [DllImport(ModuleName, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern int lstrlenW(string lpString);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, [Const] IntPtr lpMultiByteStr, int cchMultiByte, IntPtr lpWideCharStr, int cchWideChar);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, string lpMultiByteStr, int cchMultiByte, IntPtr lpWideCharStr, int cchWideChar);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WideCharToMultiByte(uint CodePage, uint dwFlags, [Const] IntPtr lpWideCharStr, int cchWideChar, IntPtr lpMultiByteStr, int cchMultiByte, [Const] IntPtr lpDefaultChar, IntPtr lpUsedDefaultChar);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WideCharToMultiByte(uint CodePage, uint dwFlags, string lpWideCharStr, int cchWideChar, IntPtr lpMultiByteStr, int cchMultiByte, [MarshalAs(UnmanagedType.LPStr)] string lpDefaultChar, ref int lpUsedDefaultChar);
    }

    #endregion // String manipulation functions

    #region Time functions

    partial class kernel32
    {
        [DllImport(ModuleName)]
        public static extern int CompareFileTime([Const] IntPtr lpFileTime1, [Const] IntPtr lpFileTime2);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int CompareFileTime(ref FILETIME lpFileTime1, ref FILETIME lpFileTime2);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DosDateTimeToFileTime(ushort wFatDate, ushort sFatTime, IntPtr lpFileTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DosDateTimeToFileTime(ushort wFatDate, ushort sFatTime, ref FILETIME lpFileTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FileTimeToDosDateTime([Const] IntPtr lpFileTime, IntPtr lpFatDate, IntPtr lpFatTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FileTimeToDosDateTime(ref FILETIME lpFileTime, ref ushort lpFatDate, ref ushort lpFatTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FileTimeToLocalFileTime([Const] IntPtr lpFileTime, IntPtr lpLocalFileTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FileTimeToLocalFileTime(ref FILETIME lpFileTime, ref FILETIME lpLocalFileTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FileTimeToSystemTime([Const] IntPtr lpFileTime, IntPtr lpSystemTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int FileTimeToSystemTime(ref FILETIME lpFileTime, ref SYSTEMTIME lpSystemTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetFileTime(IntPtr hFile, IntPtr lpCreationTime, IntPtr lpLastAccessTime, IntPtr lpLastWriteTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime, ref FILETIME lpLastWriteTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void GetSystemTime(IntPtr lpSystemTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetSystemTimeAdjustment(IntPtr lpTimeAdjustment, IntPtr lpTimeIncrement, IntPtr lpTimeAdjustmentDisabled);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetSystemTimeAdjustment(ref uint lpTimeAdjustment, ref uint lpTimeIncrement, ref int lpTimeAdjustmentDisabled);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void GetSystemTimeAsFileTime(IntPtr lpSystemTimeAsFileTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void GetSystemTimeAsFileTime(ref FILETIME lpSystemTimeAsFileTime);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetTickCount();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTimeZoneInformation(IntPtr lpTimeZoneInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int LocalFileTimeToFileTime([Const] IntPtr lpLocalFileTime, IntPtr lpFileTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LocalFileTimeToFileTime(ref FILETIME lpLocalFileTime, ref FILETIME lpFileTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetFileTime(IntPtr hFile, [Const] IntPtr lpCreationTime, [Const] IntPtr lpLastAccessTime, [Const] IntPtr lpLastWriteTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime, ref FILETIME lpLastWriteTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetLocalTime([Const] IntPtr lpSystemTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetLocalTime(ref SYSTEMTIME lpSystemTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetSystemTime([Const] IntPtr lpSystemTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetSystemTimeAdjustment(uint dwTimeAdjustment, int bTimeAdjustmentDisabled);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetTimeZoneInformation([Const] IntPtr lpTimeZoneInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SystemTimeToFileTime([Const] IntPtr lpSystemTime, IntPtr lpFileTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SystemTimeToFileTime(ref SYSTEMTIME lpSystemTime, ref FILETIME lpFileTime);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SystemTimeToTzSpecificLocalTime(IntPtr lpTimeZoneInformation, IntPtr lpUniversalTime, IntPtr lpLocalTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SystemTimeToTzSpecificLocalTime(ref TIME_ZONE_INFORMATION lpTimeZoneInformation, ref SYSTEMTIME lpUniversalTime, ref SYSTEMTIME lpLocalTime);
    }

    #endregion // Time functions

    #region Communication functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int BuildCommDCBA([Const] IntPtr lpDef, IntPtr lpDCB);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int BuildCommDCBA(string lpDef, ref DCB lpDCB);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int BuildCommDCBW([Const] IntPtr lpDef, IntPtr lpDCB);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int BuildCommDCBW(string lpDef, ref DCB lpDCB);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int BuildCommDCBAndTimeoutsA([Const] IntPtr lpDef, IntPtr lpDCB, IntPtr lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int BuildCommDCBAndTimeoutsA(string lpDef, ref DCB lpDCB, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int BuildCommDCBAndTimeoutsW([Const] IntPtr lpDef, IntPtr lpDCB, IntPtr lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int BuildCommDCBAndTimeoutsW(string lpDef, ref DCB lpDCB, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ClearCommBreak(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ClearCommError(IntPtr hFile, IntPtr lpErrors, IntPtr lpStat);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ClearCommError(IntPtr hFile, ref uint lpErrors, ref COMSTAT lpStat);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CommConfigDialogA(IntPtr lpszName, IntPtr hWnd, IntPtr lpCC);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CommConfigDialogA(StringBuilder lpszName, IntPtr hWnd, ref COMMCONFIG lpCC);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int CommConfigDialogW(IntPtr lpszName, IntPtr hWnd, IntPtr lpCC);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CommConfigDialogW(StringBuilder lpszName, IntPtr hWnd, ref COMMCONFIG lpCC);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EscapeCommFunction(IntPtr hFile, uint dwFunc);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommConfig(IntPtr hCommDev, IntPtr lpCC, IntPtr lpdwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, ref uint lpdwSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommMask(IntPtr hFIle, IntPtr lpEvtMask);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommMask(IntPtr hFIle, ref uint lpEvtMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommModemStatus(IntPtr hFile, IntPtr lpModemStat);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommModemStatus(IntPtr hFile, ref uint lpModemStat);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommProperties(IntPtr hFile, IntPtr lpCommProp);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommProperties(IntPtr hFile, ref COMMPROP lpCommProp);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommState(IntPtr hFile, IntPtr lpDCB);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommState(IntPtr hFile, ref DCB lpDCB);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetCommTimeouts(IntPtr hFile, IntPtr lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetDefaultCommConfig(IntPtr hCommDev, IntPtr lpCC, IntPtr lpdwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetDefaultCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, ref uint lpdwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PurgeComm(IntPtr hFile, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetCommBreak(IntPtr hFile);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetCommConfig(IntPtr hCommDev, IntPtr lpCC, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetCommMask(IntPtr hFile, uint dwEvtMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetCommState(IntPtr hFile, IntPtr lpDCB);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetCommState(IntPtr hFile, ref DCB lpDCB);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetCommTimeouts(IntPtr hFile, IntPtr lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDefaultCommConfig(IntPtr hCommDev, IntPtr lpCC, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetDefaultCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, uint dwSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetupComm(IntPtr hFile, uint dwInQueue, uint dwOutQueue);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int TransmitCommChar(IntPtr hFile, byte cChar);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int WaitCommEvent(IntPtr hFile, IntPtr lpEvtMask, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitCommEvent(IntPtr hFile, ref uint lpEvtMask, ref OVERLAPPED lpOverlapped);
    }

    #endregion // Communication functions

    #region Timer functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern int QueryPerformanceCounter(IntPtr lpPerformanceCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int QueryPerformanceCounter(ref LARGE_INTEGER lpPerformanceCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int QueryPerformanceCounterFrequency(IntPtr lpPerformanceCount);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int QueryPerformanceCounterFrequency(ref LARGE_INTEGER lpPerformanceCount);
    }

    #endregion // Timer functions

    #region Device input and output functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesReturned, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, ref OVERLAPPED lpOverlapped);
    }

    #endregion // Device input and output functions

    #region National language support functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LCID ConvertDefaultLocale(LCID Locale);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumCalendarInfoA(IntPtr lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumCalendarInfoA(EnumCalendarInfoProc lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumCalendarInfoW(IntPtr lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumCalendarInfoW(EnumCalendarInfoProc lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumCalendarInfoExA(IntPtr lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumCalendarInfoExA(EnumCalendarInfoProcEx lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumCalendarInfoExW(IntPtr lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumCalendarInfoExW(EnumCalendarInfoProcEx lpCalInfoEnumProc, LCID Locale, CALID Calendar, CALTYPE CalType);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDateFormatsA(IntPtr lpDateFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumDateFormatsA(EnumDateFormatsProc lpDateFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumDateFormatsW(IntPtr lpDateFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumDateFormatsW(EnumDateFormatsProc lpDateFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumSystemCodePagesA(IntPtr lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumSystemCodePagesA(EnumCodePagesProc lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumSystemCodePagesW(IntPtr lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumSystemCodePagesW(EnumCodePagesProc lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumSystemLocalesA(IntPtr lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumSystemLocalesA(EnumLocalesProc lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumSystemLocalesW(IntPtr lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumSystemLocalesW(EnumLocalesProc lpCodePageEnumProc, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumTimeFormatsA(IntPtr lpTimeFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int EnumTimeFormatsA(EnumTimeFormatsProc lpTimeFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int EnumTimeFormatsW(IntPtr lpTimeFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int EnumTimeFormatsW(EnumTimeFormatsProc lpTimeFmtEnumProc, LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetACP();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCPInfo(uint CodePage, IntPtr lpCPInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCPInfo(uint CodePage, ref CPINFO lpCPInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCurrencyFormatA(LCID Locale, uint dwFlags, [Const] IntPtr lpValue, [Const] IntPtr lpFormat, IntPtr lpCurrencyStr, int cchCurrency);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetCurrencyFormatA(LCID Locale, uint dwFlags, string lpValue, ref CURRENCYFMT lpFormat, StringBuilder lpCurrencyStr, int cchCurrency);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetCurrencyFormatW(LCID Locale, uint dwFlags, [Const] IntPtr lpValue, [Const] IntPtr lpFormat, IntPtr lpCurrencyStr, int cchCurrency);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetCurrencyFormatW(LCID Locale, uint dwFlags, string lpValue, ref CURRENCYFMT lpFormat, StringBuilder lpCurrencyStr, int cchCurrency);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetDateFormatA(LCID Locale, uint dwFlags, [Const] IntPtr lpDate, [Const] IntPtr lpFormat, IntPtr lpDateStr, int cchDate);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetDateFormatA(LCID Locale, uint dwFlags, ref SYSTEMTIME lpDate, string lpFormat, StringBuilder lpDateStr, int cchDate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetDateFormatW(LCID Locale, uint dwFlags, [Const] IntPtr lpDate, [Const] IntPtr lpFormat, IntPtr lpDateStr, int cchDate);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetDateFormatW(LCID Locale, uint dwFlags, ref SYSTEMTIME lpDate, string lpFormat, StringBuilder lpDateStr, int cchDate);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLocaleInfoA(LCID Locale, LCTYPE LCType, IntPtr lpLCData, int cchData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetLocaleInfoA(LCID Locale, LCTYPE LCType, StringBuilder lpLCData, int cchData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetLocaleInfoW(LCID Locale, LCTYPE LCType, IntPtr lpLCData, int cchData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetLocaleInfoW(LCID Locale, LCTYPE LCType, StringBuilder lpLCData, int cchData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNumberFormatA(LCID Locale, uint dwFlags, [Const] IntPtr lpValue, [Const] IntPtr lpFormat, IntPtr lpNumberStr, int cchNumber);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetNumberFormatA(LCID Locale, uint dwFlags, string lpValue, ref NUMBERFMT lpFormat, StringBuilder lpNumberStr, int cchNumber);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNumberFormatW(LCID Locale, uint dwFlags, [Const] IntPtr lpValue, [Const] IntPtr lpFormat, IntPtr lpNumberStr, int cchNumber);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetNumberFormatW(LCID Locale, uint dwFlags, string lpValue, ref NUMBERFMT lpFormat, StringBuilder lpNumberStr, int cchNumber);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetOEMCP();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LANGID GetSystemDefaultLangID();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LCID GetSystemDefaultLCID();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LCID GetThreadLocale();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTimeFormatA(LCID Locale, uint dwFlags, [Const] IntPtr lpTime, [Const] IntPtr lpFormat, IntPtr lpTimeStr, int cchTime);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetTimeFormatA(LCID Locale, uint dwFlags, ref SYSTEMTIME lpTime, string lpFormat, StringBuilder lpTimeStr, int cchTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetTimeFormatW(LCID Locale, uint dwFlags, [Const] IntPtr lpTime, [Const] IntPtr lpFormat, IntPtr lpTimeStr, int cchTime);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetTimeFormatW(LCID Locale, uint dwFlags, ref SYSTEMTIME lpTime, string lpFormat, StringBuilder lpTimeStr, int cchTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LANGID GetUserDefaultLangID();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern LCID GetUserDefaultLCID();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int IsValidCodePage(uint CodePage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int IsValidLocale(LCID Locale, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LCMapStringA(LCID Locale, uint dwMapFlags, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int LCMapStringA(LCID Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int LCMapStringW(LCID Locale, uint dwMapFlags, [Const] IntPtr lpSrcStr, int cchSrc, IntPtr lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int LCMapStringW(LCID Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetLocaleInfoA(LCID Locale, LCTYPE LCType, [Const] IntPtr lpLCData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int SetLocaleInfoA(LCID Locale, LCTYPE LCType, string lpLCData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetLocaleInfoW(LCID Locale, LCTYPE LCType, [Const] IntPtr lpLCData);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int SetLocaleInfoW(LCID Locale, LCTYPE LCType, string lpLCData);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadLocale(LCID Locale);
    }

    #endregion // National language support functions

    #region Mailslot functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateMailslotA([Const] IntPtr lpName, uint nMaxMessageSize, uint lReadTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateMailslotA(string lpName, uint nMaxMessageSize, uint lReadTimeOut, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateMailslotW([Const] IntPtr lpName, uint nMaxMessageSize, uint lReadTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateMailslotW(string lpName, uint nMaxMessageSize, uint lReadTimeOut, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetMailslotInfo(IntPtr hMailslot, IntPtr lpMaxMessageSize, IntPtr lpNextSize, IntPtr lpMessageCount, IntPtr lpReadTimeout);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetMailslotInfo(IntPtr hMailslot, ref uint lpMaxMessageSize, ref uint lpNextSize, ref uint lpMessageCount, ref uint lpReadTimeout);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetMailslotInfo(IntPtr hMailslot, uint lReadTimeout);
    }

    #endregion // Mailslot functions

    #region Pipe functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CallNamedPipeA([Const] IntPtr lpNamedPipeName, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesRead, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CallNamedPipeA(string lpNamedPipeName, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesRead, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CallNamedPipeW([Const] IntPtr lpNamedPipeName, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesRead, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CallNamedPipeW(string lpNamedPipeName, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesRead, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int ConnectNamedPipe(IntPtr hNamedPipe, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int ConnectNamedPipe(IntPtr hNamedPipe, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateNamedPipeA([Const] IntPtr lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern IntPtr CreateNamedPipeA(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateNamedPipeW([Const] IntPtr lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern IntPtr CreateNamedPipeW(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePipe(IntPtr hReadPipe, IntPtr hWritePipe, IntPtr lpPipeAttributes, uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreatePipe(ref IntPtr hReadPipe, ref IntPtr hWritePipe, ref SECURITY_ATTRIBUTES lpPipeAttributes, uint nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int DisconnectNamedPipe(IntPtr hNamedPipe);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNamedPipeHandleStateA(IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, IntPtr lpUserName, uint nMaxUserNameSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int GetNamedPipeHandleStateA(IntPtr hNamedPipe, ref uint lpState, ref uint lpCurInstances, ref uint lpMaxCollectionCount, ref uint lpCollectDataTimeout, StringBuilder lpUserName, uint nMaxUserNameSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNamedPipeHandleStateW(IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, IntPtr lpUserName, uint nMaxUserNameSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int GetNamedPipeHandleStateW(IntPtr hNamedPipe, ref uint lpState, ref uint lpCurInstances, ref uint lpMaxCollectionCount, ref uint lpCollectDataTimeout, StringBuilder lpUserName, uint nMaxUserNameSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetNamedPipeInfo(IntPtr hNamedPipe, IntPtr lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetNamedPipeInfo(IntPtr hNamedPipe, ref uint lpFlags, ref uint lpOutBufferSize, ref uint lpInBufferSize, ref uint lpMaxInstances);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PeekNamedPipe(IntPtr hNamedPipe, IntPtr lpBuffer, uint nBufferSize, IntPtr lpBytesRead, IntPtr lpTotalBytesAvail, IntPtr lpBytesLeftThisMessage);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int PeekNamedPipe(IntPtr hNamedPipe, IntPtr lpBuffer, uint nBufferSize, ref uint lpBytesRead, ref uint lpTotalBytesAvail, ref uint lpBytesLeftThisMessage);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetNamedPipeHandleState(IntPtr hNamedPipe, IntPtr lpMode, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetNamedPipeHandleState(IntPtr hNamedPipe, ref uint lpMode, ref uint lpMaxCollectionCount, ref uint lpCollectDataTimeout);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TransactNamedPipe(IntPtr hNamedPipe, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesRead, IntPtr lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TransactNamedPipe(IntPtr hNamedPipe, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesRead, ref OVERLAPPED lpOverlapped);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitNamedPipeA([Const] IntPtr lpNamedPipe, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int WaitNamedPipeA(string lpNamedPipe, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int WaitNamedPipeW([Const] IntPtr lpNamedPipe, uint nTimeOut);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int WaitNamedPipeW(string lpNamedPipe, uint nTimeOut);
    }

    #endregion // Pipe functions

    #region Process and thread functions

    partial class kernel32
    {
        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern int AttachThreadInput(uint idAttach, uint idAttachTo, int fAttach);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr CommandLineToArgvW(IntPtr lpCmdLine, IntPtr pNumArgs);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CommandLineToArgvW(string lpCmdLine, ref int pNumArgs);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessA([Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessA(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessA(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessA(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessW([Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessW(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessW(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessW(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);


        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, [Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern int CreateProcessAsUserA(IntPtr hToken, string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, [Const] IntPtr lpApplicationName, IntPtr lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, [Const] IntPtr lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, IntPtr lpStartupInfo, IntPtr lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern int CreateProcessAsUserW(IntPtr hToken, string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, ref ThreadProc lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, ref SECURITY_ATTRIBUTES lpThreadAttributes, uint dwStackSize, ref ThreadProc lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, ref ThreadProc lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateThread(ref SECURITY_ATTRIBUTES lpThreadAttributes, uint dwStackSize, ref ThreadProc lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void ExitProcess(uint uExitCode);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void ExitThread(uint dwExitCode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FreeEnvironmentStringsA(IntPtr lpszEnvironmentBlock);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int FreeEnvironmentStringsW(IntPtr lpszEnvironmentBlock);

        [DllImport(ModuleName)]
        public static extern IntPtr GetCommandLineA();

        [DllImport(ModuleName)]
        public static extern IntPtr GetCommandLineW();

        [DllImport(ModuleName)]
        public static extern IntPtr GetCurrentProcess();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetCurrentProcessId();

        [DllImport(ModuleName)]
        public static extern IntPtr GetCurrentThread();

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern uint GetCurrentThreadId();

        [DllImport(ModuleName)]
        public static extern IntPtr GetEnvironmentStringsA();

        [DllImport(ModuleName)]
        public static extern IntPtr GetEnvironmentStringsW();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnvironmentVariableA([Const] IntPtr lpName, IntPtr lpBuffer, uint nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint GetEnvironmentVariableA(string lpName, StringBuilder lpBuffer, uint nSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetEnvironmentVariableW([Const] IntPtr lpName, IntPtr lpBuffer, uint nSize);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode), CLSCompliant(false)]
        public static extern uint GetEnvironmentVariableW(string lpName, StringBuilder lpBuffer, uint nSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetExitCodeProcess(IntPtr hProcess, IntPtr lpExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetExitCodeProcess(IntPtr hProcess, ref uint lpExitCode);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetExitCodeThread(IntPtr hThread, IntPtr lpExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetExitCodeThread(IntPtr hThread, ref uint lpExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetPriorityClass(IntPtr hProcess);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessAffinityMask(IntPtr hProcess, IntPtr lpProcessAffinityMask, IntPtr lpSystemAffinityMask);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetProcessAffinityMask(IntPtr hProcess, ref uint lpProcessAffinityMask, ref uint lpSystemAffinityMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessPriorityBoost(IntPtr hProcess, IntPtr pDisablePriorityBoost);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessPriorityBoost(IntPtr hProcess, ref int pDisablePriorityBoost);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessShutdownParameters(IntPtr lpdwLevel, IntPtr lpdwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetProcessShutdownParameters(ref uint lpdwLevel, ref uint lpdwFlags);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessTimes(IntPtr hProcess, IntPtr lpCreationTime, IntPtr lpExitTime, IntPtr lpKernelTime, IntPtr lpUserTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetProcessTimes(IntPtr hProcess, ref FILETIME lpCreationTime, ref FILETIME lpExitTime, ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint GetProcessVersion(uint ProcessId);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetProcessWorkingSetSize(IntPtr hProcess, IntPtr lpMinimumWorkingSetSize, IntPtr lpMaximumWorkingSetSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetProcessWorkingSetSize(IntPtr hProcess, ref uint lpMinimumWorkingSetSize, ref uint lpMaximumWorkingSetSize);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern void GetStartupInfo(IntPtr lpStartupInfo);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern void GetStartupInfo(ref STARTUPINFO lpStartupInfo);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadPriority(IntPtr hThread);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadPriorityBoost(IntPtr hThread, IntPtr pDisablePriorityBoost);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadPriorityBoost(IntPtr hThread, ref int pDisablePriorityBoost);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int GetThreadTimes(IntPtr hThread, IntPtr lpCreationTime, IntPtr lpExitTime, IntPtr lpKernelTime, IntPtr lpUserTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int GetThreadTimes(IntPtr hThread, ref FILETIME lpCreationTime, ref FILETIME lpExitTime, ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint ResumeThread(IntPtr hThread);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetEnvironmentVariableA([Const] IntPtr lpName, [Const] IntPtr lpValue);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern int SetEnvironmentVariableA(string lpName, string lpValue);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetEnvironmentVariableW([Const] IntPtr lpName, [Const] IntPtr lpValue);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SetEnvironmentVariableW(string lpName, string lpValue);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetPriorityClass(IntPtr hProcess, uint dwPriorityClass);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetProcessAffinityMask(IntPtr hProcess, uint dwProcessAffinityMask);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetProcessPriorityBoost(IntPtr hProcess, int DisablePriorityBoost);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetProcessShutdownParameters(uint dwLevel, uint dwFlags);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetProcessWorkingSetSize(IntPtr hProcess, uint dwMinimumWorkingSetSize, uint MaximumWorkingSetSize);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadAffinityMask(IntPtr hProcess, uint dwThreadAffinityMask);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int SetThreadIdealProcessor(IntPtr hProcess, uint dwIdealProcessor);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetThreadPriority(IntPtr hProcess, int nPriority);

        [DllImport(ModuleName, SetLastError = true)]
        public static extern int SetThreadPriorityBoost(IntPtr hProcess, int DisablePriorityBoost);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void Sleep(uint dwMilliseconds);

        [DllImport(ModuleName), CLSCompliant(false)]
        public static extern void SleepEx(uint dwMilliseconds, int bAlertable);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint SuspendThread(IntPtr hThread);

        [DllImport(ModuleName)]
        public static extern int SwitchToThread();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TerminateProcess(IntPtr hProcess, uint uExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TerminateThread(IntPtr hThread, uint dwExitCode);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint TlsAlloc();

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TlsFree(uint dwTlsIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr TlsGetValue(uint dwTlsIndex);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern int TlsSetValue(uint dwTlsIndex, IntPtr lpTlsValue);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WaitForInputIdle(IntPtr hProcess, uint dwMilliseconds);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern uint WinExec([Const] IntPtr lpCmdLine, uint nCmdShow);

        [DllImport(ModuleName, SetLastError = true, CharSet = CharSet.Ansi), CLSCompliant(false)]
        public static extern uint WinExec(string lpCmdLine, uint nCmdShow);
    }

    #endregion // Process and thread functions

    #region Fiber functions

    partial class kernel32
    {
        [DllImport(ModuleName, SetLastError = true)]
        public static extern IntPtr ConvertThreadToFiber(IntPtr lpParameter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFiber(uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter);

        [DllImport(ModuleName, SetLastError = true), CLSCompliant(false)]
        public static extern IntPtr CreateFiber(uint dwStackSize, FiberProc lpStartAddress, IntPtr lpParameter);

        [DllImport(ModuleName)]
        public static extern void DeleteFiber(IntPtr lpFiber);

        [DllImport(ModuleName)]
        public static extern IntPtr GetCurrentFiber();

        [DllImport(ModuleName)]
        public static extern IntPtr GetFiberData();

        [DllImport(ModuleName)]
        public static extern void SwitchToFiber(IntPtr lpFiber);
    }

    #endregion // Fiber functions
}
