using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class BooleanPointerTest : AssertionHelper
    {
        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            results[0] = *sample = true;
            for (int i = 1; i < bufferSize; i++)
                results[i] = *(sample + i) = !*(sample + i - 1);

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
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            results[0] = *sample = false;
            for (int i = 1; i < bufferSize; i++)
                results[i] = *(sample + i) = !*(sample + i - 1);

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
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            results[0] = *sample = true;
            for (int i = 1; i < bufferSize; i++)
                results[i] = *(sample + i) = !*(sample + i - 1);

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(bool*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            // SetData method
            pointer.SetData(results[0] = true);
            for (int i = 1; i < bufferSize; i++)
                pointer.SetData(results[i] = !pointer.GetData(i - 1), i);

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
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            // Indexer based memory writing
            results[0] = pointer[0] = false;
            for (int i = 1; i < bufferSize; i++)
                results[i] = pointer[i] = !pointer[i - 1];

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
            const int bufferSize = 4;
            bool* sample = stackalloc bool[bufferSize];
            BooleanPointer pointer = new BooleanPointer(sample);
            bool[] results = new bool[bufferSize];

            // Pointer conversion test
            results[0] = *(bool*)pointer = true;
            for (int i = 1; i < bufferSize; i++)
                results[i] = *(bool*)(pointer + i) = !*(bool*)(pointer + i - 1);
            
            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(bool*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            bool* sample = stackalloc bool[4];

            int totalSize = 0;
            
            int ptrSize1 = Marshal.SizeOf(new BooleanPointer(sample));
            Console.WriteLine("Marshal.SizeOf(new BooleanPointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(BooleanPointer));
            Console.WriteLine("Marshal.SizeOf(typeof(BooleanPointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(IntPtr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(bool*));
            Console.WriteLine("Marshal.SizeOf(typeof(bool*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, BooleanPointer.Size * 5);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            bool* sample = stackalloc bool[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            BooleanPointer address3 = new BooleanPointer(address2);
            Console.WriteLine("BooleanPointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            BooleanPointer address4 = new BooleanPointer(address1);
            Console.WriteLine("BooleanPointer Address (from Int32): {0:X}", address4.ToInt32());
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
            bool* sample = stackalloc bool[4];
            BooleanPointer a = new BooleanPointer(sample);
            BooleanPointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());
            
            // note: low-level memory size is 1 byte. (Marshal.SizeOf(bool) returns 4 bytes)
            Assert.AreEqual(sizeof(bool), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            BooleanPointer c = new BooleanPointer(sample + 1);
            BooleanPointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());
            
            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
