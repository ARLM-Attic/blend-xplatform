using System;
using Blend.xPlatform.Base;
using System.Runtime.InteropServices;

public partial class msvcrt : PlatformInvokeBase
{
    [NonSerialized]
    public const string ModuleName = "msvcrt.dll";

    [NonSerialized]
    public const string ModuleNameDebug = "msvcrtd.dll";
}
