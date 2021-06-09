using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Exc02
    {
        static void CircleElement<T>(T[] arr)
        {
            int n = 4;
            Array.Reverse(arr, 0, arr.Length);
            Array.Reverse(arr, n, arr.Length-n);
            Array.Reverse(arr,0,n);

            foreach (T item in arr)
            {
                Console.Write(" | " + item);
            }
            Console.WriteLine(" |");
        }

        public static void MainExc02()
        {
            int[] arrInteger = { 1, 2, 3, 4 ,5,6,7,8,9,10,11,12,13};
            string[] arrString = { "John", "Max", "Charlie","Arch"};
            CircleElement(arrInteger);
            CircleElement(arrString);
        }
    }
}
