using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_03
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập số đầu tiên:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập số thứ hai:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tích của hai số là: " + (num1 * num2));
            Console.ReadKey();
        }
    }
}
