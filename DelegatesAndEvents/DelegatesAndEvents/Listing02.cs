using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate02();
    internal class MyClass02
    {
        public string Name;
        public MyClass02(string txt)
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
                MyClass02 A = new MyClass02("Object A");
                MyClass02 B = new MyClass02("Object B");
                MyClass02 C = new MyClass02("Object C");
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
