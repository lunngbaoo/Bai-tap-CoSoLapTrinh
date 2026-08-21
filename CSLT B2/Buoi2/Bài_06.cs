using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_06
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Kích thước của các kiểu dữ liệu:");

            Console.WriteLine("byte: " + sizeof(byte) + " byte");
            Console.WriteLine("short: " + sizeof(short) + " byte");
            Console.WriteLine("int: " + sizeof(int) + " byte");
            Console.WriteLine("long: " + sizeof(long) + " byte");

            Console.WriteLine("float: " + sizeof(float) + " byte");
            Console.WriteLine("double: " + sizeof(double) + " byte");
            Console.WriteLine("decimal: " + sizeof(decimal) + " byte");

            Console.WriteLine("char: " + sizeof(char) + " byte");

            Console.ReadKey();
        }
    }
}

