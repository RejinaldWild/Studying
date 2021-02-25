using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc03
    {
        private char[] ArrSb;
        public StrExc03(string txt)
        {
            ArrSb = txt.ToCharArray();
        }
        public StrExc03(int n, char sb)
        {
            ArrSb = new char[n];
            for(int i = 0; i < n; i++)
            {
                ArrSb[i] = sb;
            }
        }
        public char this [int k]
        {
            get { return ArrSb[k]; }
            set { ArrSb[k] = value; }
        }
        public void ReverseArray ()
        {
            char[] arr = new char[ArrSb.Length];
            for(int i = 0; i < ArrSb.Length/2; i++)
            {
                char sb = ArrSb[i];
                if (ArrSb.Length % 2 != 0)
                {
                    arr[ArrSb.Length / 2] = ArrSb[ArrSb.Length / 2];
                }
                arr[i] = ArrSb[ArrSb.Length - 1 - i];
                arr[ArrSb.Length - 1 - i] = sb;
            }
            ArrSb = arr;
        }

        public override string ToString()
        {
            string str="";
            for(int i = 0; i < ArrSb.Length; i++)
            {
                str += ArrSb[i].ToString() + "|";
                str += i.ToString()+"\n";
            }
            return str;
        }
    }

    class Exc03
    {
        public static void MainExc03()
        {
            StrExc03 TextSymb = new StrExc03("Coding!");
            TextSymb[1] = 'O';
            Console.WriteLine(TextSymb[2]);
            TextSymb.ReverseArray();
            Console.WriteLine(TextSymb);

            StrExc03 SymbNum = new StrExc03(4, 'R');
            SymbNum[2] = 'w';
            SymbNum[1] = 'A';
            Console.WriteLine(SymbNum[3]);
            SymbNum.ReverseArray();
            Console.WriteLine(SymbNum);
        }
    }
}
