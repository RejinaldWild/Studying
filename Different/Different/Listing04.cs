using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Listing04
    {
        public static void MainListing04()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is {0}",DateTime.Today);
            Console.WriteLine("Date and Time {0}", today);
            Console.WriteLine("Leap Year: {0}",DateTime.IsLeapYear(today.Year));
            Console.WriteLine("Month is {0}", today.Month);
            Console.WriteLine("Day of week is {0}",today.DayOfWeek);
            Console.WriteLine("Day of year is {0}", today.DayOfYear);
            Console.WriteLine("Hours: {0}",today.Hour);
            Console.WriteLine("Minutes: {0}", today.Minute);
            Console.WriteLine("Seconds: {0}",today.Second);
            Console.WriteLine("Milliseconds: {0}",today.Millisecond);
            Console.WriteLine("Ticks: {0}",today.Ticks);
            DateTime date = new DateTime(1990, 09, 13, 3, 15, 44);
            Console.WriteLine("New date: "+date.ToString("dd MMMM yyyy; HH:mm:ss"));
            TimeSpan time = new TimeSpan(44, 88, 113);
            Console.WriteLine("Interval of time: {0}",time);
            Console.WriteLine("One more date: {0}",date.Add(time));
            Console.WriteLine("Subtract of dates(in days): {0}",(today-date).Days);
            Console.WriteLine("Subtract of dates(in ticks): {0}",(today-date).Ticks);            
        }
    }
}
