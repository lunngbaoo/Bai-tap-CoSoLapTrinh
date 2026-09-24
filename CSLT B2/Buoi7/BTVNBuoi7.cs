using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi7
{
    internal class BTVNBuoi7
    {
        // requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        public static void Bai1()
        {
            int[] arr = new int[10];

            Console.WriteLine("Nhap 10 so nguyen:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nMang sau khi sap xep:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        // Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
        public static void Bai2()
        {
            Console.Write("Nhap mot cau: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhap tu can tim: ");
            string word = Console.ReadLine();

            string[] words = sentence.Split(' ');

            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == word.ToLower())
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Tim thay tu " + word + " trong cau.");
            }
            else
            {
                Console.WriteLine("Khong tim thay tu " + word + " trong cau.");
            }

            Console.ReadKey();
        }

        //        Create a program with following functions
        //-Create an integer matrix N x M(N, M was prompted from user) randomly.
        //-Print the matrix.
        //-Print the ith row/column. (i was prompted from user)
        //-Find the max value of the matrix.
        //-Find the min value of ith row / col of the matrix.
        //-Transpose the matrix.
        //-Print the main / secondary diagonal values of the matrix.(square maxtrix)
        #region Bai3
        public static void Bai3()
        {
            // 1. Nhap N, M
            Console.Write("Nhap so dong N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());

            // 2. Tao ma tran ngau nhien
            int[,] matrix = new int[n, m];

            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rd.Next(1, 101);
                }
            }

            // 3. In ma tran
            Console.WriteLine("\nMa tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            // 4. In dong thu i
            Console.Write("\nNhap dong i can in: ");
            int row = int.Parse(Console.ReadLine());

            if (row >= 0 && row < n)
            {
                Console.WriteLine("Dong " + row + ":");

                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[row, j] + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Dong khong hop le!");
            }

            // 5. In cot thu i
            Console.Write("\nNhap cot i can in: ");
            int col = int.Parse(Console.ReadLine());

            if (col >= 0 && col < m)
            {
                Console.WriteLine("Cot " + col + ":");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(matrix[i, col]);
                }
            }
            else
            {
                Console.WriteLine("Cot khong hop le!");
            }

            // 6. Tim gia tri lon nhat
            int max = matrix[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("\nGia tri lon nhat cua ma tran: " + max);

            // 7. Tim min cua dong i
            Console.Write("\nNhap dong i de tim MIN: ");
            int minRow = int.Parse(Console.ReadLine());

            if (minRow >= 0 && minRow < n)
            {
                int min = matrix[minRow, 0];

                for (int j = 1; j < m; j++)
                {
                    if (matrix[minRow, j] < min)
                    {
                        min = matrix[minRow, j];
                    }
                }

                Console.WriteLine("Gia tri nho nhat cua dong " + minRow + ": " + min);
            }
            else
            {
                Console.WriteLine("Dong khong hop le!");
            }

            // 8. Tim min cua cot i
            Console.Write("\nNhap cot i de tim MIN: ");
            int minCol = int.Parse(Console.ReadLine());

            if (minCol >= 0 && minCol < m)
            {
                int min = matrix[0, minCol];

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, minCol] < min)
                    {
                        min = matrix[i, minCol];
                    }
                }

                Console.WriteLine("Gia tri nho nhat cua cot " + minCol + ": " + min);
            }
            else
            {
                Console.WriteLine("Cot khong hop le!");
            }

            // 9. Chuyen vi ma tran
            Console.WriteLine("\nMa tran chuyen vi:");

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            // 10. Duong cheo chinh va phu
            if (n == m)
            {
                Console.WriteLine("\nDuong cheo chinh:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, i] + " ");
                }

                Console.WriteLine("\nDuong cheo phu:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, n - 1 - i] + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nKhong the in duong cheo vi ma tran khong vuong.");
            }

            Console.ReadKey();
        }
        #endregion
    }
}
