using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc09
    {
        public int Number;
        public int Index;
    }

    class Exc09
    {
        public static StrExc09 FindMin(int[] arr)
        {
            StrExc09 A;
            A.Number = arr[0];
            A.Index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (A.Number > arr[i])
                {
                    A.Number = arr[i];
                    A.Index = i;
                }
            }
            return A;
        }

        public static void MainExc09()
        {
            int[] array = new int[] { 13, 2, 8, 5 , 1, 2, 1, 8};
            StrExc09 A;
            A=FindMin(array);
            Console.WriteLine(A.Number);
            Console.WriteLine(A.Index);
        }
    }
}
