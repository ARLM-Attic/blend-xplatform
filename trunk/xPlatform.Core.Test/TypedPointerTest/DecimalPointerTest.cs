﻿using System;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace xPlatform.Test.TypedPointerTest
{
    [TestFixture]
    public class DecimalPointerTest : AssertionHelper
    {
        private Random random = new Random();

        public decimal GenerateRandomNumber()
        {
            return (decimal)random.NextDouble();
        }

        [Test]
        public unsafe void StackallocTest1()
        {
            const int bufferSize = 4;
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

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
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

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
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

            for (int i = 0; i < bufferSize; i++)
                results[i] = *(sample + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(decimal*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void StackallocTest4()
        {
            const int bufferSize = 4;
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

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
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

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
            decimal* sample = stackalloc decimal[bufferSize];
            DecimalPointer pointer = new DecimalPointer(sample);
            decimal[] results = new decimal[bufferSize];

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
                results[i] = *(decimal*)(pointer + i) = GenerateRandomNumber();

            // Pointer conversion test
            for (int i = 0; i < bufferSize; i++)
            {
                object x = results[i];
                object y = *(decimal*)(pointer + i);
                Console.WriteLine("[{0}] <Left: {1}> {2} <Right: {3}>", i, x, x.Equals(y) ? "==" : "<>", y);
                Assert.AreEqual(x, y);
            }
        }

        [Test]
        public unsafe void SizeOfTest1()
        {
            decimal* sample = stackalloc decimal[4];

            int totalSize = 0;

            int ptrSize1 = Marshal.SizeOf(new DecimalPointer(sample));
            Console.WriteLine("Marshal.SizeOf(new DecimalPointer(...)): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = Marshal.SizeOf(typeof(DecimalPointer));
            Console.WriteLine("Marshal.SizeOf(typeof(DecimalPointer)): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = Marshal.SizeOf(IntPtr.Zero);
            Console.WriteLine("Marshal.SizeOf(Intptr.Zero): {0}", ptrSize3);
            totalSize += ptrSize3;

            int ptrSize4 = Marshal.SizeOf(typeof(IntPtr));
            Console.WriteLine("Marshal.SizeOf(typeof(IntPtr)): {0}", ptrSize4);
            totalSize += ptrSize4;

            int ptrSize5 = Marshal.SizeOf(typeof(decimal*));
            Console.WriteLine("Marshal.SizeOf(typeof(decimal*)): {0}", ptrSize5);
            totalSize += ptrSize5;

            Assert.AreEqual(totalSize, DecimalPointer.Size * 5);
        }

        [Test]
        public unsafe void SizeOfTest2()
        {
            decimal* sample = stackalloc decimal[4];

            int totalSize = 0;

            int ptrSize1 = sizeof(DecimalPointer);
            Console.WriteLine("sizeof(DecimalPointer): {0}", ptrSize1);
            totalSize += ptrSize1;

            int ptrSize2 = sizeof(IntPtr);
            Console.WriteLine("sizeof(IntPtr): {0}", ptrSize2);
            totalSize += ptrSize2;

            int ptrSize3 = sizeof(decimal*);
            Console.WriteLine("sizeof(decimal*): {0}", ptrSize3);
            totalSize += ptrSize3;

            Assert.AreEqual(totalSize, DecimalPointer.Size * 3);
        }

        [Test]
        public unsafe void EqualityTest1()
        {
            decimal* sample = stackalloc decimal[4];
            int checksum = 0;

            int address1 = (int)sample;
            Console.WriteLine("Original Address: {0:X}", address1);
            checksum += address1;

            IntPtr address2 = new IntPtr(sample);
            Console.WriteLine("IntPtr Address: {0:X}", address2.ToInt32());
            checksum += address2.ToInt32();

            DecimalPointer address3 = new DecimalPointer(address2);
            Console.WriteLine("DecimalPointer Address (from IntPtr): {0:X}", address3.ToInt32());
            checksum += address3.ToInt32();

            DecimalPointer address4 = new DecimalPointer(address1);
            Console.WriteLine("DecimalPointer Address (from Int32): {0:X}", address4.ToInt32());
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
            decimal* sample = stackalloc decimal[4];
            DecimalPointer a = new DecimalPointer(sample);
            DecimalPointer b = (a + 1);
            Console.WriteLine("Address offset: {0}", b.ToInt32() - a.ToInt32());

            Assert.AreEqual(sizeof(decimal), b.ToInt32() - a.ToInt32());
            Assert.False(Object.ReferenceEquals(a, b));

            // xPlatform's typed pointers are value type.
            DecimalPointer c = new DecimalPointer(sample + 1);
            DecimalPointer d = (++c);
            Console.WriteLine("Address offset: {0}", d.ToInt32() - c.ToInt32());

            Assert.AreEqual(0, d.ToInt32() - c.ToInt32());
            Assert.False(Object.ReferenceEquals(c, d));
        }
    }
}
