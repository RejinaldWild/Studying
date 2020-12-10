using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing10
    {
        private string txt;
        public Listing10(string txt)
        {
            this.txt = txt;
        }
        public static implicit operator Listing10(string t)
        {
            return new Listing10(t);
        }
        public override string ToString()
        {
            return txt;
        }
        public char this[int k]
        {
            set
            {
                if (k < 0 || k >= txt.Length) return;
                string t = "";
                for(int i = 0; i < k; i++)
                {
                    t += txt[i];
                }
                t += value;
                for(int i = k + 1; i < txt.Length; i++)
                {
                    t += txt[i];
                }
                txt = t;
            }
        }
        public static void ListingFunc()
        {
            Listing10 Text = "Myxa";
            Console.WriteLine(Text);
            Text[-1] = 'R';
            Text[4] = 'W';
            Console.WriteLine(Text);
            Text[0] = 'C';
            Text[1] = 'o';
            Text[2] = 'r';
            Text[3] = 'k';
            Console.WriteLine(Text);
        }
    }
}
