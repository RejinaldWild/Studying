using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc05
    {
        public static bool CompareDate (DateTime A, DateTime B, 
            TimeSpan Interval)
        {
            if (A == B) return true;
            else if (A > B)
            {
                for (int i = 1; i <= Interval.Ticks; i++)
                {
                    long ticky = A.Ticks - i;
                    if (ticky == B.Ticks) return true;
                }
                return false;
            }
            else
            {
                for(int i = 1; i <= Interval.Ticks; i++)
                {
                    long ticky = A.Ticks + i;
                    if (ticky == B.Ticks) return true;
                }
                return false;
            }
        }

        public static void MainExc05()
        {
            DateTime A = new DateTime(1959, 9, 13, 5, 45, 18,18);
            DateTime B = new DateTime(1959, 9, 13, 5, 45, 18,19);
            TimeSpan Inter = new TimeSpan(10000);
            bool dateCompare = CompareDate(A, B, Inter);
            Console.WriteLine(dateCompare);
        }
    }
}
