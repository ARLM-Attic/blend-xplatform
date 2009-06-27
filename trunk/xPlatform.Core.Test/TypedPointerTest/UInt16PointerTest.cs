using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class UInt16PointerTest : AssertionHelper
    {
        private Random random = new Random();

        public ushort GenerateRandomNumber()
        {
            return (ushort)random.Next(UInt16.MinValue, UInt16.MaxValue);
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

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
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

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
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(ushort*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

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
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

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
            ushort* sample = stackalloc ushort[bufferSize];
            UInt16Pointer pointer = new UInt16Pointer(sample);
            ushort[] results = new ushort[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(ushort*)(pointer + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(ushort*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            ushort* sample = stackalloc ushort[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new UInt16Pointer(sample));
            Console.WriteLine("Marshal.SizeOf(new UInt16Pointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(UInt16Pointer));
            Console.WriteLine("Marshal.SizeOf(typeof(UInt16Pointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(ushort*));
            Console.WriteLine("Marshal.SizeOf(typeof(ushort*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, UInt16Pointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            ushort* sample = stackalloc ushort[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(UInt16Pointer);
            Console.WriteLine("sizeof(UInt16Pointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(ushort*);
            Console.WriteLine("sizeof(ushort*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, UInt16Pointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            ushort* sample = stackalloc ushort[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            UInt16Pointer address3 = new UInt16Pointer(address2);
            Console.WriteLine("UInt16Pointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            UInt16Pointer address4 = new UInt16Pointer(address1);
            Console.WriteLine("UInt16Pointer Address (from Int32): {0:X}", address4.ToInt32());
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
            ushort* sample = stackalloc ushort[4];
            UInt16Pointer a = new UInt16Pointer(sample);
            UInt16Pointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(ushort), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            UInt16Pointer c = new UInt16Pointer(sample + 1);
            UInt16Pointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
