using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Exc01
    {        
        static void ChangeValues<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Now first argument is {a} and second argument {b}");
        }

        public static void MainExc01()
        {
            ChangeValues(13, 46);
            ChangeValues('A', 'F');
        }        
    }
}
