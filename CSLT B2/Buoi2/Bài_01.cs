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
            Console.WriteLine("Nhập giá trị của biến a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị của biến b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng của hai số là: " + (a + b));
        }
    }
}

