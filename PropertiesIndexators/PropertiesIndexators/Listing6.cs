using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing6
    {
        private static int last = 1;
        private static int prev = 1;
        public static int Number
        {
            get
            {
                int res = prev;
                last = last + prev;
                prev = last - prev;
                return res;
            }
            set
            {
                prev = 1;
                last = 1;
                for(int i =2; i <=value; i++)
                {
                    last = last + prev;
                    prev = last - prev;
                }
            }
        }

        public static void Show()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,5}", Listing6.Number);
            }
            Console.WriteLine();
        }

        public static void ListingFunc()
        {
            Show();
            Listing6.Number = 6;
            Show();
            Number = 1;
            Show();
        }
    }
}
