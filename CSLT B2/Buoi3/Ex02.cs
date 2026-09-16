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

        public static void Bai8()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string correctOtp = "839201";
            DateTime creationTime = DateTime.Now;

            Console.Write("Mã OTP nhận được: ");
            string inputOtp = Console.ReadLine()?.Trim();

            Console.Write("Thời gian trôi qua: ");
            string timeInput = Console.ReadLine();

            int secondsPassed = 135;
            int.TryParse(timeInput, out secondsPassed);

            bool isValidFormat = inputOtp != null && inputOtp.Length == 6 && int.TryParse(inputOtp, out _);

            bool isCorrectCode = inputOtp == correctOtp;

            bool isNotExpired = secondsPassed <= 300;

            Console.WriteLine("\nOUTPUT:");
            if (!isValidFormat)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Định dạng OTP không hợp lệ (phải gồm đúng 6 chữ số).");
            }
            else if (!isNotExpired)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Mã OTP đã hết hiệu lực (quá 5 phút).");
            }
            else if (!isCorrectCode)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Mã OTP không chính xác.");
            }
            else
            {
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG");
                Console.WriteLine("Giao dịch đã được phê duyệt.");
            }
            Console.ReadKey();
        }
        
        public static void Bai9()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Lương Gross (VNĐ): ");
            decimal gross = decimal.Parse(Console.ReadLine());

            Console.Write("Số người phụ thuộc: ");
            int dependents = int.Parse(Console.ReadLine());

            decimal insurance = gross * 0.105m;

            decimal selfDeduction = 11000000m;
            decimal dependentDeduction = dependents * 4400000m;

            decimal taxableIncome = gross - insurance - selfDeduction - dependentDeduction;
            if (taxableIncome < 0) taxableIncome = 0;

            decimal pit = 0m;
            if (taxableIncome > 0)
            {
                if (taxableIncome <= 5000000m) pit = taxableIncome * 0.05m;
                else if (taxableIncome <= 10000000m) pit = taxableIncome * 0.10m - 250000m;
                else if (taxableIncome <= 18000000m) pit = taxableIncome * 0.15m - 750000m;
                else if (taxableIncome <= 32000000m) pit = taxableIncome * 0.20m - 1650000m;
                else if (taxableIncome <= 52000000m) pit = taxableIncome * 0.25m - 3250000m;
                else if (taxableIncome <= 80000000m) pit = taxableIncome * 0.30m - 5850000m;
                else pit = taxableIncome * 0.35m - 9850000m;
            }

            decimal net = gross - insurance - pit;

            Console.WriteLine($"\nGiảm trừ Bảo hiểm (10.5%): {insurance:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {taxableIncome:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {pit:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {net:N0} VNĐ");
            Console.ReadKey();
        }

        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued
        }
        public static void Bai10()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string productId = "KB-09";
            string productName = "Bàn phím Cơ Akko";
            int? quantity = null;
            int minThreshold = 10;
            DateTime? restockDate = null;

            int displayQuantity = quantity ?? 0;

            StockStatus status;
            if (quantity == null || quantity == 0)
            {
                status = StockStatus.OutOfStock;
            }
            else if (quantity < minThreshold)
            {
                status = StockStatus.LowStock;
            }
            else
            {
                status = StockStatus.InStock;
            }

            string restockText = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập";

            Console.WriteLine($"Sản phẩm: {productName} (Mã: {productId})");
            Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.Value.ToString() : "null (Chưa kiểm kê)")}");
            Console.WriteLine($"Restock Date: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");
            Console.WriteLine("\nOUTPUT:");
            Console.WriteLine($"Số lượng hiển thị: {displayQuantity} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
            Console.WriteLine($"Trạng thái kho: {status} (Hết hàng)");
            Console.WriteLine($"Dự kiến nhập hàng: {restockText}");
            Console.ReadKey();
        }
        public static void Bai11()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Số tiền gửi (VNĐ): ");
            decimal P = decimal.Parse(Console.ReadLine());
            Console.Write("Lãi suất năm (%): ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Thời gian gửi (tháng): ");
            int n = int.Parse(Console.ReadLine());


            decimal simpleInterest = P * (decimal)(r / 100.0) * (n / 12.0m);

            double pDouble = (double)P;
            double compoundAmountDouble = pDouble * Math.Pow(1.0 + (r / 100.0) / 12.0, n);
            decimal compoundInterest = (decimal)compoundAmountDouble - P;

            decimal diff = compoundInterest - simpleInterest;

            Console.WriteLine($"\nTổng tiền lãi (Lãi đơn): {simpleInterest:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {compoundInterest:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {diff:N0} VNĐ (Lãi kép tối ưu hơn)");
            Console.ReadKey();
        }
        public static void Bai12()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Văn bản gốc: ");
            string rawText = Console.ReadLine();
            Console.Write("Khóa dịch chuyển (k): ");
            int k = int.Parse(Console.ReadLine());

            string encrypted = CaesarShift(rawText, k);
            string decrypted = CaesarShift(encrypted, -k);

            Console.WriteLine($"\nVăn bản Mã hóa: {encrypted}");
            Console.WriteLine($"Văn bản Giải mã: {decrypted}");
        }

        private static string CaesarShift(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];
                if (char.IsUpper(c))
                {
                    int offset = (c - 'A' + shift) % 26;
                    if (offset < 0) offset += 26;
                    buffer[i] = (char)('A' + offset);
                }
                else if (char.IsLower(c))
                {
                    int offset = (c - 'a' + shift) % 26;
                    if (offset < 0) offset += 26;
                    buffer[i] = (char)('a' + offset);
                }
            }
            return new string(buffer);
        }
        enum VehicleType { Motorbike, Car, Truck }
        public static void Bai13()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Loại xe (0-Motorbike, 1-Car, 2-Truck): ");
            VehicleType type = (VehicleType)int.Parse(Console.ReadLine());

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            double totalHours = (checkOut - checkIn).TotalHours;
            int billedHours = (int)Math.Ceiling(totalHours);

            decimal first2HoursFee = 0m;
            decimal nextHourRate = 0m;

            switch (type)
            {
                case VehicleType.Motorbike:
                    first2HoursFee = 5000m;
                    nextHourRate = 2000m;
                    break;
                case VehicleType.Car:
                    first2HoursFee = 20000m;
                    nextHourRate = 10000m;
                    break;
                case VehicleType.Truck:
                    first2HoursFee = 50000m;
                    nextHourRate = 25000m;
                    break;
            }

            decimal parkingFee = first2HoursFee;
            decimal extraFee = 0m;

            if (billedHours > 2)
            {
                extraFee = (billedHours - 2) * nextHourRate;
                parkingFee += extraFee;
            }

            decimal overnightFee = 0m;
            if (checkOut.Date > checkIn.Date)
            {
                overnightFee = 30000m;
            }

            decimal totalPayment = parkingFee + overnightFee;

            Console.WriteLine($"\nTổng thời gian đỗ: {totalHours:F2} giờ -> Tính phí: {billedHours} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {first2HoursFee:N0} VNĐ");
            if (billedHours > 2)
            {
                Console.WriteLine($"Phí {billedHours - 2} giờ tiếp theo: {extraFee:N0} VNĐ ({nextHourRate:N0} x {billedHours - 2})");
            }
            if (overnightFee > 0)
            {
                Console.WriteLine($"Phụ phí qua đêm: {overnightFee:N0} VNĐ");
            }
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {totalPayment:N0} VNĐ");
        }

        public static void Bai14()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chuỗi số: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {num}");

                bool fitsByte = num >= byte.MinValue && num <= byte.MaxValue;
                Console.WriteLine($"Phù hợp kiểu byte: {(fitsByte ? "CÓ (Vừa vặn trong dải 0-255)" : "KHÔNG")}");

                int sumDigits = 0;
                int temp = Math.Abs(num);
                while (temp > 0)
                {
                    sumDigits += temp % 10;
                    temp /= 10;
                }
                Console.WriteLine($"Tổng các chữ số: {sumDigits}");

                try
                {
                    checked
                    {
                        int overflowTest = num * 10000000; 
                        Console.WriteLine("Kiểm tra Tràn số: An toàn trong phạm vi int32.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Kiểm tra Tràn số: Phát hiện ngoại lệ OverflowException (Tràn số trong khối checked)!");
                }
            }
            else
            {
                Console.WriteLine("Lỗi: Chuỗi nhập vào không phải là số nguyên hợp lệ!");
            }
        }
        enum CustomerType { Child, Student, Adult, Senior }
        public static void Bai15()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal basePrice = 100000m;

            // Nhập loại khách hàng
            Console.Write("Khách hàng (Child/Student/Adult/Senior): ");
            CustomerType customerType = (CustomerType)Enum.Parse(typeof(CustomerType), Console.ReadLine(), true);

            // Nhập thẻ sinh viên
            Console.Write("Thẻ SV hợp lệ (True/False): ");
            bool hasStudentCard = bool.Parse(Console.ReadLine());

            // Nhập ngày xem phim
            Console.Write("Ngày xem (Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday): ");
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);

            decimal discount = 0;
            decimal weekendSurcharge = 0;

            // Tính giảm giá
            if (customerType == CustomerType.Child)
            {
                discount = basePrice * 0.50m;
            }
            else if (customerType == CustomerType.Senior)
            {
                discount = basePrice * 0.50m;
            }
            else if (customerType == CustomerType.Student && hasStudentCard)
            {
                // Sinh viên được giảm 30% từ Thứ 2 đến Thứ 5
                if (day == DayOfWeek.Monday ||
                    day == DayOfWeek.Tuesday ||
                    day == DayOfWeek.Wednesday ||
                    day == DayOfWeek.Thursday)
                {
                    discount = basePrice * 0.30m;
                }
            }
            else if (customerType == CustomerType.Adult &&
                     day == DayOfWeek.Wednesday)
            {
                // Thứ 4 Vui Vẻ dành cho Adult
                discount = basePrice * 0.20m;
            }

            // Tính phụ thu cuối tuần
            if (day == DayOfWeek.Friday ||
                day == DayOfWeek.Saturday ||
                day == DayOfWeek.Sunday)
            {
                weekendSurcharge = 20000m;
            }

            // Tính giá cuối cùng
            decimal finalPrice = basePrice - discount + weekendSurcharge;

            // In vé
            Console.WriteLine("\n========== VÉ XEM PHIM ==========");
            Console.WriteLine($"Khách hàng: {customerType}");
            Console.WriteLine($"Ngày xem: {day}");
            Console.WriteLine($"Giá vé gốc: {basePrice:N0} VNĐ");
            Console.WriteLine($"Khoản giảm giá: -{discount:N0} VNĐ");
            Console.WriteLine($"Phụ thu cuối tuần: +{weekendSurcharge:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN VÉ: {finalPrice:N0} VNĐ");
            Console.WriteLine("=================================");
        }
    }
}





