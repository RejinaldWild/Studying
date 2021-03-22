using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Exc03
    {
        public static void MainExc03()
        {
            try
            {
                Console.WriteLine("Input number A");
                int A = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input number B");
                int B = Int32.Parse(Console.ReadLine());
                int x = B / A;
                if(B%A==0 || (A==0 && B == 0))
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Aswer does not have a solve");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        
    }
}
