using System;
using NUnit.Framework;
using xPlatform.Math.MT;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class DateTimePointerTest
    {
        private MersenneTwister64 random = new MersenneTwister64();

        public DateTime GenerateRandomDateTime()
        {
            return random.NextDateTime().AddYears(2000);
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

        [Test]
        public unsafe void StackallocTest2()
        {
            const int bufferSize = 4;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomDateTime();

            // Indexer based memory navigation
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = pointer[i];
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest3()
        {
            const int bufferSize = 4;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomDateTime();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(DateTime*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            // SetData method
            for (int i = 0; i < bufferSize; i++)
                pointer.SetData(results[i] = GenerateRandomDateTime(), i);

            // GetData method
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = pointer.GetData(i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest5()
        {
            const int bufferSize = 4;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            // Indexer based memory writing
            for (int i = 0; i < bufferSize; i++)
                results[i] = pointer[i] = GenerateRandomDateTime();

            // Indexer based memory navigation
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = pointer[i];
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest6()
        {
            const int bufferSize = 5;
            DateTime* sample = stackalloc DateTime[bufferSize];
            DateTimePointer pointer = new DateTimePointer(sample);
            DateTime[] results = new DateTime[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(DateTime*)(pointer + i) = GenerateRandomDateTime();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(DateTime*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            DateTime* sample = stackalloc DateTime[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new DateTimePointer(sample));
            Console.WriteLine("Marshal.SizeOf(new DateTimePointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(DateTimePointer));
            Console.WriteLine("Marshal.SizeOf(typeof(DateTimePointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(DateTime*));
            Console.WriteLine("Marshal.SizeOf(typeof(DateTime*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, DateTimePointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            DateTime* sample = stackalloc DateTime[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(DateTimePointer);
            Console.WriteLine("sizeof(DateTimePointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(DateTime*);
            Console.WriteLine("sizeof(DateTime*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, DateTimePointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            DateTime* sample = stackalloc DateTime[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            DateTimePointer address3 = new DateTimePointer(address2);
            Console.WriteLine("DateTimePointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            DateTimePointer address4 = new DateTimePointer(address1);
            Console.WriteLine("DateTimePointer Address (from Int32): {0:X}", address4.ToInt32());
            checksum += address4.ToInt32();

            int checksumDigest = checksum / 4;
            Assert.AreEqual(checksumDigest, address1);
            Assert.AreEqual(checksumDigest, address2.ToInt32());
            Assert.AreEqual(checksumDigest, address3.ToInt32());
            Assert.AreEqual(checksumDigest, address4.ToInt32());
        }

        [Test]
        public unsafe void AddressTest1()
        {
            DateTime* sample = stackalloc DateTime[4];
            DateTimePointer a = new DateTimePointer(sample);
            DateTimePointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(DateTime), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            DateTimePointer c = new DateTimePointer(sample + 1);
            DateTimePointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
