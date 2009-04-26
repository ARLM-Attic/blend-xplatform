using System;

namespace xPlatform
{
    internal static class Utilities
    {
        public static string CreateEmptyString(int length)
        {
            return String.Format(String.Format("{{0,{0}: }}", (length < 1 ? 1 : length)), String.Empty);
        }
    }
}
