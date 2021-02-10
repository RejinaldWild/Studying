using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int Alpha11(int n);
    delegate void Bravo11(string txt);

    internal class MyClassL11
    {
        public int Number;
        public MyClassL11(int n)
        {
            Number = n;
        }
        public Alpha11 Method;
    }

    internal class LambdaDemo
    {
        internal class Listing11
        {
            public static void Main11()
            {
                MyClassL11 A = new MyClassL11(100);
                MyClassL11 B = new MyClassL11(200);
                A.Method = n => A.Number + n;
                //delegate (int n)
                //{
                //    return A.Number + n;
                //};
                B.Method = (int n) =>
                {
                    return B.Number - n;
                };
                //delegate (int n)
                //{
                //    return B.Number - n;
                //};

                int x = 80;
                Console.WriteLine("A.Method({0})={1}", x, A.Method(x));
                A.Number = 300;
                Console.WriteLine("A.Method({0})={1}", x, A.Method(x));
                Console.WriteLine("B.Method({0})={1}", x, B.Method(x));
                Bravo11 Show = t => Console.WriteLine("Text: \"{0}\"", t);
                //delegate (string txt)
                //{
                //    Console.WriteLine("Text: \"{0}\"", txt);
                //};
                Show("Bravo!");
                Show = (string t) =>
                {
                    for (int k = 0; k < t.Length; k++)
                    {
                        Console.Write("|" + t[k]);
                    }
                    Console.WriteLine("|");
                };
                //delegate (string txt)
                //{
                //    for (int k = 0; k < txt.Length; k++)
                //    {
                //        Console.Write("|" + txt[k]);
                //    }
                //    Console.WriteLine("|");
                //};
                Show("Bravo!");
            }
        }
    }
}
