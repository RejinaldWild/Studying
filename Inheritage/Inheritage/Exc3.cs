using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc3
    {
        public int[] Arr;
        public Exc3( int[] arr)
        {            
            Arr = new int[arr.Length];
            Array.Copy(arr, Arr, arr.Length);
        }

        public override string ToString()
        {
            string arrLine="";
            for(int i=0; i<Arr.Length; i++)
            {
                arrLine += Arr[i] + "   ";
            }
            return arrLine;
        }
    }

    internal class Exc31 : Exc3
    {
        public char[] ArrChar;
        public Exc31( int[] arr, char[] arr1) : base(arr)
        {   
            ArrChar = new char[arr1.Length];
            Array.Copy(arr1, ArrChar, arr1.Length);
        }

        public override string ToString()
        {            
            string arrLine1 = base.ToString() + "\n";
            for (int i = 0; i < ArrChar.Length; i++)
            {
                arrLine1 += ArrChar[i] + "   ";
            }
            return arrLine1;
        }
    }

    internal class ExcMain3
    {
        public static void DoMain ()
        {
            int[] array = { 1, 2, 3, 4, 5, 8 };
            char[] arrayChar = { 'R', 'e', 's', 'M' };
            Exc3 Obj1 = new Exc3(array);
            string str = Obj1.ToString();
            Console.WriteLine(str);
            int[] array1 = { 4, 8, 13 };
            Exc31 Obj2 = new Exc31(array1, arrayChar);
            string str1 = Obj2.ToString();
            Console.WriteLine(str1);
        }
    }
}
