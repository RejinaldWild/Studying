using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Base
    {
        public int Code;
        public void Show()
        {
            Console.WriteLine("Field Code: "+Code);
        }
    }

    internal class MyClass : Base
    {
        public char Symb;
        public void Display()
        {
            Console.WriteLine("Field Symb: "+Symb);
            Show();
        }
        public int Number
        {
            get
            {
                return Code;
            }
            set
            {
                Code = value;
            }
        }
    }

    internal class DoL1
    {
        public static void DoMain()
        {
            MyClass Obj = new MyClass();
            Obj.Code = 100;
            Obj.Symb = 'R';
            Obj.Display();
            Obj.Number = 21;
            Console.WriteLine("Prop Number is " + Obj.Number);
            Obj.Show();
        }
    }
}
