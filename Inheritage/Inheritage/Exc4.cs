using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc4
    {
        public int Number;
        public Exc4(int n)
        {
            Number = n;
        }
        public void Set(int n)
        {
            Number = n;
        }
        public override string ToString()
        {
            string txt = "";
            txt += Number + "\n";
            return txt;
        }
    }
    internal class Exc41 : Exc4
    {
        public char Symb;
        public Exc41(int n, char s) : base(n)
        {
            Symb = s;
        }
        public void Set(int n, char s)
        {
            Number = n;
            Symb = s;
        }
        public override string ToString()
        {
            string txt = "";
            txt += base.ToString() + Symb +"\n";
            return txt;
        }
    }
    internal class Exc42 : Exc41
    {
        public string Text;
        public Exc42(int n, char s, string str) : base(n, s)
        {
            Text = str;
        }
        public void Set(int n, char s, string str)
        {
            Number = n;
            Symb = s;
            Text = str;
        }
        public override string ToString()
        {
            string txt = "";
            txt += base.ToString() + Text+"\n";
            return txt;
        }
    }

    internal class ExcMain4
    {
        public static void DoMain()
        {
            Exc4 Obj1 = new Exc4(4);
            Console.WriteLine(Obj1);
            Obj1.Set(5);
            Console.WriteLine(Obj1);
            Exc41 Obj2 = new Exc41(8, 'M');
            Console.WriteLine(Obj2);
            Obj2.Set(9, 'm');
            Console.WriteLine(Obj2);
            Exc42 Obj3 = new Exc42(13, 'r', "Wild");
            Console.WriteLine(Obj3);
            Obj3.Set(18, 'R', "Young");
            Console.WriteLine(Obj3);
        }
    }
}
