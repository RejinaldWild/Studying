using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Exc08
    {
        public static void FindTypeGeneric<T>(T x)
        {
            Type TempType = x.GetType();
            if (TempType.Equals(typeof(Int32)))
            {
                Console.WriteLine("It is int type {0} of value {1}", typeof(T), x);
            }
            else if (TempType.Equals(typeof(Char)))
            {
                Console.WriteLine("It is char type {0} of value {1}", typeof(T), x);
            }
            else
            {
                Console.WriteLine("It is not int or char this is {0} type of value {1}",typeof(T),x);
            }
        }

        public static void MainExc08()
        {
            int num = 13;
            string str = "OMG";
            char symb = 'R';
            FindTypeGeneric(num);
            FindTypeGeneric(str);
            FindTypeGeneric(symb);
        }
    }
}
