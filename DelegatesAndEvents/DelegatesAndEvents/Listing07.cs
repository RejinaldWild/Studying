using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int Alpha07(int n);
    delegate void Bravo07(string txt);

    internal class MyClassL7
    {
        public int Number;
        public MyClassL7(int n)
        {
            Number = n;
        }
        public Alpha07 Method;
    }

    internal class AnonymousMethDemo
    {
        internal class Listing07
        {
            public static void Main07()
            {
                MyClassL7 A = new MyClassL7(100);
                MyClassL7 B = new MyClassL7(200);
                A.Method = delegate (int n)
                {
                    return A.Number + n;
                };
                B.Method = delegate (int n)
                {
                    return B.Number - n;
                };

                int x = 80;
                Console.WriteLine("A.Method({0})={1}",x,A.Method(x));
                A.Number = 300;
                Console.WriteLine("A.Method({0})={1}", x, A.Method(x));
                Console.WriteLine("B.Method({0})={1}", x, B.Method(x));
                Bravo07 Show=delegate(string txt) 
                {
                    Console.WriteLine("Text: \"{0}\"",txt);
                };
                Show("Bravo!");
                Show = delegate (string txt)
                  {
                      for (int k = 0; k < txt.Length; k++)
                      {
                          Console.Write("|" + txt[k]);
                      }
                      Console.WriteLine("|");
                  };
                Show("Bravo!");
            }

        }
    }
    
}
