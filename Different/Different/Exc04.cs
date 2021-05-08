using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc04
    {
        public static void MainExc04()
        {
            Console.WriteLine("Input interval of years");
            Console.WriteLine("Input first year");
            int aYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second year");
            int bYear = Int32.Parse(Console.ReadLine());
            int cYear = 0;
            if (aYear >= bYear)
            {
                cYear = aYear;
                aYear = bYear;
                bYear = cYear;
            }
            int day = 1;
            int month = 1;
            Console.WriteLine("Mondays in 1st of the January:");
            for(int i = aYear; i <= bYear; i++)
            {
                DateTime MonYear = new DateTime(i, month, day);
                if(MonYear.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine(MonYear.ToString("dd.MM.yyyy"));
                }
            }
        }
    }
}
