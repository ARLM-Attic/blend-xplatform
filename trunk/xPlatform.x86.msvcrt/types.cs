using System;
using xPlatform.Flags;

namespace xPlatform.x86.msvcrt
{
    [Serializable, Flags, CLSCompliant(false)]
    public enum size_t : uint { }

    [Serializable, Flags, CLSCompliant(false)]
    public enum wint_t : ushort { }

    [Serializable, Flags, CLSCompliant(false), Todo("Check actual type of wctype_t")]
    public enum wctype_t : ushort { }
}
