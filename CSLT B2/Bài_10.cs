using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_B2
{
    internal class Bài_10
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số ngày: ");
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;

            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine(
                totalDays + " ngày = " +
                years + " năm, " +
                weeks + " tuần, " +
                days + " ngày");
               Console.ReadKey();
        }
    }
}

