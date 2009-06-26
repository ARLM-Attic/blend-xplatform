using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class BytePointerTest : AssertionHelper
    {
        private Random random = new Random();

        public byte GenerateRandomNumber()
        {
            return (byte)random.Next(Byte.MinValue, Byte.MaxValue);
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

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
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

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
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(byte*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

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
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

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
            byte* sample = stackalloc byte[bufferSize];
            BytePointer pointer = new BytePointer(sample);
            byte[] results = new byte[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(byte*)(pointer + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(byte*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            byte* sample = stackalloc byte[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new BytePointer(sample));
            Console.WriteLine("Marshal.SizeOf(new BytePointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(BytePointer));
            Console.WriteLine("Marshal.SizeOf(typeof(BytePointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(byte*));
            Console.WriteLine("Marshal.SizeOf(typeof(byte*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, BytePointer.Size * 5);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            byte* sample = stackalloc byte[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            BytePointer address3 = new BytePointer(address2);
            Console.WriteLine("BytePointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            BytePointer address4 = new BytePointer(address1);
            Console.WriteLine("BytePointer Address (from Int32): {0:X}", address4.ToInt32());
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
            byte* sample = stackalloc byte[4];
            BytePointer a = new BytePointer(sample);
            BytePointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(byte), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            BytePointer c = new BytePointer(sample + 1);
            BytePointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
