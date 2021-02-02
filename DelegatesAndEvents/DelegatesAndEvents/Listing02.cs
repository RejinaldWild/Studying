using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate02();
    internal class MyClassL2
    {
        public string Name;
        public MyClassL2(string txt)
        {
            Name = txt;
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    internal class MulticastDemo
    {
        static void MakeLine()
        {
            Console.WriteLine("----------");
        }
        internal class Listing02
        {
            public static void Main02()
            {
                MyClassL2 A = new MyClassL2("Object A");
                MyClassL2 B = new MyClassL2("Object B");
                MyClassL2 C = new MyClassL2("Object C");
                MyDelegate02 Method = A.Show;
                Method();
                Method = MakeLine;
                Method += A.Show;
                Method += B.Show;
                Method = Method + C.Show;
                Method();
                Method -= B.Show;
                Method();
                Method = Method - A.Show;
                Method();
            }
        }
    }
}
