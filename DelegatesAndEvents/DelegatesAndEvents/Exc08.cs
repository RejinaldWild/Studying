using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Exc08
    {
        public static Func<int,int> Method(Func<int,int> a, Func<int,int> b)
        {
            return (x) => 
            {   
                return b(a(x));
            };
        }

        public static void MainExc08()
        {
            Func<int,int> Del1 = (int x) => { return x + 1; };
            Func<int,int> Del2 = (int x) => { return x + 5; };
            Func<int,int> Del3 = Method(Del1, Del2);
            Console.WriteLine(Del3(5));
        }
    }
}
