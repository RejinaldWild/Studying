using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


    internal class Exc06
    {
        public static T FindMaxMin<T>(T[] arr) where T:IComparable
        {
            T max=default(T);
            T min = default(T);
            for(int i=1; i < arr.Length; i++)
            {   
                if (arr[i].CompareTo(arr[i - 1]) > 0)
                {
                    max = arr[i];
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(arr[i - 1]) < 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static void Comparing<T>(T[] arr1, T[] arr2) where T:IComparable
        {
            if (FindMaxMin(arr1).CompareTo(FindMaxMin(arr2)) > 0)
            {
                Console.WriteLine("Element in Array 1 is bigger than in Array 2");
            }
            else if (FindMaxMin(arr1).CompareTo(FindMaxMin(arr2)) == 0)
            {
                Console.WriteLine("Max/Min Element are equal!");
            }
            else
            {
                Console.WriteLine("Element in Array 1 is smaller than in Array 2");
            }
        }

        public static void MainExc06()
        {
            int[] IntArr1 = new int[] {72, 13, 88 };
            int[] IntArr2 = new int[] { 69, 13, 88 };
            char[] CharArr1 = new char[] { 'W', 'R', 'K' };
            char[] CharArr2 = new char[] { 'R',  'Y', 'A' };
            Comparing(IntArr1, IntArr2);
            Comparing(CharArr1, CharArr2);
        }
    }
}
