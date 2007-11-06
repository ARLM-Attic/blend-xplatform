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
    }
}
