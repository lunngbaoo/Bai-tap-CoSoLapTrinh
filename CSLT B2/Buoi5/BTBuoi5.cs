using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi5
{
    internal class BTBuoi5
    {
        public static void Bai1()
        {
            //1. Máy tính nghĩ ngẫu nhiên 1 số
            // 2. Hỏi người dùng đoán số
            // 3. Nếu người dùng đoán số đúng thì thông báo 
            // nếu người dùng đoán nhỏ/lớn hơn thì thông báo tương tự
            Console.OutputEncoding = Encoding.UTF8;
            //1. Máy tính nghĩ ngẫu nhiên 1 số
            Random rnd = new Random();
            int con_num = rnd.Next(10) + 1;
            // 2. Hỏi người dùng đoán số
            Console.WriteLine("Bạn đoán số mấy? ");
            int user_num = int.Parse(Console.ReadLine());
            //3. so sánh đáp án
            if (user_num == con_num)
            {
                Console.WriteLine("Bạn đoán đúng rồi");
            }
            else if (user_num < con_num)
            { Console.WriteLine("Bạn đoán số nhỏ hơn máy nghĩ"); }
            else { Console.WriteLine("Bạn đoán số lớn hơn máy nghĩ"); }
            Console.ReadKey();
        }
        public static void Bai2()
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
            Console.ReadKey();
        }

        public static void Bai3()
        {
            double tong = 0;
            double so;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Nhap so thu " + i + ": ");
                so = double.Parse(Console.ReadLine());

                tong = tong + so;
            }

            double trungBinh = tong / 10;

            Console.WriteLine("Tong = " + tong);
            Console.WriteLine("Trung binh = " + trungBinh);
            Console.ReadKey();
        }
        public static void Bai4()
        {

            int n;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }

        public static void Bai5()
        {
            int n;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            // Pattern 1
            Console.WriteLine("\nPattern 1:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            // Pattern 2
            Console.WriteLine("\nPattern 2:");

            int so = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(so + " ");
                    so++;
                }

                Console.WriteLine();
            }

            // Pattern 3
            Console.WriteLine("\nPattern 3:");

            so = 1;

            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                // In số
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(so + " ");
                    so++;
                }

                Console.WriteLine();
            }
        }
        public static void Bai6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            double tong = 0;

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/" + i);

                if (i < n)
                {
                    Console.Write(" + ");
                }

                tong = tong + 1.0 / i;
            }

            Console.WriteLine();
            Console.WriteLine("Tong = " + tong);
        }
        public static void Bai7()
        {
            int a, b;

            Console.Write("Nhap so dau: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cuoi: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so hoan hao trong khoang la:");

            for (int n = a; n <= b; n++)
            {
                int tong = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong = tong + i;
                    }
                }

                if (tong == n)
                {
                    Console.WriteLine(n);
                }
            }
        }

    }
}
