using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    class Listing05
    {
        public static void MainListing05()
        {
            int start = 1990, end = 2100, day = 13;
            DateTime date;
            Console.WriteLine("Fridays of September");
            for(int year = start; year <= end; year++)
            {
                for(int month = 1; month<=12; month++)
                {
                    date = new DateTime(year, month, day);
                    if(date.DayOfWeek==DayOfWeek.Friday && month == 9)
                    {
                        Console.WriteLine(date.ToString("dd MMMM yyyy"));
                    }
                }
            }
        }
    }
}
