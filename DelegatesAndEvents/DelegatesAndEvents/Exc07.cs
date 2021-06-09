using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int DExc07(int n);

    internal class Exc07
    {   
        public static int[] ArrFunc(int[] array, DExc07 Md)
        {
            int[] outArr = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                outArr[i] = Md(array[i]);
            }
            return outArr;
        }

        public static void Show(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void MainExc07()
        {
            int[] Arr = { 1, 4, 3 };
            DExc07 Meth = (int n) =>
            {   
                return n+1;
            };
            Show(ArrFunc(Arr, Meth));
        }
    }
}
