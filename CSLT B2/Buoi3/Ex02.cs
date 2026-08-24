using System;
using System.Collections.Generic;
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
            Console.WriteLine("Bài 2");
            Console.OutputEncoding = Encoding.UTF8;


        }
    }
}
