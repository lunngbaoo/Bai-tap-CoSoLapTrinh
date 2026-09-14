using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi6
{
    internal class BTBuoi6
    {
       
            static int Max3(int a, int b, int c)
            {
                int max = a;

                if (b > max)
                    max = b;

                if (c > max)
                    max = c;

                return max;
            }

            public static void Bai1()
            {
                Console.Write("Nhap a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhap b: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Nhap c: ");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("So lon nhat la: " + Max3(a, b, c));
            Console.ReadKey();
            }
        static int GiaiThua(int n)
        {
            int gt = 1;

            for (int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }

            return gt;
        }

        public static void Bai2()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n + "! = " + GiaiThua(n));
            Console.ReadKey();
        }
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static void Bai3()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (LaSoNguyenTo(n))
                Console.WriteLine(n + " la so nguyen to");
            else
                Console.WriteLine(n + " khong phai la so nguyen to");
            Console.ReadKey();
        }

        static bool LaSoNguyenTo1(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void InSoNguyenToNhoHon(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (LaSoNguyenTo1(i))
            {
                Console.Write(i + " ");
            }
        }
    }
        
        public static void Bai41()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so nguyen to nho hon " + n + " la:");
            InSoNguyenToNhoHon(n);
            Console.ReadKey();
        }
        static bool LaSoNguyenTo2(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void InNSoNguyenTo(int n)
        {
            int dem = 0;
            int i = 2;

            while (dem < n)
            {
                if (LaSoNguyenTo2(i))
                {
                    Console.Write(i + " ");
                    dem++;
                }

                i++;
            }
        }

         public static void Bai42()
        {
            Console.Write("Nhap N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine( n + " so nguyen to dau tien la:");
            InNSoNguyenTo(n);
            Console.ReadKey ();
        }
        static bool IsPerfect(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }

        public static void Bai5()
        {
            
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPerfect(n))
            {
                Console.WriteLine(n + " la so hoan hao");
            }
            else
            {
                Console.WriteLine(n + " khong phai la so hoan hao");
            }

            
            Console.WriteLine("Cac so hoan hao nho hon 1000:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
        static bool IsPangram(string s)
        {
            s = s.ToLower();

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!s.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static void Bai6()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            if (IsPangram(s))
            {
                Console.WriteLine("Day la Pangram");
            }
            else
            {
                Console.WriteLine("Day khong phai la Pangram");
            }
            Console.ReadKey ();
        }
    }
}
