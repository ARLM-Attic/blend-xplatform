using System;
using NUnit.Framework;
using xPlatform.Strings;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt.Test
{
    [TestFixture]
    public unsafe class msvcrtTest : AssertionHelper
    {
        static void Main()
        {
            msvcrtTest t = new msvcrtTest();
            t._memccpyTest();
        }

        [Test]
        public void _memccpyTest()
        {
            GlobalHeapAnsiString string1 = new GlobalHeapAnsiString("The quick brown dog jumps over the lazy fox");
            GlobalHeapAnsiString buffer = new GlobalHeapAnsiString(61);
            SBytePointer pdest = new SBytePointer();

            msvcrt.printf("Function: _memccpy 60 characters or to character 's'\n");
            msvcrt.printf("Source: %s\n", __arglist(string1.Address));
            pdest = msvcrt._memccpy(buffer, string1, 's', 60u);
            *(sbyte*)pdest = 0;
            msvcrt.printf("Result: %s\n", __arglist(buffer.Address));
            msvcrt.printf("Length: %d characters\n", __arglist((uint)msvcrt.strlen(buffer.Address)));
        }
    }
}
