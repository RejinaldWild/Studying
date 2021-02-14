using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate17(string txt);

    internal class MyClassL17
    {
        private MyDelegate17 myEvent;
        public event MyDelegate17 MyEvent17
        {
            add
            {
                myEvent += value;
            }
            remove
            {
                myEvent -= value;
            }
        }
        public void RaiseMyEvent(string txt)
        {
            if (myEvent != null)
            {
                myEvent(txt);
            }
        }
    }

    internal class AlphaL17
    {
        public string Name;
        public AlphaL17(string txt)
        {
            Name = txt;
        }
        public void Show(string msg)
        {
            Console.WriteLine("Object "+ Name +":");
            Console.WriteLine(msg);
        }
    }

    internal class EventDemo
    {
        internal class Listing17
        {
            public static void Main17()
            {
                MyClassL17 Obj = new MyClassL17();
                AlphaL17 A = new AlphaL17("A");
                AlphaL17 B = new AlphaL17("B");
                Obj.RaiseMyEvent("1st event");
                Obj.MyEvent17 += A.Show;
                Obj.RaiseMyEvent("2nd event");
                Console.WriteLine();
                Obj.MyEvent17 += B.Show;
                Obj.RaiseMyEvent("3rd event");
                Console.WriteLine();
                Obj.MyEvent17 -= A.Show;
                Obj.RaiseMyEvent("4th event");
                Console.WriteLine();
                Obj.MyEvent17 -= A.Show;
                Obj.MyEvent17 -= B.Show;
                Obj.RaiseMyEvent("5th event");
                MyDelegate17 md = A.Show;
                md += B.Show;
                Obj.MyEvent17 += md;
                Obj.RaiseMyEvent("6th event");
            }
        }
    }
}
