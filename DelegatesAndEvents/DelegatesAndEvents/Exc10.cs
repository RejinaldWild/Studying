using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void DExc10(string txt);

    internal class MyClassExc10
    {
        private string Text;
        public event DExc10 Event;
        public MyClassExc10(string txt)
        {
            Text = txt;
        }
        public void GenerateEvent()
        {
            if (Event != null)
            {
                Event(Text);
            }
        }
    }

    internal class MyClassExc101
    {
        public void Show(string txt)
        {
            Console.WriteLine(txt);
        }
    }

    internal class Exc10
    {
        public static void MainExc10()
        {
            MyClassExc10 Obj1 = new MyClassExc10("Wow,bow,wow!");
            MyClassExc10 Obj2 = new MyClassExc10("Boom!");
            MyClassExc101 Obj3 = new MyClassExc101();
            Obj1.Event += Obj3.Show;
            Obj2.Event += Obj3.Show;
            Obj1.GenerateEvent();
            Obj2.GenerateEvent();
        }
    }
}
