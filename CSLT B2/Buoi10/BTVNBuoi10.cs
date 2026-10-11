using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi10
{
    internal class BTVNBuoi10
    {
        public static void Bai1()
        {
            string path = "data.txt";

            File.Create(path).Close();

            Console.WriteLine("Da tao file trong!");
        }
        public static void Bai2()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Da xoa file!");
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }
        public static void Bai3()
        {
            string path = "data.txt";

            Console.Write("Nhap noi dung: ");
            string s = Console.ReadLine();

            File.WriteAllText(path, s);

            Console.WriteLine("Da ghi file!");
        }
        public static void Bai4()
        {
            string path = "data.txt";

            Console.Write("Nhap noi dung: ");
            string s = Console.ReadLine();

            File.WriteAllText(path, s);

            string ketQua = File.ReadAllText(path);

            Console.WriteLine("Noi dung file:");
            Console.WriteLine(ketQua);
        }

        public static void Bai5()
        {
            string path = "data.txt";

            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap dong " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }

            File.WriteAllLines(path, a);

            Console.WriteLine("Da ghi mang vao file!");
        }

        public static void Bai6()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                Console.Write("Nhap noi dung muon them: ");
                string s = Console.ReadLine();

                File.AppendAllText(path, Environment.NewLine + s);

                Console.WriteLine("Da them noi dung!");
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }
        public static void Bai7()
        {
            string source = "data.txt";
            string destination = "copy.txt";

            if (File.Exists(source))
            {
                File.Copy(source, destination, true);

                string s = File.ReadAllText(destination);

                Console.WriteLine("Noi dung file copy:");
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("File nguon khong ton tai!");
            }
        }

        public static void Bai8()
        {
            string oldName = "data.txt";
            string newName = "newdata.txt";

            if (File.Exists(oldName))
            {
                File.Move(oldName, newName);

                Console.WriteLine("Da doi ten file!");
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }

        public static void Bai9()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string s = sr.ReadLine();

                    if (s != null)
                    {
                        Console.WriteLine("Dong dau tien: " + s);
                    }
                    else
                    {
                        Console.WriteLine("File rong!");
                    }
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }
        public static void Bai10()
        {
            string path = "data.txt";

            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap dong " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }

            File.WriteAllLines(path, a);

            string[] lines = File.ReadAllLines(path);

            if (lines.Length > 0)
            {
                Console.WriteLine("Dong cuoi: " + lines[lines.Length - 1]);
            }
            else
            {
                Console.WriteLine("File rong!");
            }
        }

        public static void Bai11()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.Write("Nhap n: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    n = 0;
                }

                if (n > lines.Length)
                {
                    n = lines.Length;
                }

                for (int i = lines.Length - n; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }

        public static void Bai12()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.Write("Nhap so dong can doc: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 1 && n <= lines.Length)
                {
                    Console.WriteLine(lines[n - 1]);
                }
                else
                {
                    Console.WriteLine("So dong khong hop le!");
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }

        public static void Bai13()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                Console.WriteLine("Tong so dong = " + lines.Length);
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }
        // HAM PHU
        public static void PrintFolder(string path, int level)
        {
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(
                    new string(' ', level * 4) +
                    Path.GetFileName(files[i])
                );
            }

            for (int i = 0; i < folders.Length; i++)
            {
                Console.WriteLine(
                    new string(' ', level * 4) +
                    Path.GetFileName(folders[i])
                );

                PrintFolder(folders[i], level + 1);
            }
        }
        public static void Bai14()
        {
            Console.Write("Nhap duong dan folder: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                Console.WriteLine(Path.GetFileName(path));

                PrintFolder(path, 1);
            }
            else
            {
                Console.WriteLine("Folder khong ton tai!");
            }
        }

        public static void Bai15()
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

     
                int maxLength = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length > maxLength)
                    {
                        maxLength = lines[i].Length;
                    }
                }

                char[,] a = new char[lines.Length, maxLength];

                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        a[i, j] = lines[i][j];
                    }
                }

                int chuCai = 0;
                int chuSo = 0;
                int kyTuKhac = 0;

                int[] dem = new int[65536];

                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        char c = a[i, j];

                        dem[c]++;

                        if (char.IsLetter(c))
                        {
                            chuCai++;
                        }
                        else if (char.IsDigit(c))
                        {
                            chuSo++;
                        }
                        else
                        {
                            kyTuKhac++;
                        }
                    }
                }

                Console.WriteLine("===== THONG KE =====");

                Console.WriteLine("Tong chu cai = " + chuCai);
                Console.WriteLine("Tong chu so = " + chuSo);
                Console.WriteLine("Tong ky tu khac = " + kyTuKhac);

                Console.WriteLine();
                Console.WriteLine("===== CHI TIET TUNG KY TU =====");

                for (int i = 0; i < dem.Length; i++)
                {
                    if (dem[i] > 0)
                    {
                        if (i == ' ')
                        {
                            Console.WriteLine(
                                "Khoang trang: " + dem[i]
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                (char)i + " xuat hien " + dem[i] + " lan"
                            );
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File khong ton tai!");
            }
        }
    }
}
