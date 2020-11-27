using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class EighthEx
    {
        private int[] Arr;
        public EighthEx(int[] arr)
        {
            Arr = arr;
        }

        public static explicit operator string (EighthEx obj)
        {
            string txt = "";
            for(int i =0; i < obj.Arr.Length; i++)
            {
                txt += obj.Arr[i];
            }
            txt += " - this is text";
            return txt;
        }

        public static explicit operator int (EighthEx obj)
        {
            int sum = 0;
            for(int i =0; i<obj.Arr.Length; i++)
            {
                sum += obj.Arr[i];
            }
            return sum;
        }

        public static explicit operator EighthEx (int num)
        {
            int[] arr = new int[num];
            EighthEx T = new EighthEx(arr);
            for (int i = 0; i < T.Arr.Length; i++)
            {
                T.Arr[i] = 0;
            }
            return T;
        }

        public static void EighthExs()
        {
            int[] arr = new int[] { 4, 3, 8, 5 };
            EighthEx A = new EighthEx(arr);
            string text = (string)A;
            Console.WriteLine(text);
            int sum = (int)A;
            Console.WriteLine(sum);
            A = (EighthEx)3;
        }
    }
}
