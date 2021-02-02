using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate06(int n);

    internal class MyClassL6
    {
        private int Number;
        public MyClassL6(int n)
        {
            Set(n);
        }
        public void Set(int n)
        {
            Number = n;
        }
        public override string ToString()
        {
            return "Field Number = " + Number;
        }
    }

    internal class MethAndObjRefsDemo
    {
        internal class Listing06
        {
            public static void Main06()
            {
                MyClassL6 A = new MyClassL6(100);
                MyClassL6 B = A;
                MyDelegate06 apply = A.Set;
                A = new MyClassL6(200);
                Console.WriteLine(A);
                Console.WriteLine(B);
                apply(300);
                Console.WriteLine();
                Console.WriteLine(A);
                Console.WriteLine(B);
            }
        }
    }
}
