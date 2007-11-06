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
using System.Runtime.InteropServices;

#if DEBUG
#pragma warning disable 618
#endif // DEBUG

namespace Blend.xPlatform.Win32
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _stat
    {
        public _dev_t st_dev;
        public _ino_t st_ino;
        public ushort st_mode;
        public short st_nlink;
        public short st_uid;
        public short st_gid;
        public _dev_t st_rdev;
        public _off_t st_size;
        public time_t st_atime;
        public time_t st_mtime;
        public time_t st_ctime;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct stat
    {
        public _dev_t st_dev;
        public _ino_t st_ino;
        public ushort st_mode;
        public short st_nlink;
        public short st_uid;
        public short st_gid;
        public _dev_t st_rdev;
        public _off_t st_size;
        public time_t st_atime;
        public time_t st_mtime;
        public time_t st_ctime;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _stati64
    {
        public _dev_t st_dev;
        public _ino_t st_ino;
        public ushort st_mode;
        public short st_nlink;
        public short st_uid;
        public short st_gid;
        public _dev_t st_rdev;
        public __int64 st_size;
        public time_t st_atime;
        public time_t st_mtime;
        public time_t st_ctime;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _stat64
    {
        public _dev_t st_dev;
        public _ino_t st_ino;
        public ushort st_mode;
        public short st_nlink;
        public short st_uid;
        public short st_gid;
        public _dev_t st_rdev;
        public __int64 st_size;
        public __time64_t st_atime;
        public __time64_t st_mtime;
        public __time64_t st_ctime;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _timeb
    {
        public time_t time;
        public ushort millitm;
        public short timezone;
        public short dstflag;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _utimbuf
    {
        public time_t actime;
        public time_t modtime;
    }
}

#if DEBUG
#pragma warning restore 618
#endif // DEBUG