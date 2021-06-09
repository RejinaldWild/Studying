using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc03        //CompareTo (day => month=> year)
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
            DateTime doB = new DateTime(year, month, day);
            
            TimeSpan liveds = today.Subtract(doB);
            DateTime lived = new DateTime(IsYear(today,doB),IsMonth(today, doB),IsDay(today, doB)); // use other variables
            Console.WriteLine(lived.Day.ToString()+'.'+ lived.Month.ToString()+'.'+ lived.Year.ToString());
        }

        public static int IsYear(DateTime dateToday, DateTime dateDate)
        {
            int year = dateToday.Year.CompareTo(dateDate.Year);
            if (year == 1)
            {
                if (dateToday.Month > dateDate.Month)
                {
                    return dateToday.Year - dateDate.Year;
                }
                else if(dateToday.Day>=dateDate.Day && dateToday.Month==dateDate.Month)
                {
                    return dateToday.Year - dateDate.Year;
                }
                else
                {
                    return dateToday.Year - dateDate.Year - 1;
                }
                
            }
            else if (year == 0)
            {                
                return 0;
            }
            else
            {
                Console.WriteLine("You have not born yet!");
                return 0;
            }            
        }

        public static int IsMonth(DateTime dateToday, DateTime dateDate)
        {
            int month = dateToday.Month.CompareTo(dateDate.Month);
            if(month == 1)
            {
                if (dateToday.Month > dateDate.Month || dateToday.Day >= dateDate.Day)
                {
                    return dateToday.Month - dateDate.Month;
                }                
                else
                {
                    return dateToday.Month - dateDate.Month - 1;
                }
            }
            else if (month == 0)
            {
                return 0;
            }
            else
            {
                return (12 - dateDate.Month) + dateToday.Month;               
            }
        }

        public static int IsDay(DateTime dateToday, DateTime dateDate)
        {
            int day = dateToday.Day.CompareTo(dateDate.Day);
            if (day == 1)
            {
                return dateToday.Day - dateDate.Day;
            }
            else if (day == 0)
            {
                return 0;
            }
            else
            {                
                return (30 - dateDate.Day) + dateToday.Day;
            }
        }
    }
}
