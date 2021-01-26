using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceExc08
    {
        string Text { get; set; }
    }
    interface IMyInterfaceExc081
    {
        string Text { get; set; }
    }

    internal class MyClassExc08 : IMyInterfaceExc08, IMyInterfaceExc081
    {
        public string Txt;
        public string Text
        {
            get
            {
                return Txt;
            }
            set
            {
                Txt = value;
            }
        }

        string IMyInterfaceExc08.Text
        {
            get
            {
                return Txt + "1";
            }
            set
            {
                Txt = value + "a";
            }
        }
        string IMyInterfaceExc081.Text
        {
            get
            {
                return Txt + "2";
            }
            set
            {
                Txt = value + "b";
            }
        }
    }

    internal class Exc08
    {
        public static void Main08()
        {
            MyClassExc08 A = new MyClassExc08();
            A.Text = "Wow!";
            Console.WriteLine( A.Text );
            IMyInterfaceExc08 I = A;            
            Console.WriteLine(I.Text);
            IMyInterfaceExc081 I1 = A;
            I1.Text = "WoW";
            Console.WriteLine(I1.Text);
        }
    }
}
