using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Base1
    {
        public int Code;
        public void Show()
        {
            Console.WriteLine("Field Code is "+Code);
        }
        
        public Base1(int n)
        {
            Code = n;
        }
        public Base1 (Base1 obj)
        {
            Code = obj.Code;
        }
    }

    internal class MyClass1 : Base1
    {
        public char Symb;
        public void Display()
        {
            Console.WriteLine("Field Symb is "+Symb);
        }
        public MyClass1(int n, char s) : base(n)
        {
            Symb = s;
        }
        public MyClass1(MyClass1 obj) : base(obj)
        {
            Symb = obj.Symb;
        }
    }

    internal class DoL5
    {
        public static void DoMain()
        {
            MyClass1 A = new MyClass1(13, 'R');
            Base1 Object1;
            Object1 = A;
            Console.WriteLine("Using variable Object1:");
            Object1.Show();
            ((MyClass1)Object1).Display();
            Object1.Code = 18;
            ((MyClass1)Object1).Symb = 'M';
            Console.WriteLine("Using variable A:");
            A.Show();
            A.Display();
            MyClass1 B = new MyClass1(A);
            A.Code = 0;
            A.Symb = 'O';
            Console.WriteLine("Using variable B:");
            B.Show();
            B.Display();
        }
    }
}
