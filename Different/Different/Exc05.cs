using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc05    //use subtract method
    {
        public static bool CompareDate(DateTime A, DateTime B,
            TimeSpan Interval)
        {   
            TimeSpan resultSubtract = A.Subtract(B);
            return Interval >= resultSubtract.Duration();
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
