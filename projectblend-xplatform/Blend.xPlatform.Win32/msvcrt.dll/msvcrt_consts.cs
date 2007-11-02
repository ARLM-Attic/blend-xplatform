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
        #region sys/locking.h

        public const int _LK_UNLCK = 0;
        public const int _LK_LOCK = 1;
        public const int _LK_NBLCK = 2;
        public const int _LK_RLCK = 3;
        public const int _LK_NBRLCK = 4;

        #endregion // sys/locking.h

        #region sys/stat.h

        public const int _S_IEXEC = 0x0040;
        public const int _S_IWRITE = 0x0080;
        public const int _S_IREAD = 0x0100;
        public const int _S_IFIFO = 0x1000;
        public const int _S_IFCHR = 0x2000;
        public const int _S_IFDIR = 0x4000;
        public const int _S_IFREG = 0x8000;
        public const int _S_IFMT = 0xF000;

        #endregion // sys/stat.h
    }
}
