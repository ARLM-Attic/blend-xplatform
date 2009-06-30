using System;
using NUnit.Framework;
using xPlatform.Buffers;
using xPlatform.Strings;
using System.Runtime.InteropServices;

namespace xPlatform.x86.msvcrt.Test
{
    [TestFixture]
    public class msvcrtTest : AssertionHelper
    {
        [Test]
        public void _memccpyTest()
        {
            GlobalHeapAnsiString string1 = new GlobalHeapAnsiString("The quick brown dog jumps over the lazy fox");
            GlobalHeapAnsiString buffer = new GlobalHeapAnsiString(61);
            SBytePointer pdest = new SBytePointer();

            Console.Write("Function: _memccpy 60 characters or to character 's'\n");
            Console.Write("Source: {0}\n", string1.ToString());

            pdest = msvcrt._memccpy(buffer, string1, 's', 60u);
            pdest.SetData(0);

            Console.Write("Result: {0}\n", buffer.ToString());
            Console.Write("Length: {0} characters\n", msvcrt.strlen(buffer.Address));

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

            Console.Write("String to be searched:\n             {0}\n", @string.ToString());
            Console.Write("             {0}\n             {1}\n\n", fmt1.ToString(), fmt2.ToString());

            Console.Write("Search char: {0}\n", (char)ch);
            pdest = msvcrt.memchr(@string, ch, (size_t)@string.Length);
            result = (int)(pdest - @string + 1);

            if (pdest != null)
                Console.Write("Result:      {0} found at position {1}\n", (char)ch, result);
            else
                Console.Write("Result:      {0} not found\n", (char)ch);

            Assert.AreEqual(12, result);

            str.Dispose();
            @string.Dispose();
            fmt1.Dispose();
            fmt2.Dispose();
        }

        [Test]
        public void memcmpTest()
        {
            GlobalHeapAnsiString first = new GlobalHeapAnsiString("12345678901234567890");
            GlobalHeapAnsiString second = new GlobalHeapAnsiString("12345678901234567891");
            GlobalHeapBuffer<int> int_arr1 = new GlobalHeapBuffer<int>(1, 2, 3, 4);
            GlobalHeapBuffer<int> int_arr2 = new GlobalHeapBuffer<int>(1, 2, 3, 4);
            int result;

            Console.Write("Compare '{0}' to '{1}':\n", first.ToString().Substring(0, 19), second.ToString().Substring(0, 19));
            result = msvcrt.memcmp(first, second, (size_t)19);

            if (result < 0)
                Console.Write("First is less than second.\n");
            else if (result == 0)
                Console.Write("First is equal to second.\n");
            else
                Console.Write("First is greater than second.\n");

            Assert.AreEqual(0, result);

            Console.Write("Compare '{0},{1}' to '{2},{3}':\n",
                int_arr1[0], int_arr1[1], int_arr2[0], int_arr2[1]);
            result = msvcrt.memcmp(int_arr1, int_arr2,
                (size_t)(Utilities.NativeSizeOf(typeof(int)) * 2));

            if (result < 0)
                Console.Write("int_arr1 is less than int_arr2.\n");
            else if (result == 0)
                Console.Write("int_arr1 is equal to int_arr2.\n");
            else
                Console.Write("int_arr1 is greater than int_arr2.\n");

            Assert.AreEqual(0, result);

            first.Dispose();
            second.Dispose();
            int_arr1.Dispose();
            int_arr2.Dispose();
        }

        [Test]
        public void memmoveTest()
        {
            GlobalHeapAnsiString str1 = new GlobalHeapAnsiString("aabbcc");
            GlobalHeapAnsiString str2 = new GlobalHeapAnsiString("aabbcc");

            Console.Write("The string: {0}\n", str1);
            Assert.AreEqual("aabbcc", str1.ToString());

            msvcrt.memcpy(str1 + 2, str1, (size_t)4);

            Console.Write("New string: {0}\n", str1);
            Assert.AreEqual("aaaabb", str1.ToString());

            msvcrt.strcpy(str1, str2); // reset string

            Console.Write("The string: {0}\n", str1);
            Assert.AreEqual("aabbcc", str1.ToString());

            msvcrt.memmove(str1 + 2, str1, (size_t)4);
            
            Console.Write("New string: {0}\n", str1);
            Assert.AreEqual("aaaabb", str1.ToString());

            str1.Dispose();
            str2.Dispose();
        }

        [Test]
        public void _memicmpTest()
        {
            int result;
            GlobalHeapAnsiString first = new GlobalHeapAnsiString("Those Who Will Not Learn from History");
            GlobalHeapAnsiString second = new GlobalHeapAnsiString("THOSE WHO WILL NOT LEARN FROM their mistakes");

            Console.Write("Compare '{0}' to '{1}'\n", first.ToString().Substring(0, 29), second.ToString().Substring(0, 29));
            result = msvcrt._memicmp(first, second, 29u);

            if (result < 0)
                Console.Write("First is less than second.\n");
            else if (result == 0)
                Console.Write("First is equal to second.\n");
            else if (result > 0)
                Console.Write("First is greater than second.\n");

            Assert.AreEqual(0, result);

            first.Dispose();
            second.Dispose();
        }

        [Test]
        public void memsetTest()
        {
            GlobalHeapAnsiString buffer = new GlobalHeapAnsiString("This is a test of the memset function");
            Console.Write("Before: {0}\n", buffer);
            Assert.AreEqual("This is a test of the memset function", buffer.ToString());

            msvcrt.memset(buffer, '*', (size_t)4);
            Console.Write("After:  {0}\n", buffer);
            Assert.AreEqual("**** is a test of the memset function", buffer.ToString());

            buffer.Dispose();
        }

        [Test]
        public void _swabTest()
        {
            GlobalHeapAnsiString from = new GlobalHeapAnsiString("BADCFEHGJILKNMPORQTSVUXWZY");
            GlobalHeapAnsiString to = new GlobalHeapAnsiString("..........................");

            Console.Write("Before: {0}\n        {1}\n\n", from, to);
            msvcrt._swab(from, to, from.Length);
            Console.Write("After:  {0}\n        {1}\n\n", from, to);

            Assert.AreEqual("BADCFEHGJILKNMPORQTSVUXWZY", from.ToString());
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", to.ToString());

            from.Dispose();
            to.Dispose();
        }

        public void mbsinitTest()
        {
            const int BUF_SIZE = 0x40;

            GlobalHeapUnicodeString g_wcBuf = new GlobalHeapUnicodeString(BUF_SIZE);
            g_wcBuf.SetBufferText("This is a wc buffer that will be over written...");

            GlobalHeapAnsiString g_mbBuf = new GlobalHeapAnsiString(BUF_SIZE);
            g_mbBuf.SetBufferText("AaBbCc\x9A\x8B\xE0\xEF\xF0xXyYzZ");

            int g_nInit = (int)msvcrt.strlen(g_mbBuf.Address);
        }
    }
}
