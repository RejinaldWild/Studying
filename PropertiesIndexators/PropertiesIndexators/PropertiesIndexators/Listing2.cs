using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing2
    {
        private int first;
        private int last;

        public Listing2(int a, int b)
        {
            first = a;
            last = b;
        }

        public override string ToString()
        {
            string txt = "Fields of object is ";
            txt += first + " and " + last;
            return txt;
        }

        public int Number
        {
            get
            {
                int t = last;
                last = first;
                first = t;
                return t;
            }
            set
            {
                last = first;
                first = value;
            }
        }

        public static void ListingFunc()
        {
            Listing2 Obj = new Listing2(1, 9);
            Console.WriteLine(Obj);
            Console.WriteLine("Prop Number is {0}",Obj.Number);
            Console.WriteLine(Obj);
            Obj.Number = 8;
            Console.WriteLine(Obj);
            Console.WriteLine("Prop Number is {0}", Obj.Number);
            Console.WriteLine(Obj);
            Console.WriteLine("Prop Number is {0}", Obj.Number);
            Console.WriteLine(Obj);
            Obj.Number = 3;
            Console.WriteLine(Obj);            
        }
    }
}
