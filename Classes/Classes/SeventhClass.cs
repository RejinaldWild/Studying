using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class SeventhClass
    {
        private char symb;
        private string txt;

        public void TextOrSymb(char symb)
        {
            this.symb = symb;
        }

        public void TextOrSymb(string txt)
        {
            this.txt = txt;
        }

        public void TextOrSymb(char[] symbs)
        {
            if (symbs.Length == 1)
            {
                symb = symbs[0];
            }
            else
            {
                for(int i = 0; i < symbs.Length; i++)
                {
                    txt += symbs[i];
                }                
            }
        }

        public void Show()
        {
            Console.WriteLine($"The char is {symb}");
            Console.WriteLine($"The text is \"{txt}\"");
        }
    }
}
