/*
 * Project Blend: the Blossom of .NET Development
 * Copyright (c) 2007 ������
 * 
 * �� ���̺귯���� ���� ����Ʈ�����Դϴ�. ����Ʈ������ �Ǿ絵�ڴ� ���� ����Ʈ���� �����
 * ��ǥ�� GNU ��� �Ϲ� ���� ��� �㰡�� 2.1�� �Ǵ� �� ���� ���� ���Ƿ� �����ؼ�, �� ������
 * ���� ���̺귯���� �����ϰų� ������� �� �ֽ��ϴ�.
 * 
 * �� ���̺귯���� �����ϰ� ���� �� ��������� ������� �����ǰ� ������, Ư���� ������
 * �´� ���ռ� ���γ� �Ǹſ����� ����� �� ��������� �������� ������ ������ ��� ������
 * ������ �������� �ʽ��ϴ�. ���� �ڼ��� ���׿� ���ؼ��� GNU ��� �Ϲ� ���� ��� �㰡����
 * �����Ͻñ� �ٶ��ϴ�.
 * 
 * GNU ��� �Ϲ� ���� ��� �㰡���� �� ���̺귯���� �Բ� �����˴ϴ�. ����, �� ������ ����
 * �Ǿ��ִٸ� ���� ����Ʈ���� ������� �����Ͻñ� �ٶ��ϴ�.
 * 
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA 02111-1307, USA
 * Korean Translation Comes from: http://korea.gnu.org/people/chsong/copyleft/lgpl.ko.html
 * */

using System;
using System.Security.Permissions;
using System.Runtime.InteropServices;

#if DEBUG
#pragma warning disable 618
#endif // DEBUG

namespace Blend.xPlatform.Win32
{
    partial class msvcrt
    {
        public static bool S_ISCHR(int m)
        {
            return (m & _S_IFMT).Equals(_S_IFCHR);
        }

        public static bool S_ISDIR(int m)
        {
            return (m & _S_IFMT).Equals(_S_IFDIR);
        }

        public static bool S_ISFIFO(int m)
        {
            return (m & _S_IFMT).Equals(_S_IFIFO);
        }

        public static bool S_ISREG(int m)
        {
            return (m & _S_IFMT).Equals(_S_IFREG);
        }

        public static int _BLOCK_TYPE(ushort block)
        {
            return (block & 0xFFFF);
        }

        public static int _BLOCK_SUBTYPE(ushort block)
        {
            return (block >> 16 & 0xFFFF);
        }

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern void _ftime(ref _timeb timeptr);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _fstat(int fd, ref _stat buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _stat(string path, ref _stat buffer);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _fstati64(int fd, ref _stati64 buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _stati64(string path, ref _stati64 buffer);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _fstat64(int fd, ref _stat64 buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _stat64(string path, ref _stat64 buffer);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _umask(int pmode);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _wstat(string path, ref _stat buffer);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _wstati64(string path, ref _stati64 buffer);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _wstat64(string path, ref _stat64 buffer);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _futime(int fd, ref _utimbuf filetime);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _utime(string filename, ref _utimbuf times);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _wutime(string filename, ref _utimbuf times);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern string _cgets(string buffer);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern string _cgetws(string buffer);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cprintf(string format, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cwprintf(string format, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cputs(string str);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cputws(string str);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cscanf(string format, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _cwscanf(string format, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _getch();

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern wint_t _getwch();

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _getche();

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern wint_t _getwche();

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _kbhit();

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _putch(int c);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern wint_t _putwch(wchar_t c);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _ungetch(int c);

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern wint_t _ungetwch(wint_t c);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _inp(ushort port);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern ushort _inpw(ushort port);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern uint _inpd(ushort port);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _outp(ushort port, int databyte);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern ushort _outpw(ushort port, ushort dataword);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern ushort _outpd(ushort port, uint dataword);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtCheckMemory();

        [DllImport(ModuleName, CharSet = CharSet.Ansi)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtDbgReport(
            int reportType, string filename, int linenumber,
            string moduleName, string format, __arglist);

        [DllImport(ModuleName, CharSet = CharSet.Unicode)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtDbgReportW(
            int reportType, string filename, int linenumber,
            string moduleName, string format, __arglist);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtDumpMemoryLeaks();

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtSetBreakAlloc(int @new);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtSetDbgFlag(int @new);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern IntPtr _CrtSetDumpClient(IntPtr dumpClient);

        [DllImport(ModuleName)]
        [SecurityPermission(SecurityAction.LinkDemand)]
        public static extern int _CrtSetReportMode(int reportType, int reportMode);
    }
}

#if DEBUG
#pragma warning restore 618
#endif // DEBUG