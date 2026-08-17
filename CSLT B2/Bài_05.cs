using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_05
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hãy nhập nhiệt độ theo độ C:");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = celsius * 1.8f + 32;
            Console.WriteLine("Nhiệt độ tương ứng theo độ F là: " + fahrenheit);

            Console.WriteLine("Hãy nhập nhiệt độ theo độ F:");
            fahrenheit = float.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) / 1.8f;
            Console.WriteLine("Nhiệt độ tương ứng theo độ C là: " + celsius);
            Console.ReadKey();
        }
    }
}

