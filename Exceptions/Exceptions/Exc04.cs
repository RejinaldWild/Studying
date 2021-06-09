using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exceptions
{
    class Exc04
    {
        public static void MainExc04()
        {
            try
            {
                Console.WriteLine("Input A for solution of a quadratic equation");
                double A = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Input B for solution of a quadratic equation");
                double B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Input C for solution of a quadratic equation");
                double C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double x1, x2;
                x1 = ((-B) + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
                x2 = ((-B) - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
                Console.WriteLine($"Roots are {x1} and {x2}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
