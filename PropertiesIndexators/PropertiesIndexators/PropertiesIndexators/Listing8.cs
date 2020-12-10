using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing8
    {
        private int code;
        public Listing8(char symb)
        {
            code = symb;
        }
        
        public char this[int k]
        {
            get
            {
                return (char)(code + k);
            }
            set
            {
                code = value - k;
            }
        }

        public static void ListingFunc()
        {
            Listing8 Obj = new Listing8('N');
            for(int i = 0; i < 10; i++)
            {
                Console.Write(Obj[i]+" ");
            }
            Console.WriteLine();
            Obj[5] = 'M';
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Obj[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Obj[-i] + " ");
            }
            Console.WriteLine();
            Obj[-5] = 'R';
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Obj[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
