using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int DExc05();

    internal class Exc05
    {
        public static void MainExc05()
        {
            int a = 0;
            int b = 1;
            DExc05 Fib = () =>
            {
                int c = a + b;
                a = b;
                b = c;
                if (a == 1)
                {   
                    return 1;
                }
                return c;
            };
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fib());
            }
        }
    }
}
