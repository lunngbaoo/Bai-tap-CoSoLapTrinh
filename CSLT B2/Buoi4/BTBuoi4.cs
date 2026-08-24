using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi4
{
    internal class BTBuoi4
    {
        public static void BT1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
            Console.ReadKey();
        }
        public static void BT2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BẢNG GIÁ TRỊ CỦA HÀM SỐ: x = y^2 + 2y + 1");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("{0,10} | {1,10}", "y", "x");
            Console.WriteLine("-----------------------------------------");

           
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("{0,10} | {1,10}", y, x);
            }
            Console.ReadKey();
        }
        public static void BT3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập quãng đường (km): ");
            double distanceKm = double.Parse(Console.ReadLine());
            Console.Write("Nhập số giờ: ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Nhập số phút: ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("Nhập số giây: ");
            double seconds = double.Parse(Console.ReadLine());          
            double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);           
            double distanceMiles = distanceKm * 0.621371;
            double speedKmh = distanceKm / totalHours;
            double speedMilesh = distanceMiles / totalHours;
            Console.WriteLine("\n--- KẾT QUẢ ---");
            Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h");
            Console.WriteLine($"Vận tốc: {speedMilesh:F2} miles/h");
            Console.ReadKey();
        }
        public static void BT4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập bán kính hình cầu");
            double banKinh = double.Parse(Console.ReadLine());
            double dienTich = 4 * Math.PI * banKinh * banKinh;
            Console.WriteLine("Diện tích mặt cầu là: " + dienTich);
            double theTich = 4 / 3 * Math.PI * banKinh * banKinh * banKinh;
            Console.WriteLine("Thể tích mặt cầu là: " + theTich);
            Console.ReadKey();
        }
        public static void BT5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một ký tự: ");
            char ch = char.Parse(Console.ReadLine());
            char lowerCh = char.ToLower(ch);
            if (lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u')
            {
                Console.WriteLine($"Ký tự '{ch}' là một NGUYÊN ÂM.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"Ký tự '{ch}' là một CHỮ SỐ.");
            }
            else
            {
                Console.WriteLine($"Ký tự '{ch}' là KÝ TỰ KHÁC / BIỂU TƯỢNG.");
            }
            Console.ReadKey();
        }
        public static void giaiPTBac2()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Nhập hệ số a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c:");
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình bậc 1 có 1 nghiệm: x = {x:F2}");
                }
            }
            else
            {                 
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x:F2}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"x1 = {x1:F2}");
                    Console.WriteLine($"x2 = {x2:F2}");
                }
            }

            Console.ReadKey();
        }
        
    }
}
