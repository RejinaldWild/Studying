using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceExc06
    {
        int this[char s] { get;set; }
    }
    interface IMyInterfaceExc061
    {
        char this[int n] { get;set; }
    }

    internal class MyClassExc06:IMyInterfaceExc06, IMyInterfaceExc061
    {
        public int Number;
        public char Symbol;
        public int this[char s]
        {
            get
            {
                return Number;
            }
            set
            {
                Number = (int)value;
            }
        }
        public char this[int n]
        {
            get
            {
                return Symbol;
            }
            set
            {
                Symbol = (char)n;
            }
        }
    }

    internal class Exc06
    {
        public static void Main06()
        {
            MyClassExc06 A = new MyClassExc06();
            Console.WriteLine(A['B']=18);
            Console.WriteLine(A[68]='R');
            Console.WriteLine(A.Number);
            Console.WriteLine(A.Symbol);
        }
    }
}
