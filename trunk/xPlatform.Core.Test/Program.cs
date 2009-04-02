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
            const string targetString = "안녕하세요.";

            using (GlobalHeapAnsiString str = new GlobalHeapAnsiString(targetString))
            {
                size_t len = msvcrt.strlen(str.Address);
                Console.WriteLine("String: \"{0}\", ANSI Length: {1}", targetString, len);

                BytePointer ptr = new BytePointer(str.Address);

                for (size_t i = (size_t)0u; i < len; i++, ptr++)
                    Console.Write("{0} ", ptr.GetData().ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            using (GlobalHeapUnicodeString str = new GlobalHeapUnicodeString(targetString))
            {
                size_t len = msvcrt.wcslen(str.Address);
                Console.WriteLine("String: \"{0}\", Unicode Length: {1}", targetString, len);

                WideCharPointer ptr = new WideCharPointer(str.Address);

                for (size_t i = (size_t)0u; i < len; i++)
                    Console.Write("{0} ", (ptr + (int)i).GetData().ToString());
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
