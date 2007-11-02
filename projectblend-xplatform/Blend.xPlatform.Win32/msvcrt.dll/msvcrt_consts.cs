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
