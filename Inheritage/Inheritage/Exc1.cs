using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc1
    {
        protected string text;
        public Exc1(string txt)
        {
            text = txt;
        }
        public override string ToString()
        {
            string txt = "";
            txt += "Exc1 class:\n" + text;
            return txt;
        }
    }

    internal class Exc11 : Exc1
    {
        protected string text1;
        public Exc11(string textA,string textB) : base(textA)
        {
            text1 = textB;
        }
        public override string ToString()
        {
            string txt = "";
            txt += "Exc2 class:\n" + text + "\n"+text1;
            return txt;
        }
    }

    internal class ExcMain1
    {
        public static void DoMain()
        {
            Exc1 FirstText = new Exc1("Hello");
            Console.WriteLine(FirstText);
            Exc11 TwoTexts = new Exc11("Hi!", "It is me!");
            Console.WriteLine(TwoTexts);
        }
    }
}
