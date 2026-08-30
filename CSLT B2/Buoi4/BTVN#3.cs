using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi4
{
    internal class BTVN_3
    {
        public static void Bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
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
                Console.ReadKey();
            }
        }
            public static void Bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} là số chẵn (Even).");
            }
            else
            {
                Console.WriteLine($"{num} là số lẻ (Odd).");
            }
            Console.ReadKey();
        }
        public static void Bai3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số thứ nhất: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;

            if (num2 > max) max = num2;
            if (num3 > max) max = num3;

            Console.WriteLine($"Số lớn nhất là: {max}");
            Console.ReadKey();
        }

        public static void Bai4()
        {
            Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập cạnh a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh c: ");
                double c = double.Parse(Console.ReadLine());

                // Kiểm tra điều kiện 3 cạnh tạo thành tam giác
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        Console.WriteLine("Đây là tam giác đều (Equilateral).");
                    }
                    else if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Đây là tam giác cân (Isosceles).");
                    }
                    else
                    {
                        Console.WriteLine("Đây là tam giác thường (Scalene).");
                    }
                }
                else
                {
                    Console.WriteLine("Ba độ dài không thể tạo thành một tam giác!");
                }
                Console.ReadKey ();
            }
        public static void Bai5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x, y;

            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu nhat.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu tu.");
            }
            else
            {
                Console.WriteLine("Diem nam tren truc toa do.");
            }
            Console.ReadKey ();
        }
        }
    }
       
