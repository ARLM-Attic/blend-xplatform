using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class DateTimePointerTest
    {
        private Random random = new Random();

        public DateTime GenerateRandomDateTime()
        {
            // http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/emt.html
            return DateTime.Now;
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomDateTime();

            // GetData method
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = pointer.GetData(i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }
    }
}
