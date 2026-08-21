using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2.Buoi3
{
    internal class Ex02
    {
        public static void Run()
        {
            // Ex1:
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chỉ số điện cũ:");
            int oldIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Chỉ số điện mới:");
            int newIndex = int.Parse(Console.ReadLine());
            
            float a = newIndex - oldIndex;
            Console.WriteLine("Lượng điện tiêu thụ là: " + a);

            float b;
            if (0 < a && a < 50)
                b = 1806;
            else if (51 <= a && a < 100)
            {
                b = 1866;
            }
            else if (101 <= a && a < 200)
            {
                b = 2167;
            }
            else if (201 <= a && a <300)
            {
                b = 2729;
            }
            else  
            {
                b = 3050;
            }

            float TienDienChuaThue = (float) (a * b);
            Console.WriteLine("Số tiền điện chưa thuế: " + TienDienChuaThue);
            float vat = TienDienChuaThue * 0.08f;
            Console.WriteLine("Thuế VAT: " + vat);
            float TongThanhToan = TienDienChuaThue   + vat;
            Console.WriteLine("Tổng thanh toán : " + TongThanhToan);




        }
    }
}
