using System;

namespace xPlatform.x86.msvcrt
{
    [Serializable]
    public partial class msvcrt : ModuleBase<msvcrt>
    {
        [NonSerialized]
        public const string ModuleName = "msvcrt.dll";
    }

    partial class mvcrt
    {
    }
}
