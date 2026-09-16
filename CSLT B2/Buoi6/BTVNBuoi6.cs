using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi6
{
    internal class BTVNBuoi6
    {
        #region Bài 1: Tính tổng hai số nguyên
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        public static void Bai1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 1: TÍNH TỔNG HAI SỐ NGUYÊN ---");
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tổng của {a} và {b} là: {TinhTong(a, b)}");
        }
        #endregion

        #region Bài 2: Kiểm tra số chẵn lẻ
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        public static void Bai2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 2: KIỂM TRA SỐ CHẴN LẺ ---");
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            if (KiemTraChan(n))
                Console.WriteLine($"{n} là số CHẴN.");
            else
                Console.WriteLine($"{n} là số LẺ.");
        }
        #endregion

        #region Bài 3: Tìm số lớn nhất trong ba số
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static void Bai3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 3: TÌM SỐ LỚN NHẤT TRONG BA SỐ ---");
            Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c: "); int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Số lớn nhất là: {TimMax(a, b, c)}");
        }
        #endregion

        #region Bài 4: Tính giai thừa của một số
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        public static void Bai4()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 4: TÍNH GIAI THỪA ---");
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}! = {TinhGiaiThua(n)}");
        }
        #endregion

        #region Bài 5: Đảo ngược chuỗi ký tự
        public static string DaoNguocChuoi(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Bai5()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 5: ĐẢO NGUỢC CHUỖI ---");
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine();

            Console.WriteLine($"Chuỗi đảo ngược: {DaoNguocChuoi(str)}");
        }
        #endregion

        #region Bài 6: Kiểm tra số nguyên tố
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Bai6()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 6: KIỂM TRA SỐ NGUYÊN TỐ ---");
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input: {n} -> Output: {KiemTraNguyenTo(n)}");
        }
        #endregion

        #region Bài 7: In dãy Fibonacci
        public static void InFibonacci(int n)
        {
            if (n <= 0) return;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

        public static void Bai7()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 7: IN DÃY FIBONACCI ---");
            Console.Write("Nhập số lượng phần tử (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Dãy Fibonacci: ");
            InFibonacci(n);
        }
        #endregion

        #region Bài 8: Đếm số lượng nguyên âm trong chuỗi
        public static int DemNguyenAm(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int count = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (nguyenAm.Contains(c)) count++;
            }
            return count;
        }

        public static void Bai8()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 8: ĐẾM NGUYÊN ÂM ---");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Số lượng nguyên âm: {DemNguyenAm(s)}");
        }
        #endregion

        #region Bài 9: Tính lũy thừa (không dùng Math.Pow)
        public static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1.0;
            int exponent = Math.Abs(y);

            for (int i = 0; i < exponent; i++)
            {
                ketQua *= x;
            }

            return y < 0 ? 1.0 / ketQua : ketQua;
        }

        public static void Bai9()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 9: TÍNH LŨY THỪA ---");
            Console.Write("Nhập cơ số x: "); double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ y: "); int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả {x}^{y} = {TinhLuyThua(x, y)}");
        }
        #endregion

        #region Bài 10: Tính điểm trung bình của mảng
        public static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            double tong = 0;
            foreach (int num in arr) tong += num;
            return tong / arr.Length;
        }

        public static void Bai10()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 10: TRUNG BÌNH MẢNG ---");
            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine($"Mảng mẫu [4, 5, 6, 7] -> Điểm trung bình: {TinhTrungBinh(arr)}");
        }
        #endregion

        #region Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
        public static bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;
                left++;
                right--;
            }
            return true;
        }

        public static void Bai11()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 11: KIỂM TRA PALINDROME ---");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuỗi đối xứng: {KiemTraDoiXung(s)}");
        }
        #endregion

        #region Bài 12: Chuyển đổi nhiệt độ Celsius sang Fahrenheit
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9.0 / 5.0) + 32;
        }

        public static void Bai12()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 12: CHUYỂN ĐỘ C SANG ĐỘ F ---");
            Console.Write("Nhập độ C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{c}°C = {CelsiusToFahrenheit(c)}°F");
        }
        #endregion

        #region Bài 13: Tìm giá trị nhỏ nhất trong mảng
        public static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new ArgumentException("Mảng rỗng!");
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        public static void Bai13()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 13: TÌM MIN MẢNG ---");
            int[] arr = { 10, 5, 8, 2, 9 };
            Console.WriteLine($"Mảng [10, 5, 8, 2, 9] -> Giá trị nhỏ nhất: {TimMin(arr)}");
        }
        #endregion

        #region Bài 14: Tính tổng các chữ số của một số nguyên
        public static int TongCacChuSo(int n)
        {
            int temp = Math.Abs(n);
            int tong = 0;
            while (temp > 0)
            {
                tong += temp % 10;
                temp /= 10;
            }
            return tong;
        }

        public static void Bai14()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 14: TỔNG CÁC CHỮ SỐ ---");
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng chữ số của {n} = {TongCacChuSo(n)}");
        }
        #endregion

        #region Bài 15: Sắp xếp mảng tăng dần
        public static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Bai15()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 15: SẮP XẾP MẢNG TĂNG DẦN ---");
            int[] arr = { 3, 1, 4, 2 };
            Console.Write("Mảng sau sắp xếp: ");
            SapXepMang(arr);
        }
        #endregion

        #region Bài 16: Xóa ký tự trùng lặp
        public static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }
            return ketQua;
        }

        public static void Bai16()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 16: XÓA KÝ TỰ TRÙNG LẶP ---");
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Kết quả: {XoaTrungLap(s)}");
        }
        #endregion

        #region Bài 17: Tìm ước chung lớn nhất (UCLN - Thuật toán Euclid)
        public static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static void Bai17()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 17: UCLN (EUCLID) ---");
            Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
        }
        #endregion

        #region Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        public static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            return Convert.ToString(n, 2);
        }

        public static void Bai18()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 18: THẬP PHÂN SANG NHỊ PHÂN ---");
            Console.Write("Nhập số thập phân n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuỗi nhị phân: {DecimalToBinary(n)}");
        }
        #endregion

        #region Bài 19: Kiểm tra năm nhuận
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        public static void Bai19()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 19: KIỂM TRA NĂM NHUẬN ---");
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Năm {year} là năm nhuận: {KiemTraNamNhuan(year)}");
        }
        #endregion

        #region Bài 20: Đếm số từ trong câu
        public static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static void Bai20()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- BÀI 20: ĐẾM SỐ TỪ TRONG CÂU ---");
            Console.Write("Nhập câu: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Số từ: {DemSoTu(sentence)}");
        }
        #endregion
    }
}
