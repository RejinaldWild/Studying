using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc5
    {
        public char Symb;
        public Exc5(char s)
        {
            Symb = s;
        }
    }
    internal class Exc51 : Exc5
    {
        public string Txt;
        public Exc51(char s,string str) : base(s)
        {
            Txt = str;
        }
    }
    internal class Exc52 : Exc51
    {
        public int Number;
        public Exc52(char s, string str, int n) : base(s, str)
        {
            Number = n;
        }
    }

    internal class ExcMain5
    {
        public static void DoMain()
        {
            Exc5 A = new Exc5('H');
            Console.WriteLine(A.Symb);
            Exc51 B = new Exc51('r',"Witty");
            Console.WriteLine(B.Symb);
            Console.WriteLine(B.Txt);
            Exc52 C = new Exc52('d', "Smart", 13);
            Console.WriteLine(C.Symb);
            Console.WriteLine(C.Txt);
            Console.WriteLine(C.Number);
        }
    }
}
