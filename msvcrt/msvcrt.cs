using System;
using Blend.xPlatform.Base;
using System.Runtime.InteropServices;

public partial class msvcrt : PlatformInvokeBase
{
    [NonSerialized]
    public const string ModuleName = "msvcrt.dll";

    // Compatibility Issue
    // Windows Vista SP1이나 Windows Server 2008에서는 msvcrt.dll을 찾지 못하는 문제가 있음
    // 다음의 Article에서 소개하는 방법을 통하여 간접 로드하는 방법 또한 적용되지 않음
    // http://www.dotnetinterop.com/faq/?q=LoadLibrary
    //
    // Workaround in Win Vista / Server 2008
    // msvcrt20.dll이나 msvcrt40.dll에 대한 라이브러리를 별도로 만들어야 함 (msvcrt20.dll, msvcrt40.dll은 자동으로 찾는 것이 가능)
    // msvcrt40.dll은 msvcrt.dll로 모두 forwarding되는 것으로 명기되어있음
}
