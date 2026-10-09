using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi8
{
    internal class BTVNBuoi8
    {
        public static void Bai1()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Chuoi vua nhap: " + s);
            Console.ReadKey();
        }
        public static void Bai2()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int dem = 0;

            foreach (char c in s)
            {
                dem++;
            }

            Console.WriteLine("Do dai chuoi = " + dem);
        }

        public static void Bai3()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Cac ky tu trong chuoi:");

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        public static void Bai4()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Chuoi dao nguoc:");

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        public static void Bai5()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int dem = 0;
            bool trongTu = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && s[i] != '\t')
                {
                    if (trongTu == false)
                    {
                        dem++;
                        trongTu = true;
                    }
                }
                else
                {
                    trongTu = false;
                }
            }
            Console.WriteLine("Tong so tu = " + dem);
        }

        public static void Bai6()
        {
            Console.Write("Nhap chuoi thu nhat: ");
            string s1 = Console.ReadLine();

            Console.Write("Nhap chuoi thu hai: ");
            string s2 = Console.ReadLine();

            bool giongNhau = true;

            if (s1.Length != s2.Length)
            {
                giongNhau = false;
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        giongNhau = false;
                        break;
                    }
                }
            }

            if (giongNhau == true)
            {
                Console.WriteLine("Hai chuoi giong nhau");
            }
            else
            {
                Console.WriteLine("Hai chuoi khac nhau");
            }
        }

        public static void Bai7()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int chuCai = 0;
            int chuSo = 0;
            int kyTuDacBiet = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    chuCai++;
                }
                else if (char.IsDigit(s[i]))
                {
                    chuSo++;
                }
                else
                {
                    kyTuDacBiet++;
                }
            }
            Console.WriteLine("So chu cai = " + chuCai);
            Console.WriteLine("So chu so = " + chuSo);
            Console.WriteLine("So ky tu dac biet = " + kyTuDacBiet);
        }
        public static void Bai8()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int nguyenAm = 0;
            int phuAm = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);

                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' ||
                        c == 'i' || c == 'o' || c == 'u')
                    {
                        nguyenAm++;
                    }
                    else
                    {
                        phuAm++;
                    }
                }
            }
            Console.WriteLine("So nguyen am = " + nguyenAm);
            Console.WriteLine("So phu am = " + phuAm);
        }

        public static void Bai9()
        {
            Console.Write("Nhap chuoi goc: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            bool timThay = false;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int dem = 0;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (s[i + j] == sub[j])
                    {
                        dem++;
                    }
                }

                if (dem == sub.Length)
                {
                    timThay = true;
                    break;
                }
            }

            if (timThay == true)
            {
                Console.WriteLine("Tim thay chuoi con");
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con");
            }
        }

        public static void Bai10()
        {
            Console.Write("Nhap chuoi goc: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            int viTri = -1;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int dem = 0;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (s[i + j] == sub[j])
                    {
                        dem++;
                    }
                }

                if (dem == sub.Length)
                {
                    viTri = i;
                    break;
                }
            }

            Console.WriteLine("Vi tri tim thay = " + viTri);
        }

        public static void Bai11()
        {
            Console.Write("Nhap chuoi goc: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            int viTri = -1;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int dem = 0;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (s[i + j] == sub[j])
                    {
                        dem++;
                    }
                }

                if (dem == sub.Length)
                {
                    viTri = i;
                    break;
                }
            }

            Console.WriteLine("Vi tri tim thay = " + viTri);
        }

        public static void Bai12()
        {
            Console.Write("Nhap chuoi goc: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            int dem = 0;

            if (sub.Length > 0)
            {
                for (int i = 0; i <= s.Length - sub.Length; i++)
                {
                    int demKyTu = 0;

                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (s[i + j] == sub[j])
                        {
                            demKyTu++;
                        }
                    }

                    if (demKyTu == sub.Length)
                    {
                        dem++;
                    }
                }
            }

            Console.WriteLine("So lan xuat hien = " + dem);
        }

        public static void Bai13()
        {
            Console.Write("Nhap chuoi goc: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi can tim: ");
            string tim = Console.ReadLine();

            Console.Write("Nhap chuoi muon chen: ");
            string chen = Console.ReadLine();

            int viTri = -1;

            for (int i = 0; i <= s.Length - tim.Length; i++)
            {
                int dem = 0;

                for (int j = 0; j < tim.Length; j++)
                {
                    if (s[i + j] == tim[j])
                    {
                        dem++;
                    }
                }

                if (dem == tim.Length)
                {
                    viTri = i;
                    break;
                }
            }

            if (viTri != -1)
            {
                string ketQua = "";

                for (int i = 0; i < viTri; i++)
                {
                    ketQua = ketQua + s[i];
                }

                ketQua = ketQua + chen;

                for (int i = viTri; i < s.Length; i++)
                {
                    ketQua = ketQua + s[i];
                }

                Console.WriteLine("Chuoi sau khi chen: " + ketQua);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi can chen truoc");
            }
        }
    }

}
