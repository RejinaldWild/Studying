using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class Exc2
    {
        protected string Text;
        public Exc2(string txt)
        {
            Text = txt;
        }

        public virtual void SetText()
        {
            Text = "Without Arg!";
        }
        public virtual void SetText(string txt)
        {
            Text = txt;
        }

        public int GetText
        {
            get { return Text.Length; }
        }

        public char this[int k]
        {
            get { return Text[k]; }
        }
    }

    class Exc21 : Exc2
    {
        public int Number;
        public Exc21(int n, string str):base(str)
        {            
            Number = n;
        }
        public override void SetText() //??
        {
            base.SetText();
            Text += "-Argument!";
        }
        public override void SetText(string txt) //??
        {
            base.SetText(txt);
            Text += " and some more text";
        }
        public void SetText(int n)
        {
            Number = n;
        }
        public void SetText(string txt, int n)
        {
            Text = txt;
            Number = n;
        }
    }

    internal class ExcMain2
    {
        public static void DoMain()
        {
            Exc2 Object1 = new Exc2("Hi");
            int lenght = Object1.GetText;
            Console.WriteLine(lenght);
            Object1.SetText();
            lenght = Object1.GetText;
            Console.WriteLine(lenght);
            Object1.SetText("Dont worry be happy");
            lenght = Object1.GetText;
            Console.WriteLine(lenght);
            char symb = Object1[6];
            Console.WriteLine(symb);
            Exc21 Obj2 = new Exc21(13, "All hail");
            Console.WriteLine(Obj2.Number);
            lenght = Obj2.GetText;
            Console.WriteLine(lenght);
            Obj2.SetText();
            lenght = Obj2.GetText;
            Console.WriteLine(lenght);
            Obj2.SetText(88);
            Console.WriteLine(Obj2.Number);
            Obj2.SetText("Traphouse");
            symb = Obj2[0];
            Console.WriteLine(symb);
            lenght = Obj2.GetText;
            Console.WriteLine(lenght);
            Obj2.SetText("Yo!", 4);
            Console.WriteLine(Obj2.Number);
            symb = Obj2[0];
            Console.WriteLine(symb);
        }
    }
}
