using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Exc07
    {
        public static void SortArrMaxMin<T>(T[] arr) where T:IComparable
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[i]) < 0)
                    {
                        T min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;
                    }
                }
            }
        }

        public static void SortArrMinMax<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        T max = arr[j];
                        arr[j] = arr[i];
                        arr[i] = max;
                    }
                }
            }
        }

        public static void Show<T>(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.Write(" | "+item);
            }
            Console.WriteLine(" |");
            
        }

        public static void MainExc07()
        {
            int[] IntArr = new int[] { 3, 2, 8, 35, 24, 13 };
            SortArrMaxMin<int>(IntArr);
            Show(IntArr);
            SortArrMinMax<int>(IntArr);
            Show(IntArr);
        }
    }
}
