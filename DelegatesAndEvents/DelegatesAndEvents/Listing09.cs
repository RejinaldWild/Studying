using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int MyDelegate09();

    internal class AnonymAsResultDemo
    {
        static MyDelegate09 Calculate(int n)
        {
            int count = 0;
            return delegate ()
            {
                count += n;
                return count;
            };
        }
        internal class Listing09
        {
            public static void Main09()
            {
                MyDelegate09 Next = Calculate(1);
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(Next() + " ");
                }
                Console.WriteLine();
                Next = Calculate(3);
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(Next() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
