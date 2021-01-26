using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceExc07
    {
        int Number { get; set; }
        void GetValue();
    }

    interface IMyInterfaceExc071
    {
        string Text { get; set; }
        void GetValue();
    }

    internal class MyClassExc07 : IMyInterfaceExc07, IMyInterfaceExc071
    {
        private int Num;
        private string Txt;

        public int Number
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value;
            }
        }
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
        public void GetValue()
        {
            Console.WriteLine(Number);
            Console.WriteLine(Text);
        }
    }

    internal class Exc07
    {
        public static void Main07()
        {
            MyClassExc07 A = new MyClassExc07();
            A.Number = 19;
            A.Text = "Omg!";
            A.GetValue();
        }
    }
}
