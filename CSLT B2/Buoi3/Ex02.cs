using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi3
{
    internal class Ex02
    {
        public static void Bai1()
        {
            // Ex1: Tính tiền điện'
            Console.WriteLine("Bài 1");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chỉ số điện cũ:");
            decimal oldIndex = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số điện mới:");
            decimal newIndex = decimal.Parse(Console.ReadLine());
            if (newIndex < oldIndex)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            decimal a = newIndex - oldIndex;

            Console.WriteLine("Lượng điện tiêu thụ là: " + a + " kWh");

            decimal TienDienChuaThue;

            if (a <= 50)
            {
                TienDienChuaThue = a * 1806;
            }
            else if (a <= 100)
            {
                TienDienChuaThue = 50 * 1806
                                 + (a - 50) * 1866;
            }
            else if (a <= 200)
            {
                TienDienChuaThue = 50 * 1806
                                 + 50 * 1866
                                 + (a - 100) * 2167;
            }
            else if (a <= 300)
            {
                TienDienChuaThue = 50 * 1806
                                 + 50 * 1866
                                 + 100 * 2167
                                 + (a - 200) * 2729;
            }
            else
            {
                TienDienChuaThue = 50 * 1806
                                 + 50 * 1866
                                 + 100 * 2167
                                 + 100 * 2729
                                 + (a - 300) * 3050;
            }

            decimal vat = TienDienChuaThue * 0.08m;

            decimal TongThanhToan = TienDienChuaThue + vat;

            Console.WriteLine("Số tiền điện chưa thuế: " +
                TienDienChuaThue.ToString("#,##0") + " VNĐ");

            Console.WriteLine("Thuế VAT: " +
                vat.ToString("#,##0") + " VNĐ");

            Console.WriteLine("Tổng thanh toán: " +
                TongThanhToan.ToString("#,##0") + " VNĐ");
            Console.ReadKey();
        }
        public static void Bai2()
        {
            // Ex2: Hệ thống BMI
            Console.WriteLine("Bài 2");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao:");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng:");
            double canNang = double.Parse(Console.ReadLine());
            double BMI = Math.Round(canNang / (chieuCao * chieuCao), 2);
            Console.WriteLine("Chỉ số BMI của bạn:" + BMI);
            if (BMI < 18.5)
            {
                Console.WriteLine("Gầy");
            }
            else if (BMI >= 18.5 && BMI < 23)
            {
                Console.WriteLine("Bình thường");
            }
            else if (BMI >= 23 && BMI < 25)
            {
                Console.WriteLine(" Thừa cân");
            }
            else
            {
                Console.WriteLine("Béo phì");
            }
            double canNangToiThieu = Math.Round(18.5 * chieuCao * chieuCao, 2);
            double canNangToiDa = Math.Round(22.9 * chieuCao * chieuCao, 2);
            Console.WriteLine("Cân nặng lý tưởng của bạn nên từ " + canNangToiThieu + "kg" + " đến " + canNangToiDa + "kg");
            Console.ReadKey();
        }



        public static void Bai3()
        { //Ex3: Đổi tiền tệ
            Console.WriteLine("Bài 3");
            Console.OutputEncoding = Encoding.UTF8;
            decimal vnd;
            int chon;

            Console.Write("Nhập số tiền VNĐ: ");
            vnd = decimal.Parse(Console.ReadLine());

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            chon = int.Parse(Console.ReadLine());

            decimal phi = vnd * 0.005m;
            decimal tienDoi = vnd - phi;

            decimal tyGia = 0;

            switch (chon)
            {
                case 1:
                    tyGia = 25400;
                    break;

                case 2:
                    tyGia = 27200;
                    break;

                case 3:
                    tyGia = 165;
                    break;

                case 4:
                    tyGia = 32100;
                    break;

                default:
                    Console.WriteLine("Không có loại tiền này!");
                    return;
            }

            decimal tienNgoaiTe = tienDoi / tyGia;

            Console.WriteLine("Phí dịch vụ: " + phi + " VNĐ");
            Console.WriteLine("Số tiền VNĐ tính đổi: " + tienDoi + " VNĐ");
            Console.WriteLine("Số tiền nhận được: " + tienNgoaiTe);
            Console.ReadKey();
        }


        public static void Bai4()
        { //Ex4: Tính tuổi & đếm ngược sinh nhật
            Console.WriteLine("Bài 4");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                DateTime today = DateTime.Now.Date;

                int age = today.Year - birthDate.Year;
                if (birthDate.Date > today.AddYears(-age)) age--;

                int daysLived = (int)(today - birthDate).TotalDays;

                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
                if (nextBirthday < today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                int daysToNextBirthday = (int)(nextBirthday - today).TotalDays;

                Console.WriteLine($"\nTuổi hiện tại: {age} tuổi");
                Console.WriteLine($"Bạn đã sống tổng cộng: {daysLived:N0} ngày");
                Console.WriteLine($"Sinh nhật tiếp theo còn: {daysToNextBirthday} ngày nữa");
            }
            else
            {
                Console.WriteLine("Định dạng ngày không hợp lệ!");
            }
            Console.ReadKey();
        }


        public static void Bai5()
        {
            //Ex5: Quản lý điểm học phần & quy đổi GPA
            Console.WriteLine("Bài 5");
            Console.OutputEncoding = Encoding.UTF8;
            double diem1, diem2, diem3;
            int tc1, tc2, tc3;

            Console.Write("Nhập điểm Lập trình C#: ");
            diem1 = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tín chỉ Lập trình C#: ");
            tc1 = int.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Toán rời rạc: ");
            diem2 = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tín chỉ Toán rời rạc: ");
            tc2 = int.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Tiếng Anh: ");
            diem3 = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tín chỉ Tiếng Anh: ");
            tc3 = int.Parse(Console.ReadLine());

            double diemTB = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3)
                            / (tc1 + tc2 + tc3);

            char diemChu;
            double GPA;
            string xepLoai;

            if (diemTB >= 8.5)
            {
                diemChu = 'A';
                GPA = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (diemTB >= 7.0)
            {
                diemChu = 'B';
                GPA = 3.0;
                xepLoai = "Khá";
            }
            else if (diemTB >= 5.5)
            {
                diemChu = 'C';
                GPA = 2.0;
                xepLoai = "Trung bình";
            }
            else if (diemTB >= 4.0)
            {
                diemChu = 'D';
                GPA = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                GPA = 0.0;
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine("\n--- KẾT QUẢ ---");
            Console.WriteLine("Điểm TB Thang 10: " + diemTB.ToString("F2"));
            Console.WriteLine("Điểm Chữ Quy Đổi: " + diemChu);
            Console.WriteLine("Điểm GPA Thang 4: " + GPA);
            Console.WriteLine("Xếp Loại Học Lực: " + xepLoai);
            Console.ReadKey();
        }

        public static void Bai6()
        {
            //Ex6: Chuẩn hóa và tạo email
            Console.WriteLine("Bài 6");
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên thô: ");
            string hoTen = Console.ReadLine();

            hoTen = hoTen.Trim();

            string[] dsTen = hoTen.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            // Viết hoa chữ cái đầu
            for (int i = 0; i < dsTen.Length; i++)
            {
                dsTen[i] = dsTen[i].Substring(0, 1).ToUpper()
                         + dsTen[i].Substring(1).ToLower();
            }

            string hoTenChuan = string.Join(" ", dsTen);

            string ho = dsTen[0];
            string ten = dsTen[dsTen.Length - 1];

            string tenDem = "";

            for (int i = 1; i < dsTen.Length - 1; i++)
            {
                tenDem += dsTen[i];

                if (i < dsTen.Length - 2)
                {
                    tenDem += " ";
                }
            }

            string username = ten.ToLower() + ".";

            for (int i = 0; i < dsTen.Length - 1; i++)
            {
                username += dsTen[i].ToLower();
            }

            Console.WriteLine("Họ tên chuẩn hóa: " + hoTenChuan);
            Console.WriteLine("Họ: " + ho + " | Tên đệm: " + tenDem + " | Tên: " + ten);
            Console.WriteLine("Username tạo tự động: " + username);
            Console.WriteLine("Email cấp phát: " + username + "@company.edu.vn");
        Console.ReadKey();
        }


        public static void Bai7()
        {
            //Ex7: Lập kế hoạch
            Console.WriteLine("Bài 7");
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Quãng đường (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (L/100km): ");
            double consumptionRate = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal pricePerLiter = decimal.Parse(Console.ReadLine());
            Console.Write("Số người đi: ");
            int peopleCount = int.Parse(Console.ReadLine());

            double totalLiters = (distance / 100.0) * consumptionRate;
            decimal totalCost = (decimal)totalLiters * pricePerLiter;
            decimal costPerPersonRaw = totalCost / peopleCount;

            decimal costPerPerson = Math.Ceiling(costPerPersonRaw / 1000m) * 1000m;

            Console.WriteLine($"\nTổng nhiên liệu tiêu thụ: {totalLiters:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {totalCost:N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {costPerPerson:N0} VNĐ");
            Console.ReadKey();
        }
    }
}





