using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc5
    {
        private static int num;
        public static int Prop
        {
            get
            {
                if (num != 0) return num += 2;
                else num = 1;
                return num;
            }
            set
            {
                num = value * 2 - 1;
            }
        }

        public static void Excs()
        {
            Console.WriteLine(Exc5.Prop);
            Console.WriteLine(Exc5.Prop);
            Console.WriteLine(Exc5.Prop);
            Exc5.Prop = 5;
            Console.WriteLine(Exc5.Prop);
        }
    }
}
