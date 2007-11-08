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
    }
}
