using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_07
    {
        public static void Run()
        {
          Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một ký tự");
            char kyTu = char.Parse(Console.ReadLine());
            int ascii = (int)kyTu;
            Console.WriteLine("Giá trị ASCII của '" + kyTu + "' là: " + ascii);
            Console.ReadKey();
        }
    }
}

