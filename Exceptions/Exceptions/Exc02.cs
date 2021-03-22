using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Exc02
    {
        public static void MainExc02()
        {
            try
            {
                Console.WriteLine("Input first number");
                int numberA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input second number");
                int numberB = Int32.Parse(Console.ReadLine());
                int numberC;
                if (numberA >= numberB)
                {
                    numberC = numberA % numberB;
                }
                else numberC = numberB % numberA;
                Console.WriteLine(numberC);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Wrong Format:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            
        }
    }
}
