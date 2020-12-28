using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc8
    {
        private uint number;

        public int this[int num]
        {
            set
            {
                number = Convert.ToUInt32(value % (Math.Pow(10, num)));
            }
        }

        public override string ToString()
        {
            string txt = number.ToString();
            return txt;
        }

        public static void Excs()
        {
            Exc8 Obj = new Exc8();
            Obj[2] = 856;
            Console.WriteLine(Obj.ToString());
            Obj[0] = 742;
            Console.WriteLine(Obj.ToString());
            Obj[1] = 913;
            Console.WriteLine(Obj.ToString()); 
        }
    }
}
