using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi7
{
    internal class BTBuoi7
    {
        public static void Bai1()
        {
            int[] arr = new int[10];

            Random rd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 21);
            }

            Console.WriteLine("Mang vua tao:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Bai2()
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.Write("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Tim thay " + x + " trong mang.");
            }
            else
            {
                Console.WriteLine("Khong tim thay " + x + " trong mang.");
            }
        }

        public static void Bai3() 
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.Write("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Index cua " + x + " la: " + index);
            }
            else
            {
                Console.WriteLine("Khong tim thay " + x);
            }
        }

        public static void Bai4()
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.WriteLine("Mang ban dau:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\nNhap gia tri can xoa: ");
            int x = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                int[] newArr = new int[arr.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    newArr[i] = arr[i];
                }

                for (int i = index; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i + 1];
                }

                arr = newArr;

                Console.WriteLine("Mang sau khi xoa:");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay " + x);
            }
        }
        
        public static void Bai5()
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.WriteLine("Mang:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("\nGia tri lon nhat: " + max);
            Console.WriteLine("Gia tri nho nhat: " + min);
        }

        public static void Bai6()
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.WriteLine("Mang ban dau:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // Dao mang
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine("\nMang sau khi dao:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Bai7()
        {
            int[] arr = { 5, 10, 15, 10, 20, 5, 25 };

            Console.WriteLine("Mang:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nCac gia tri bi trung:");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        break;
                    }
                }
            }
        }

        public static void Bai8()
        {
            int[] arr = { 5, 10, 15, 10, 20, 5, 25 };

            Console.WriteLine("Mang ban dau:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int[] newArr = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool trung = false;

                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == newArr[j])
                    {
                        trung = true;
                        break;
                    }
                }

                if (!trung)
                {
                    newArr[count] = arr[i];
                    count++;
                }
            }

            Console.WriteLine("\nMang sau khi xoa phan tu trung:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
    }
}
