using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc09
    {
        public static Stack AverageValueArrayCount(int[] array)
        {
            Stack T = new Stack();
            int val=0;
            for(int i = 0; i < array.Length; i++)
            {
                val += array[i];
            }
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] >= (val / 2))
                {
                    T.Push(array[i]);
                }
            }
            return T;
        }

        public static void MainExc09()
        {
            int[] array1 = new int[] { 1, 2, 3, -13, 4, 6, 8, 3, -15, 18, 1, -19 };
            int[] array2 = new int[] { 13, 12, 2, -18, -4, 0, 1 };
            Stack A = new Stack(AverageValueArrayCount(array1));
            Stack B = new Stack(AverageValueArrayCount(array2));
        }
    }
}
