﻿/*
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

namespace Blend.xPlatform.Win32
{
    /// <summary>
    /// __int64 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum __int64 : long { }

    /// <summary>
    /// _dev_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum _dev_t : uint { }

    /// <summary>
    /// _ino_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum _ino_t : ushort { }

    /// <summary>
    /// _mode_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum _mode_t : ushort { }

    /// <summary>
    /// _off_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum _off_t : int { }

    /// <summary>
    /// time_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum time_t : int { }

    /// <summary>
    /// __time64_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum __time64_t : long { }

    /// <summary>
    /// u_char 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum u_char : byte { }

    /// <summary>
    /// u_short 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum u_short : ushort { }

    /// <summary>
    /// u_int 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum u_int : uint { }

    /// <summary>
    /// u_long 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum u_long : ulong { }

    /// <summary>
    /// dev_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum dev_t : ulong { }

    /// <summary>
    /// ino_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum ino_t : ushort { }

    /// <summary>
    /// mode_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum mode_t : ushort { }

    /// <summary>
    /// off_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum off_t : int { }

    /// <summary>
    /// pid_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum pid_t : int { }

    /// <summary>
    /// ssize_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum ssize_t : int { }

    /// <summary>
    /// wchar_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum wchar_t : ushort { }

    /// <summary>
    /// wint_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum wint_t : ushort { }

    /// <summary>
    /// wctype_t 형식에 대한 정의입니다.
    /// </summary>
    [Serializable]
    [Obsolete(PlatformInvokeBase.ObsoleteTypeCasting, false)]
    public enum wctype_t : ushort { }
}