using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class GuidPointerTest : AssertionHelper
    {
        public Guid GenerateRandomGuid()
        {
            return Guid.NewGuid();
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomGuid();

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
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomGuid();

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
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomGuid();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(Guid*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            // SetData method
            for (int i = 0; i < bufferSize; i++)
                pointer.SetData(results[i] = GenerateRandomGuid(), i);

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
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            // Indexer based memory writing
            for (int i = 0; i < bufferSize; i++)
                results[i] = pointer[i] = GenerateRandomGuid();

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
            Guid* sample = stackalloc Guid[bufferSize];
            GuidPointer pointer = new GuidPointer(sample);
            Guid[] results = new Guid[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(Guid*)(pointer + i) = GenerateRandomGuid();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(Guid*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            Guid* sample = stackalloc Guid[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new GuidPointer(sample));
            Console.WriteLine("Marshal.SizeOf(new GuidPointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(GuidPointer));
            Console.WriteLine("Marshal.SizeOf(typeof(GuidPointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(IntPtr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(Guid*));
            Console.WriteLine("Marshal.SizeOf(typeof(Guid*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, GuidPointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            Guid* sample = stackalloc Guid[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(GuidPointer);
            Console.WriteLine("sizeof(GuidPointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(Guid*);
            Console.WriteLine("sizeof(Guid*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, GuidPointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            Guid* sample = stackalloc Guid[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            GuidPointer address3 = new GuidPointer(address2);
            Console.WriteLine("GuidPointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            GuidPointer address4 = new GuidPointer(address1);
            Console.WriteLine("GuidPointer Address (from Int32): {0:X}", address4.ToInt32());
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
            Guid* sample = stackalloc Guid[4];
            GuidPointer a = new GuidPointer(sample);
            GuidPointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(Guid), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            GuidPointer c = new GuidPointer(sample + 1);
            GuidPointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
