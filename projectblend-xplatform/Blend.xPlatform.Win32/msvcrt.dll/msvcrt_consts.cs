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

namespace Blend.xPlatform.Win32
{
    partial class msvcrt
    {
        public const byte _LK_UNLCK = 0;
        public const byte _LK_LOCK = 1;
        public const byte _LK_NBLCK = 2;
        public const byte _LK_RLCK = 3;
        public const byte _LK_NBRLCK = 4;

        public const ushort _S_IEXEC = 0x0040;
        public const ushort _S_IWRITE = 0x0080;
        public const ushort _S_IREAD = 0x0100;
        public const ushort _S_IFIFO = 0x1000;
        public const ushort _S_IFCHR = 0x2000;
        public const ushort _S_IFDIR = 0x4000;
        public const ushort _S_IFREG = 0x8000;
        public const ushort _S_IFMT = 0xF000;

        public const ushort S_IFMT = _S_IFMT;
        public const ushort S_IFDIR = _S_IFDIR;
        public const ushort S_IFCHR = _S_IFCHR;
        public const ushort S_IFREG = _S_IFREG;
        public const ushort S_IREAD = _S_IREAD;
        public const ushort S_IWRITE = _S_IWRITE;
        public const ushort S_IEXEC = _S_IEXEC;

        public const ushort WEOF = 0xFFFF;

        public const ushort _UPPER = 0x0001;
        public const ushort _LOWER = 0x0002;
        public const ushort _DIGIT = 0x0004;
        public const ushort _SPACE = 0x0008;
        public const ushort _PUNCT = 0x0010;
        public const ushort _CONTROL = 0x0020;
        public const ushort _BLANK = 0x0040;
        public const ushort _HEX = 0x0080;
        public const ushort _LEADBYTE = 0x8000;
        public const ushort _ALPHA = (C1_ALPHA | _UPPER | _LOWER);

        public const ushort C1_ALPHA = 0x0100;
        public const ushort C1_UPPER = _UPPER;
        public const ushort C1_LOWER = _LOWER;
        public const ushort C1_DIGIT = _DIGIT;
        public const ushort C1_SPACE = _SPACE;
        public const ushort C1_PUNCT = _PUNCT;
        public const ushort C1_CNTRL = _CONTROL;
        public const ushort C1_BLANK = _BLANK;
        public const ushort C1_XDIGIT = _HEX;

        public const byte _CRT_WARN = 0;
        public const byte _CRT_ERROR = 1;
        public const byte _CRT_ASSERT = 2;
        public const byte _CRT_ERRCNT = 3;

        public const ushort _FREE_BLOCK = 0;
        public const ushort _NORMAL_BLOCK = 1;
        public const ushort _CRT_BLOCK = 2;
        public const ushort _IGNORE_BLOCK = 3;
        public const ushort _CLIENT_BLOCK = 4;
        public const ushort _MAX_BLOCKS = 5;

        public const byte _bNoMansLandFill = 0xFD;
        public const byte _bDeadLandFill = 0xDD;
        public const byte _bCleanLandFill = 0xCD;
        public const byte _bAlignLandFill = 0xBD;

        public const byte nNoMansLandSize = 4;

        public const byte EPERM = 1;
        public const byte ENOENT = 2;
        public const byte ESRCH = 3;
        public const byte EINTR = 4;
        public const byte EIO = 5;
        public const byte ENXIO = 6;
        public const byte E2BIG = 7;
        public const byte ENOEXEC = 8;
        public const byte EBADF = 9;
        public const byte ECHILD = 10;
        public const byte EAGAIN = 11;
        public const byte ENOMEM = 12;
        public const byte EACCES = 13;
        public const byte EFAULT = 14;
        public const byte EBUSY = 16;
        public const byte EEXIST = 17;
        public const byte EXDEV = 18;
        public const byte ENODEV = 19;
        public const byte ENOTDIR = 20;
        public const byte EISDIR = 21;
        public const byte EINVAL = 22;
        public const byte ENFILE = 23;
        public const byte EMFILE = 24;
        public const byte ENOTTY = 25;
        public const byte EFBIG = 27;
        public const byte ENOSPC = 28;
        public const byte ESPIPE = 29;
        public const byte EROFS = 30;
        public const byte EMLINK = 31;
        public const byte EPIPE = 32;
        public const byte EDOM = 33;
        public const byte ERANGE = 34;
        public const byte EDEADLK = 36;
        public const byte EDEADLOCK = EDEADLK;
        public const byte ENAMETOOLONG = 38;
        public const byte ENOLCK = 39;
        public const byte ENOSYS = 40;
        public const byte ENOTEMPTY = 41;
        public const byte EILSEQ = 42;

        public const ushort _O_RDONLY = 0;
        public const ushort _O_WRONLY = 1;
        public const ushort _O_RDWR = 2;
        public const ushort _O_ACCMODE = (_O_RDONLY | _O_WRONLY | _O_RDWR);
        public const ushort _O_APPEND = 0x0008;
        public const ushort _O_RANDOM = 0x0010;
        public const ushort _O_SEQUENTIAL = 0x0020;
        public const ushort _O_TEMPORARY = 0x0040;
        public const ushort _O_NOINHERIT = 0x0080;
        public const ushort _O_CREAT = 0x0100;
        public const ushort _O_TRUNC = 0x0200;
        public const ushort _O_EXCL = 0x0400;
        public const ushort _O_SHORT_LIVED = 0x1000;
        public const ushort _O_TEXT = 0x4000;
        public const ushort _O_BINARY = 0x8000;
        public const ushort _O_RAW = _O_BINARY;

        public const ushort O_RDONLY = _O_RDONLY;
        public const ushort O_WRONLY = _O_WRONLY;
        public const ushort O_RDWR = _O_RDWR;
        public const ushort O_ACCMODE = _O_ACCMODE;
        public const ushort O_APPEND = _O_APPEND;
        public const ushort O_RANDOM = _O_RANDOM;
        public const ushort O_SEQUENTIAL = _O_SEQUENTIAL;
        public const ushort O_TEMPORARY = _O_TEMPORARY;
        public const ushort O_NOINHERIT = _O_NOINHERIT;
        public const ushort O_CREAT = _O_CREAT;
        public const ushort O_TRUNC = _O_TRUNC;
        public const ushort O_EXCL = _O_EXCL;
        public const ushort O_TEXT = _O_TEXT;
        public const ushort O_BINARY = _O_BINARY;
        public const ushort O_RAW = _O_RAW;
    }
}
