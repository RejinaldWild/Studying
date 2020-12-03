using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing3
    {
        public int first;
        public int last;

        public Listing3(int a, int b)
        {
            first = a;
            last = b;
        }

        public int Sum
        {
            get { return last + first; }
        }

        public static void ListingFunc()
        {
            Listing3 Obj = new Listing3(8, 13);
            Console.WriteLine(Obj.Sum);
            Obj.first = 3;
            Console.WriteLine(Obj.Sum);
            Obj.last = 6;
            Console.WriteLine(Obj.Sum);
        }
    }
}
