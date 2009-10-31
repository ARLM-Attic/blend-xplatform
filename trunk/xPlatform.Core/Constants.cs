using System;
using System.Collections.Generic;
using System.Text;

namespace xPlatform
{
    public static class Constants
    {
        [NonSerialized]
        public const int X86PlatformPtrSize = 4;

        [NonSerialized]
        public const long X86UpperBound = 0x7fffffffL;

        [NonSerialized]
        public const long X86LowerBound = (-2147483648L);

        [NonSerialized]
        public const char NullCharacter = '\0';
    }
}
