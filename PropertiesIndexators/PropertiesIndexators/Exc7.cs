using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc7
    {
        private uint number;
        public uint this[int num]
        {
            get
            {
                string str = Convert.ToString(num,2);
                number = UInt32.Parse(str);
                return number;
            }
        }

        public static void Excs()
        {
            Exc7 Obj = new Exc7();
            for(int i = 0; i < 14; i++)
            {
                Console.WriteLine(Obj[i]);
            }
        }
    }
}
