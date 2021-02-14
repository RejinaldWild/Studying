using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate16(string txt);
    internal class MyClassL16
    {
        public event MyDelegate16 MyEvent16;
        public void RaiseMyEvent(string txt)
        {
            if (MyEvent16 != null)
            {
                MyEvent16(txt);
            }
        }
    }
    
    internal class Alpha16
    {
        public string Name;
        public Alpha16(string txt)
        {
            Name = txt;
        }
        public void Show(string msg)
        {
            Console.WriteLine("Object "+Name+":");
            Console.WriteLine(msg);
        }
    }

    internal class Listing16
    {
        public static void Main16()
        {
            MyClassL16 Obj = new MyClassL16();
            Alpha16 A = new Alpha16("A");
            Alpha16 B = new Alpha16("B");
            Obj.RaiseMyEvent("1st event");
            Obj.MyEvent16 += A.Show;
            Obj.RaiseMyEvent("2nd event");
            Console.WriteLine();
            Obj.MyEvent16 += B.Show;
            Obj.RaiseMyEvent("3rd event");
            Console.WriteLine();
            Obj.MyEvent16-= A.Show;
            Obj.RaiseMyEvent("4th event");
            Console.WriteLine();
            Obj.MyEvent16 -= A.Show;
            Obj.MyEvent16 -= B.Show;
            Obj.RaiseMyEvent("5th event");
            MyDelegate16 Md = A.Show;
            Md += B.Show;
            Obj.MyEvent16 += Md;
            Obj.RaiseMyEvent("6th event");
        }

        private static void Obj_MyEvent16(string txt)
        {
            throw new NotImplementedException();
        }
    }
}
