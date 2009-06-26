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
    }
}
