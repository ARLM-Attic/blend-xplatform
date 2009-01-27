using System;
using System.IO;

namespace msvcrt_test
{
    class Program
    {
        static void Main(string[] args)
        {
            msvcrt.printf("%d %f\r\n", 30, 44.03);

            Console.Read();
        }
    }
}
