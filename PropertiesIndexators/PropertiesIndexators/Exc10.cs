using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc10
    {
        public string[] Str = new string[] {"Come"," on",","," try"," to"," fill"," me"};

        public string this[int k]
        {
            get
            {                
                return Str[k % Str.Length];
            }
            set
            {
                Str[k % Str.Length] = value;
            }
        }

        public char this[int k, int i]
        {
            get
            {
                string str = Str[k % Str.Length];
                char symb = str[i%str.Length];
                return symb;
            }            
        }

        public static void Excs()
        {
            Exc10 Obj = new Exc10();
            Console.WriteLine(Obj[5]);
            Console.WriteLine(Obj[7]);
            Obj[5] = "filling";
            Console.WriteLine(Obj[5]);
            Obj[7] = "Go";
            Console.WriteLine(Obj[7]);
            Exc10 Obj1 = new Exc10();
            Console.WriteLine(Obj1[5][1]);
            Console.WriteLine(Obj1[7][2]);            
        }
    }
}
