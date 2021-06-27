using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing1
    {
        private int num;
        private int min;
        private int max;

        public Listing1 (int min, int max)
        {
            if (min >= max)
            {
                this.max = min;
                this.min = max;
            }
            else
            {
                this.min = min;
                this.max = max;
            }            
            Code = (min + max) / 2;
        }

        public int Code
        {
            get
            {
                return num;
            }
            set
            {
                if (value < min) num = min;
                else if (value > max) num = max;
                else num = value;
            }
        }

        public static void ListingFunc()
        {
            Listing1 Obj = new Listing1(1, 9);
            Console.WriteLine(Obj.Code);
            Obj.Code = 7;
            Console.WriteLine(Obj.Code);
            Obj.Code = -1;
            Console.WriteLine(Obj.Code);
            Obj.Code = 10;
            Console.WriteLine(Obj.Code);
            Obj.Code = 8;
            Console.WriteLine(Obj.Code);
        }
    }
}
