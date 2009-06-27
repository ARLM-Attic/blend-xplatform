using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class PointerTest : AssertionHelper
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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
            Pointer<byte> pointer = new Pointer<byte>((void*)sample);
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

            Pointer<byte> address3 = new Pointer<byte>(address2);
            Console.WriteLine("Pointer<byte> Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            Pointer<byte> address4 = new Pointer<byte>(address1);
            Console.WriteLine("Pointer<byte> Address (from Int32): {0:X}", address4.ToInt32());
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
            Pointer<byte> a = new Pointer<byte>((void*)sample);
            Pointer<byte> b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(byte), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            Pointer<byte> c = new Pointer<byte>((void*)(sample + 1));
            Pointer<byte> d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
