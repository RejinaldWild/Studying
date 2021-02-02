using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int MyDelegate04(int n);

    internal class DelegateAsArgDemo
    {
        static int F(int n)
        {
            return 2 * n + 1;
        }
        static int G(int n)
        {
            return 2 * n;
        }
        static int H(int n)
        {
            return n * n;
        }
        static void Display(MyDelegate04 F, int a, int b)
        {
            Console.WriteLine("{0,-4}|{1,4}", "x", "F(x)");
            Console.WriteLine("--------------------------");
            for(int k = a; k <= b; k++)
            {
                Console.WriteLine("{0,-4}|{1,4}", k, F(k));
            }
            Console.WriteLine();
        }

        internal class Listing04
        {
            public static void Main04()
            {
                int a = 0, b = 5;
                Console.WriteLine("Odd numbers:");
                Display(F, a, b);
                Console.WriteLine("Even numbers:");
                Display(G, a, b);
                Console.WriteLine("Numbers in 2nd rate:");
                Display(H, a, b);
            }
        }
    }

    
}
