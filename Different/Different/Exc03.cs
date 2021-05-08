using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc03
    {
        public static void MainExc03()
        {
            Console.WriteLine("Input your Day of Birthday");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input your Month of Birthday");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input your Year of Birthday");
            int year = Int32.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime DoB = new DateTime(year, month, day);
            int resDay = 0;
            int resMonth = 0;
            int resYear = 0;
            if (today.Month >= month)
            {
                resMonth = today.Month - month;
                resYear = today.Year - year;
            }
            else
            {
                resMonth = (12 - month) + today.Month;
                resYear = today.Year - year - 1;
            }

            if (today.Day >= DoB.Day)
            {
                DateTime.DaysInMonth(today.Year, today.Month);
                resDay = today.Day - DoB.Day;
            }
            else
            {
                resDay = (31-day) + today.Day;
            }
            DateTime Lived = new DateTime(resYear,resMonth,resDay);
            Console.WriteLine(Lived.ToString());
        }
    }
}
