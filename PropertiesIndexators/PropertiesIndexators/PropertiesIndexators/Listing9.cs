using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing9
    {
        private int number;
        public Listing9(int num)
        {
            number = num;
        }
        public int this[int k]
        {
            get
            {
                int n = number;
                for(int i = 1; i < k; i++)
                {
                    n /= 10;
                }
                return n % 10;
            }
        }

        public static void ListingFunc()
        {
            Listing9 Obj = new Listing9(42358);
            for(int i = 1; i<9; i++)
            {
                Console.Write(" | " + Obj[i]);
            }
            Console.WriteLine(" |");
        }
    }
}
