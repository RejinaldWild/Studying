using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class Exc7
    {
        public string Text;
        public Exc7(string txt)
        {
            Text = txt;
        }
        public virtual Exc71 Method()
        {
            return new Exc71("Bax", '+');
        }
    }

    internal class Exc71 : Exc7
    {
        public char Symb;
        public Exc71(string a,char b) : base(a)
        {
            Symb = b;
        }
        public override Exc71 Method()
        {
            return new Exc71(Text, Symb);
        }
    }

    internal class ExcMain7
    {
        public static void DoMain()
        {
            Exc7 obj1 = new Exc71("Da", 'R');
            Exc7 obj2 = obj1.Method();
            Exc7 obj3 = obj2;
        }
    }
}
