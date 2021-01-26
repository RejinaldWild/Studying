using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class BaseExc04
    {
        protected int Number01, Number02;
        public abstract int this [int k] { get; }
    }
    interface IMyInterfaceExc04
    {
        int Method(int n);
    }

    internal class MyClassExc04: BaseExc04, IMyInterfaceExc04
    {
        public MyClassExc04(int n,int m)
        {
            Number01 = n;
            Number02 = m;

        }
        public override int this [int k]
        {
            get
            {
                if (k % 2 == 0)
                {
                    return Number01;
                }
                else return Number02;
            }
        }

        public int Method(int n)
        {
            return ((Number01 + Number02) * n);
        }
    }

    internal class Exc04
    {
        public static void Main04()
        {
            MyClassExc04 A = new MyClassExc04(4, 13);
            Console.WriteLine(A.Method(2));
            Console.WriteLine(A[84]);
            Console.WriteLine(A[59]);
        }
    }
}
