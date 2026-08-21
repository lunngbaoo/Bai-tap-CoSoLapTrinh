using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi3
{
    internal class Ex01
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Ex1: Chuyển đổi nhiệt độ từ độ C sang độ F và K
            Console.WriteLine("Mời nhập nhiệt độ C:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 9/5 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("Nhiệt độ F là: " + fahrenheit);
            Console.WriteLine("Nhiệt độ K là: " + kelvin);

            //Ex2: Tính diện tích và thể tích của mặt cầu
            Console.WriteLine("Nhập bán kính mặt cầu:");
            double radius = double.Parse(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4/3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Diện tích mặt cầu là: " + surfaceArea);
            Console.WriteLine("Thể tích mặt cầu là: " + volume);

            //Ex3: Tính tổng, hiệu, tích, thương và phần dư của hai số a và b
            Console.WriteLine("Mời nhập số a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập số b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Tổng của a và b là: " + (a + b));
            Console.WriteLine("Hiệu của a và b là: " + (a - b));
            Console.WriteLine("Tích của a và b là: " + (a * b));
            Console.WriteLine("Thương của a và b là: " + (a / b));
            Console.WriteLine("Phần dư của a và b là: " + (a % b));

            Console.ReadKey();
        }
    }
}
    
