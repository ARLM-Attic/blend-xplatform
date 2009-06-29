using System;
using NUnit.Framework;
using xPlatform.Strings;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt.Test
{
    [TestFixture]
    public unsafe class msvcrtTest : AssertionHelper
    {
        [Test]
        public void _memccpyTest()
        {
            GlobalHeapAnsiString string1 = new GlobalHeapAnsiString("The quick brown dog jumps over the lazy fox");
            GlobalHeapAnsiString buffer = new GlobalHeapAnsiString(61);
            SBytePointer pdest = new SBytePointer();

            Console.WriteLine("Function: _memccpy 60 characters or to character 's'\n");
            Console.WriteLine("Source: {0}\n", string1.ToString());

            pdest = msvcrt._memccpy(buffer, string1, 's', 60u);
            pdest.SetData(0);

            Console.WriteLine("Result: {0}\n", buffer.ToString());
            Console.WriteLine("Length: {0} characters\n", msvcrt.strlen(buffer.Address));

            Assert.AreEqual("The quick brown dog jumps over the lazy fox", string1.ToString());
            Assert.AreEqual("The quick brown dog jumps", buffer.ToString());
            Assert.AreEqual(25u, (uint)msvcrt.strlen(buffer.Address));

            string1.Dispose();
            buffer.Dispose();
            pdest = null;
        }

        [Test]
        public void memchrTest()
        {
            int ch = 'r';
            GlobalHeapAnsiString str = new GlobalHeapAnsiString("lazy");
            GlobalHeapAnsiString @string = new GlobalHeapAnsiString("The quick brown dog jumps over the lazy fox");
            GlobalHeapAnsiString fmt1 = new GlobalHeapAnsiString("         1         2         3         4         5");
            GlobalHeapAnsiString fmt2 = new GlobalHeapAnsiString("12345678901234567890123456789012345678901234567890");

            SBytePointer pdest;
            int result;

            Console.WriteLine("String to be searched:\n             {0}\n", @string.ToString());
            Console.WriteLine("             {0}\n             {1}\n\n", fmt1.ToString(), fmt2.ToString());

            Console.WriteLine("Search char: {0}\n", (char)ch);
            pdest = msvcrt.memchr(@string, ch, (size_t)@string.Length);
            result = (int)(pdest - @string + 1);

            if (pdest != null)
                Console.WriteLine("Result:      {0} found at position {1}\n", (char)ch, result);
            else
                Console.WriteLine("Result:      {0} not found\n", (char)ch);

            str.Dispose();
            @string.Dispose();
            fmt1.Dispose();
            fmt2.Dispose();
        }
    }
}
