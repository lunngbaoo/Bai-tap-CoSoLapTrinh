using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_01
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập số đầu tiên:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập số thứ hai:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng của hai số là: " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
