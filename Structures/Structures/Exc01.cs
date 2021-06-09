using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Exc01
    {
        public static Days DefineDayOfWeek (int n)
        {
            if (n % 7 == 0)
            {
                return Days.Sunday;
            }
            return (Days)(n % 7);
        }

        public static int MinDays(Days n,Days k)
        {
            if ((n - k)>3)
            {
                int avrg = 7 - (n - k);
                return Math.Abs(avrg);
            }
            else if((k - n)>3)
            {
                int avrg = 7 - (k - n);
                return Math.Abs(avrg);
            }
            else return Math.Min(Math.Abs(k - n),Math.Abs(n - k));
        }

        public static void MainExc01()
        {
            Console.WriteLine(DefineDayOfWeek(1));
            Console.WriteLine(DefineDayOfWeek(3));
            Console.WriteLine(DefineDayOfWeek(7));
            Console.WriteLine(DefineDayOfWeek(14));
            Console.WriteLine(DefineDayOfWeek(13));
            Console.WriteLine(MinDays(Days.Thursday,Days.Saturday));
            Console.WriteLine(MinDays(Days.Monday, Days.Saturday));
            Console.WriteLine(MinDays(Days.Saturday, Days.Monday));
            Console.WriteLine(MinDays(Days.Sunday, Days.Saturday));
            Console.WriteLine(MinDays(Days.Monday, Days.Thursday));
            Console.WriteLine(MinDays(Days.Saturday, Days.Friday));
        }
    }
}
