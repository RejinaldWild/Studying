using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int MyDelegate13();

    internal class LambdaAsResultDemo
    {
        static MyDelegate13 Calculate(int n)
        {
            int count = 0;
            return () =>
            {
                count += n;
                return count;
            };
            //    delegate ()
            //{
            //    count += n;
            //    return count;
            //};
        }
        internal class Listing13
        {
            public static void Main13()
            {
                MyDelegate13 Next = Calculate(1);
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
