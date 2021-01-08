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
        public virtual Exc71 Method(Exc7 obj)
        {
            Exc71 Temp = new Exc71(obj.Text, '+');
            return Temp;
        }
    }

    internal class Exc71 : Exc7
    {
        public char Symb;
        public Exc71(string a,char b) : base(a)
        {
            Symb = b;
        }
        public override Exc71 Method(Exc7 obj)
        {
            obj = base.Method(obj);
            return (Exc71)obj;
        }
    }

    internal class ExcMain7
    {
        public static void DoMain()
        {

        }
    }
}
