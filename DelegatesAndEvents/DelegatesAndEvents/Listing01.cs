using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate char MyDelegate01(int k, string txt);

    internal class MyClassL1
    {
        public int Code;
        public MyClassL1(int n)
        {
            Code = n;
        }
        public char GetChar(int k,string txt)
        {
            return (char)(txt[k] + Code);
        }
        public static char GetFirst(int k,string txt)
        {
            return txt[k];
        }
    }

    internal class DelegateDemo
    {
        static char GetLast(int k, string txt)
        {
            return txt[txt.Length - k - 1];
        }


        internal class Listing01
        {
            public static void Main01()
            {
                MyClassL1 Obj = new MyClassL1(5);
                MyDelegate01 Meth = new MyDelegate01(Obj.GetChar);
                Console.WriteLine("Symbol \'{0}\'", Meth(4, "Alpha"));
                Obj.Code = 1;
                Console.WriteLine("Symbol \'{0}\'", Meth(4, "Alpha"));
                Meth = MyClassL1.GetFirst;
                Console.WriteLine("Symbol \'{0}\'", Meth(2, "Alpha"));
                Meth = GetLast;
                Console.WriteLine("Symbol \'{0}\'", Meth(1, "Alpha"));
            }
        }
    }
}
