using System;
using xPlatform;
using xPlatform.Strings;
using xPlatform.x86.msvcrt;

namespace xPlatform.Core.Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            const string targetString = @"안녕하십니까?";

            using (GlobalHeapAnsiString str = new GlobalHeapAnsiString(targetString))
            {
                int len = (int)msvcrt.strlen(str.Address);
                Console.WriteLine("String: \"{0}\", ANSI Length: {1}", targetString, len);

                Pointer<byte> ptr = new Pointer<byte>(str.Address);

                for (int i = 0; i < len; i++)
                    Console.Write("{0} ", ptr[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            using (GlobalHeapUnicodeString str = new GlobalHeapUnicodeString(targetString))
            {
                int len = (int)msvcrt.wcslen(str.Address);
                Console.WriteLine("String: \"{0}\", Unicode Length: {1}", targetString, len);

                Pointer<char> ptr = new Pointer<char>(str.Address);

                for (int i = 0; i < len; i++)
                {
                    Console.Write("{0} ", ptr[i]);
                    ptr[i] = (char)((int)'가' + i);
                }

                Console.WriteLine();

                for (int i = 0; i < len; i++)
                    Console.Write("{0} ", ptr[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
