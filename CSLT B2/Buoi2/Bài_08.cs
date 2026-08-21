using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_08
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập bán kính của hình tròn:");
            float banKinh = float.Parse(Console.ReadLine());
            float dienTich = (float)3.14 * banKinh * banKinh;
            Console.WriteLine("Diện tích của hình tròn là: " + dienTich + " m2");
            Console.ReadKey();
        }
    }
}

