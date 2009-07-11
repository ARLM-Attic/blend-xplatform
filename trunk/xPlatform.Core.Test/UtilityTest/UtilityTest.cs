using System;
using NUnit.Framework;

namespace xPlatform.Test.UtilityTest
{
    [TestFixture]
    public class UtilityTest : AssertionHelper
    {
        private Random random = new Random();

        [Test]
        public void CreateWhitespaceStringTest1()
        {
            int length = random.Next(1, (int)Byte.MaxValue);
            Assert.AreEqual(length, Utilities.CreateWhitespaceString(length).Length);
        }

        [Test]
        public void CreateWhitespaceStringTest2()
        {
            int length = random.Next(Int32.MinValue, 0);
            Assert.True(Utilities.CreateWhitespaceString(length).Length < 1);
        }

        [Test]
        public void NativeSizeOfTest1()
        {
            foreach (Type eachType in new Type[] { typeof(char), typeof(bool),
                typeof(byte), typeof(DateTime), typeof(decimal), typeof(double),
                typeof(Guid), typeof(short), typeof(int), typeof(long), typeof(IntPtr),
                typeof(sbyte), typeof(float), typeof(TimeSpan), typeof(ushort),
                typeof(uint), typeof(ulong), typeof(UIntPtr)})
            {
                Console.WriteLine(">> {0} byte{1}", Utilities.NativeSizeOf(eachType),
                    Utilities.NativeSizeOf(eachType) > 1 ? "s" : String.Empty);
            }
        }

        [Test]
        public void GetHighByteTest1()
        {
            Assert.AreEqual(0x12, Utilities.GetHighByte(0x1234));
        }

        [Test]
        public void GetLowByteTest1()
        {
            Assert.AreEqual(0x34, Utilities.GetLowByte(0x1234));
        }

        [Test]
        public void GetHighWordTest1()
        {
            Assert.AreEqual(0x8000, Utilities.GetHighWord(0x80000000));
            Assert.AreEqual(0xffff, Utilities.GetHighWord(0xffffffff));
            Assert.AreEqual(0xabcd, Utilities.GetHighWord(0xabcdface));
        }

        [Test]
        public void GetLowWordTest1()
        {
            Assert.AreEqual(0x0000, Utilities.GetLowWord(0x80000000));
            Assert.AreEqual(0xffff, Utilities.GetLowWord(0xffffffff));
            Assert.AreEqual(0xface, Utilities.GetLowWord(0xabcdface));
        }

        [Test]
        public void MakeWordTest1()
        {
            Random r = new Random();
            int test = r.Next(0, UInt16.MaxValue);
            Console.WriteLine("{0:X}", test);

            Assert.AreEqual(test, Utilities.MakeWord(
                Utilities.GetLowByte(test),
                Utilities.GetHighByte(test)));
        }

        [Test]
        public void MakeLongTest1()
        {
            Random r = new Random();
            long test = r.Next(0, Int32.MaxValue);
            Console.WriteLine("{0:X}", test);

            Assert.AreEqual(test, Utilities.MakeLong(
                Utilities.GetLowWord(test),
                Utilities.GetHighWord(test)));
        }

        [Test]
        public void SwapEndianTest1()
        {
            Assert.AreEqual(0x0, Utilities.SwapEndian(0x0));
            Assert.AreEqual(-1, Utilities.SwapEndian(-1));
            Assert.AreEqual(0x78563412, Utilities.SwapEndian(0x12345678));
            Assert.AreEqual(0x80, Utilities.SwapEndian(0x80000000));
            Assert.AreEqual(-2147483648, Utilities.SwapEndian(0x80));
            Assert.AreEqual(-129, Utilities.SwapEndian(0x7fffffff));
        }
    }
}
