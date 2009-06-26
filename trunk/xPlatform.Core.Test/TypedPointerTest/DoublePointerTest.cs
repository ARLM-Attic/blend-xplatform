using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class DoublePointerTest : AssertionHelper
    {
        private Random random = new Random();

        public double GenerateRandomNumber()
        {
            return random.NextDouble();
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

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
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

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
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(double*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            // SetData method
            for (int i = 0; i < bufferSize; i++)
                pointer.SetData(results[i] = GenerateRandomNumber(), i);

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
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            // Indexer based memory writing
            for (int i = 0; i < bufferSize; i++)
                results[i] = pointer[i] = GenerateRandomNumber();

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
            double* sample = stackalloc double[bufferSize];
            DoublePointer pointer = new DoublePointer(sample);
            double[] results = new double[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(double*)(pointer + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(double*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            double* sample = stackalloc double[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new DoublePointer(sample));
            Console.WriteLine("Marshal.SizeOf(new DoublePointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(DoublePointer));
            Console.WriteLine("Marshal.SizeOf(typeof(DoublePointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(double*));
            Console.WriteLine("Marshal.SizeOf(typeof(double*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, DoublePointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            double* sample = stackalloc double[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(DoublePointer);
            Console.WriteLine("sizeof(DoublePointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(double*);
            Console.WriteLine("sizeof(double*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, DoublePointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            double* sample = stackalloc double[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            DoublePointer address3 = new DoublePointer(address2);
            Console.WriteLine("DoublePointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            DoublePointer address4 = new DoublePointer(address1);
            Console.WriteLine("DoublePointer Address (from Int32): {0:X}", address4.ToInt32());
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
            double* sample = stackalloc double[4];
            DoublePointer a = new DoublePointer(sample);
            DoublePointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(double), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            DoublePointer c = new DoublePointer(sample + 1);
            DoublePointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
