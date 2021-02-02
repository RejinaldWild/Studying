using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void MyDelegate03(string txt);

    internal class MyClassL3
    {
        public MyDelegate03 apply;
        public MyClassL3(MyDelegate03 md)
        {
            apply = md;
        }
    }

    internal class AlphaL3
    {
        private string Name;
        public void Set(string txt)
        {
            Name = txt;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    internal class DelegateAsFieldDemo
    {
        internal class Listing03
        {
            public static void Main03()
            {
                AlphaL3 A = new AlphaL3();
                MyClassL3 Obj = new MyClassL3(A.Set);
                Obj.apply("Object A");
                Console.WriteLine(A);
                AlphaL3 B = new AlphaL3();
                Obj.apply = B.Set;
                Obj.apply("Object B");
                Console.WriteLine(B);
                Obj.apply += A.Set;
                Obj.apply("Object X");
                Console.WriteLine(A+" "+B); // object X + object X
                Obj.apply -= B.Set;
                Obj.apply("Object A");
                Console.WriteLine(A + " " + B); //object A + object X
            }
        }
    }
}
