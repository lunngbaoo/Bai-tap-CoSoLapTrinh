using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_09
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập cạnh hình vuông:");
            float canh = float.Parse(Console.ReadLine());
            float dienTich = canh * canh;
            Console.WriteLine("Diện tích của hình vuông là: " + dienTich + " m2");
            Console.ReadKey();
        }
    }
}

