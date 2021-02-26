using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Exc08
    {
        struct StrExc081
        {
            public string Text;
            public StrExc082 FindSymb(int n)
            {
                StrExc082 SymbSt = new StrExc082();
                if (n < Text.Length)
                {
                    SymbSt.Symb = Text[n];
                }
                return SymbSt;
            }
        }
        struct StrExc082
        {
            public char Symb;
        }

        public static void MainExc08()
        {
            StrExc081 A;
            A.Text = "WoW!";
            StrExc082 B;
            B = A.FindSymb(4);
            Console.WriteLine(B.Symb);
        }
    }
}
