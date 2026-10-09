using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi9
{
    internal class BTVNBuoi9
    {
        public static void Bai1()
        {
            string path = "blank.txt";

            File.Create(path).Close();

            Console.WriteLine("Da tao file trong thanh cong!");
        }

        public static void Bai2()
        {
            string path = "blank.txt";

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
            string noiDung = Console.ReadLine();

            File.WriteAllText(path, noiDung);

            Console.WriteLine("Da ghi file thanh cong!");
        }

        public static void Bai4()
        {
            string path = "data.txt";

            Console.Write("Nhap noi dung: ");
            string noiDung = Console.ReadLine();

            File.WriteAllText(path, noiDung);

            string ketQua = File.ReadAllText(path);

            Console.WriteLine("Noi dung file:");
            Console.WriteLine(ketQua);
        }

        public static void Bai5()
        {
            string path = "array.txt";

            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap dong thu " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }

            File.WriteAllLines(path, a);

            Console.WriteLine("Da ghi mang chuoi vao file!");
        }

        public static void Bai6()
        {
            string path = "data.txt";

            Console.Write("Nhap noi dung muon them: ");
            string noiDung = Console.ReadLine();

            File.AppendAllText(path, noiDung + Environment.NewLine);

            Console.WriteLine("Da them noi dung vao file!");
        }

        public static void Bai7()
        {
            string source = "data.txt";
            string destination = "copy.txt";

            if (File.Exists(source))
            {
                File.Copy(source, destination, true);

                string noiDung = File.ReadAllText(destination);

                Console.WriteLine("Noi dung file copy:");
                Console.WriteLine(noiDung);
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

                Console.WriteLine("Da doi ten file thanh cong!");
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
                    string line = sr.ReadLine();

                    if (line != null)
                    {
                        Console.WriteLine("Dong dau tien: " + line);
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
            string path = "lastline.txt";

            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap dong thu " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }

            File.WriteAllLines(path, a);

            string[] lines = File.ReadAllLines(path);

            if (lines.Length > 0)
            {
                Console.WriteLine("Dong cuoi cung: " + lines[lines.Length - 1]);
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

                Console.Write("Nhap so dong cuoi muon doc: ");
                int n = int.Parse(Console.ReadLine());

                if (n > lines.Length)
                {
                    n = lines.Length;
                }

                if (n < 0)
                {
                    n = 0;
                }

                Console.WriteLine("Cac dong cuoi:");

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

                Console.Write("Nhap dong can doc: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 1 && n <= lines.Length)
                {
                    Console.WriteLine("Noi dung dong " + n + ":");
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


        // HÀM PHỤ
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
                Console.WriteLine("Cau truc folder:");

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
                int kyTuDacBiet = 0;

                
                int[] demKyTu = new int[65536];

                
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < maxLength; j++)
                    {
                        char c = a[i, j];

                        
                        if (j >= lines[i].Length)
                        {
                            continue;
                        }

                        demKyTu[c]++;

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
                            kyTuDacBiet++;
                        }
                    }
                }

                Console.WriteLine("===== THONG KE FILE =====");
                Console.WriteLine("Tong chu cai = " + chuCai);
                Console.WriteLine("Tong chu so = " + chuSo);
                Console.WriteLine("Tong ky tu khac = " + kyTuDacBiet);

                Console.WriteLine();
                Console.WriteLine("===== SO LAN XUAT HIEN =====");

                for (int i = 0; i < demKyTu.Length; i++)
                {
                    if (demKyTu[i] > 0)
                    {
                        if (i == ' ')
                        {
                            Console.WriteLine(
                                "Khoang trang: " + demKyTu[i]
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                "'" + (char)i + "' : " + demKyTu[i]
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
