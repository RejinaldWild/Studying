using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate string DExc06();

    internal class Exc06
    {
        public static void MainExc06()
        {
            int count = 0;
            DExc06 DayOfWeek = () =>
            {   
                int i = count % 7;
                switch (i)
                {
                    case 0:
                        count++;
                        return "Monday";
                    case 1:
                        count++;
                        return "Tuesday";
                    case 2:
                        count++;
                        return "Wednesday";
                    case 3:
                        count++;
                        return "Thuersday";
                    case 4:
                        count++;
                        return "Friday";
                    case 5:
                        count++;
                        return "Saturday";
                    case 6:
                        count++;
                        return "Sunday";
                    default:
                        return "";
                }
            };

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine(DayOfWeek());
            }
        }
    }
}
