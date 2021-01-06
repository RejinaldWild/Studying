using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc6
    {
        protected string Text;
        public Exc6(string txt)
        {
            Text = txt;
        }
        public virtual void GetValue()
        {
            Console.Write("Base Class: ");
            Console.WriteLine(Text);
        }
    }

    internal class Exc61 : Exc6
    {
        protected int Num;
        public Exc61(string txt, int n) : base(txt)
        {
            Num = n;
        }
        public override void GetValue()
        {
            Console.Write("MyClass1: ");
            Console.WriteLine(Text);
            Console.WriteLine(Num);
        }
    }

    internal class Exc62 : Exc6
    {
        protected char Symb;
        public Exc62(string str, char s) : base(str)
        {
            Symb = s;
        }
        public override void GetValue()
        {
            Console.Write("MyClass2: ");
            Console.WriteLine(Text);
            Console.WriteLine(Symb);
        }
    }

    internal class ExcMain6
    {
        public static void DoMain()
        {
            Exc6 Obj = new Exc6("Yo!");
            Obj.GetValue();
            Exc61 A = new Exc61("OMG!", 13);
            A.GetValue();
            Exc62 B = new Exc62("Ohshee", 'R');
            B.GetValue();
            Obj = A;
            Obj.GetValue();
        }
    }
}
