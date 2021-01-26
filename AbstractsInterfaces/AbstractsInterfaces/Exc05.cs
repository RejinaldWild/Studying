using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceExc05
    {
        int Method01(char s);
    }

    interface IMyInterfaceExc051
    {
        char Method02(int n);
    }

    internal class MyClassExc05 : IMyInterfaceExc05, IMyInterfaceExc051
    {
        public int Number;
        public char Symb;
        public int Method01(char s)
        {
            Number = (int)s;
            return Number;
        }
        public char Method02(int n)
        {
            Symb = (char)n;
            return Symb;
        }
    }

    internal class Exc05
    {
        public static void Main05()
        {
            MyClassExc05 A = new MyClassExc05();
            A.Method02(65);
            MyClassExc05 B = new MyClassExc05();
            B.Method01('D');
            Console.WriteLine(A.Symb);
            Console.WriteLine(A.Number);
            Console.WriteLine(B.Symb);
            Console.WriteLine(B.Number);
            IMyInterfaceExc05 R = A;
            IMyInterfaceExc051 R1 = A;
            IMyInterfaceExc05 R2 = B;
            IMyInterfaceExc051 R3 = B;
            R.Method01('M');
            R1.Method02(88);
            R2.Method01('P');
            R3.Method02(99);
        }
    }
}
