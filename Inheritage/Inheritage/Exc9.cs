using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc9
    {
        protected string Text;
        public virtual string GetSetText
        {
            get { return Text; }
            set { Text = value; }
        }
        public override string ToString()
        {
            string txt = "";
            txt+= "Base Class of Exc:\n" + Text;
            return txt;
        }
    }
    internal class Exc91 : Exc9
    {
        protected string Text1;
        public override string GetSetText
        {
            get
            {
                return Text + " " + Text1;
            }
            set
            {
                Text = "";
                int count = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] != ' ' && count == 0)
                    {
                        Text += value[i];
                    }
                    else
                    {
                        count++;                        
                    }
                    if (count == 0 && i == value.Length - 1)
                    {
                        Text1 = null;
                    }
                    else if (count>1) Text1 += value[i];
                }
            }
        }
        public override string ToString()
        {
            string txt = "";
            txt += "Inherit Class of Exc:\n" + "Text = "+Text+"\n"+"Text1 = "+Text1;
            return txt;
        }
    }

    internal class ExcMain9
    {
        public static void DoMain()
        {
            Exc9 ObjA = new Exc9();
            ObjA.GetSetText = "Kelly is good!";
            Console.WriteLine(ObjA);
            Exc91 ObjB = new Exc91();
            ObjB.GetSetText = "Hello world!";
            Console.WriteLine(ObjB);
            Console.WriteLine(ObjB.GetSetText);
        }
    }
}
