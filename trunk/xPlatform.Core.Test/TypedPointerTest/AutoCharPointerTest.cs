using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class AutoCharPointerTest : AssertionHelper
    {
        private Random random = new Random();

        public char GenerateRandomNumber()
        {
            return (char)random.Next('a', 'z');
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // GetData method
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = (char)pointer.GetData(i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest2()
        {
            const int bufferSize = 4;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Indexer based memory navigation
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = (char)pointer[i];
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest3()
        {
            const int bufferSize = 4;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(char*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            // SetData method
            for (int i = 0; i < bufferSize; i++)
                pointer.SetData(results[i] = GenerateRandomNumber(), i);

            // GetData method
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = (char)pointer.GetData(i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest5()
        {
            const int bufferSize = 4;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            // Indexer based memory writing
            for (int i = 0; i < bufferSize; i++)
                results[i] = (char)(pointer[i] = (int)GenerateRandomNumber());

            // Indexer based memory navigation
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = (char)pointer[i];
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest6()
        {
            const int bufferSize = 5;
            char* sample = stackalloc char[bufferSize];
            AutoCharPointer pointer = new AutoCharPointer(sample);
            char[] results = new char[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(char*)(pointer + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(char*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            char* sample = stackalloc char[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new AutoCharPointer(sample));
            Console.WriteLine("Marshal.SizeOf(new AutoCharPointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(AutoCharPointer));
            Console.WriteLine("Marshal.SizeOf(typeof(AutoCharPointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(char*));
            Console.WriteLine("Marshal.SizeOf(typeof(char*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, AutoCharPointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            char* sample = stackalloc char[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(AutoCharPointer);
            Console.WriteLine("sizeof(AutoCharPointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(char*);
            Console.WriteLine("sizeof(char*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, AutoCharPointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            char* sample = stackalloc char[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            AutoCharPointer address3 = new AutoCharPointer(address2);
            Console.WriteLine("AutoCharPointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            AutoCharPointer address4 = new AutoCharPointer(address1);
            Console.WriteLine("AutoCharPointer Address (from Int32): {0:X}", address4.ToInt32());
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
            char* sample = stackalloc char[4];
            AutoCharPointer a = new AutoCharPointer(sample);
            AutoCharPointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(char), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            AutoCharPointer c = new AutoCharPointer(sample + 1);
            AutoCharPointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
