using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_04
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị của feet:");
            float feet = float.Parse(Console.ReadLine());
            float meters = feet * 0.3048f;
            Console.WriteLine("Giá trị tương ứng trong mét là: " + meters);
            Console.ReadKey();
        }
    }
}

