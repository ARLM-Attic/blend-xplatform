using System;
using System.Text;
using xPlatform.Flags;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xPlatform.x86.gdi32
{
    [Serializable]
    public partial class gdi32 : ModuleBase<gdi32>
    {
        [NonSerialized]
        public const string ModuleName = "gdi32.dll";
    }

    partial class gdi32
    {
    }
}
