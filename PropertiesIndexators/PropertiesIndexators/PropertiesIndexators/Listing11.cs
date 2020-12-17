using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing11
    {
        public int code;
        public Listing11(int n)
        {
            code = n;
        }
        public int this[Listing11 Obj]
        {
            get
            {
                return code - Obj.code;
            }
            set
            {
                code = Obj.code + value;
            }
        }

        public static void ListingFunc()
        {
            Listing11 A = new Listing11(5);
            Console.WriteLine("Object A: "+A.code);
            Listing11 B = new Listing11(8);
            Console.WriteLine("Object B: " + B.code);
            int num = A[B];
            Console.WriteLine("A[B] = "+num);
            Console.WriteLine("B[A] = "+B[A]);
            A[B] = 18;
            Console.WriteLine("Object A: " + A.code);
        }
    }
}
