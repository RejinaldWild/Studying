using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing4
    {
        private string txt;
        public Listing4(uint txt)
        {
            number = txt;
        }
        
        public override string ToString()
        {
            return txt;
        }

        public uint number
        {
            set
            {
                uint num = value;
                txt = "";
                do
                {
                    txt = (num % 2) + txt;
                    num >>= 1;
                } while (num != 0);
            }
        }
        public static void ListingFunc()
        {
            Listing4 Obj = new Listing4(8);
            Console.WriteLine("Test of number 8:" + Obj);
            Obj.number = 88;
            Console.WriteLine("Test of number 88:" + Obj.txt);
        }
    }
}
