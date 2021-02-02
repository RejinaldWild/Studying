using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int Method(int n);

    internal class MyClassL5
    {
        private int Num;
        public MyClassL5(int n)
        {
            Num = n;
        }

        private int First(int n)
        {
            return n + Num;
        }
        private int Second (int n)
        {
            return n - Num;
        }
        private int Third(int n)
        {
            return n * Num;
        }

        public Method this[int k]
        {
            get
            {
                switch (k)
                {
                    case 0:
                        return First;
                    case 1:
                        return Second;
                    default:
                        return Third;
                }
            }
        }
    }

    internal class DelegateAsResDemo
    {
        internal class Listing05
        {
            public static void Main05()
            {
                int x = 12;
                MyClassL5 Obj = new MyClassL5(4);
                for(int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("Obj[{0}]({1})={2}",k,x,Obj[k](x));
                }
            }
        }
    }
}
