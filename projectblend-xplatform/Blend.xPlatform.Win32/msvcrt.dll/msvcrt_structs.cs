/*
 * Project Blend: the Blossom of .NET Development
 * Copyright (c) 2007 남정현
 * 
 * 이 라이브러리는 자유 소프트웨어입니다. 소프트웨어의 피양도자는 자유 소프트웨어 재단이
 * 공표한 GNU 약소 일반 공중 사용 허가서 2.1판 또는 그 이후 판을 임의로 선택해서, 그 규정에
 * 따라 라이브러리를 개작하거나 재배포할 수 있습니다.
 * 
 * 이 라이브러리는 유용하게 사용될 수 있으리라는 희망에서 배포되고 있지만, 특정한 목적에
 * 맞는 적합성 여부나 판매용으로 사용할 수 있으리라는 묵시적인 보증을 포함한 어떠한 형태의
 * 보증도 제공하지 않습니다. 보다 자세한 사항에 대해서는 GNU 약소 일반 공중 사용 허가서를
 * 참고하시기 바랍니다.
 * 
 * GNU 약소 일반 공중 사용 허가서는 이 라이브러리와 함께 제공됩니다. 만약, 이 문서가 누락
 * 되어있다면 자유 소프트웨어 재단으로 문의하시기 바랍니다.
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

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public class _CrtMemBlockHeader
    {
        [MarshalAs(UnmanagedType.LPStruct)]
        public _CrtMemBlockHeader pBlockHeaderNext;

        [MarshalAs(UnmanagedType.LPStruct)]
        public _CrtMemBlockHeader pBlockHeaderPrev;

        [MarshalAs(UnmanagedType.LPStr)]
        public string szFileName;

        public int nLine;
        public size_t nDataSize;
        public int nBlockUse;
        public int lRequest;

        [MarshalAs(UnmanagedType.LPArray, SizeConst = msvcrt.nNoMansLandSize)]
        public byte[] gap = new byte[msvcrt.nNoMansLandSize];
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public class _CrtMemState
    {
        [MarshalAs(UnmanagedType.LPStruct)]
        public _CrtMemBlockHeader pBlockHeader;

        [MarshalAs(UnmanagedType.LPArray, SizeConst = msvcrt._MAX_BLOCKS)]
        public uint[] lCounts = new uint[msvcrt._MAX_BLOCKS];

        [MarshalAs(UnmanagedType.LPArray, SizeConst = msvcrt.nNoMansLandSize)]
        public uint[] lSizes = new uint[msvcrt._MAX_BLOCKS];

        public uint lHighWaterCount;
        public uint lTotalCount;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _diskfree_t
    {
        public uint total_clusters;
        public uint avail_clusters;
        public uint sectors_per_cluster;
        public uint bytes_per_sector;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct _finddata_t
    {
        public uint attrib;
        public time_t time_create;
        public time_t time_access;
        public time_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct _finddatai64_t
    {
        public uint attrib;
        public time_t time_create;
        public time_t time_access;
        public time_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]
        public string name;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct _wfinddata_t
    {
        public uint attrib;
        public time_t time_create;
        public time_t time_access;
        public time_t time_write;
        public _fsize_t size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct _wfinddatai64_t
    {
        public uint attrib;
        public time_t time_create;
        public time_t time_access;
        public time_t time_write;
        public long size;

        [MarshalAs(UnmanagedType.LPWStr, SizeConst = 260)]
        public string name;
    }
}

#if DEBUG
#pragma warning restore 618
#endif // DEBUG