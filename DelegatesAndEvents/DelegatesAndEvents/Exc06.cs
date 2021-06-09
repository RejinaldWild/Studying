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
            string[] arrDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int count = -1;
            DExc06 DayOfWeek = () =>
            {
                count++;
                return arrDays[count%arrDays.Length];
                
                //int i = count % 7;
                //switch (i)
                //{
                //    case 0:
                //        count++;
                //        return "Monday";
                //    case 1:
                //        count++;
                //        return "Tuesday";
                //    case 2:
                //        count++;
                //        return "Wednesday";
                //    case 3:
                //        count++;
                //        return "Thuersday";
                //    case 4:
                //        count++;
                //        return "Friday";
                //    case 5:
                //        count++;
                //        return "Saturday";
                //    case 6:
                //        count++;
                //        return "Sunday";
                //    default:
                //        return "";
                //}
            };

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine(DayOfWeek());
            }
        }
    }
}
