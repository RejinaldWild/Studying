using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace First
{
    class MyClass
    {
        public int Num;
        public MyClass(int n)
        {
            Num = n;
        }
        public void Show()
        {
           WriteLine($"First namespace with class MyClass where {Num}");
        }
    }
}
namespace Second
{
    class MyClass
    {
        public string Txt;
        public MyClass(string t)
        {
            Txt = t;
        }
        public void Show()
        {
            WriteLine($"Different namespace with class MyClass where \"{Txt}\"");
        }
    }
}
namespace Different
{
    class Listing02
    {
        public static void MainListing02()
        {
            First.MyClass A = new First.MyClass(13);
            Second.MyClass B = new Second.MyClass("Hi! I am from another namespase");
            A.Show();
            B.Show();
        }
    }
}
