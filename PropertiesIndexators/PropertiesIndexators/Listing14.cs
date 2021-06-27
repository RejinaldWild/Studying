using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing14
    {
        private int code;
        public Listing14(int n)
        {
            code = n;
        }
        public override string ToString()
        {
            return "Field code of object is: " + code;
        }

        public char this[string a, int i, string b, int j]
        {
            get
            {
                return (char)(a[i] - b[j] + code);
            }
            set
            {
                code = value - (a[i] - b[j]);
            }
        }
        public static void ListingFunc()
        {
            Listing14 Obj = new Listing14('A');
            Console.WriteLine(Obj);
            string a = "Alpha", b = "Bravo";
            int i = 2, j = 4;
            Console.WriteLine("Obj[\"{0}\",{1},\"{2}\",{3}] = {4}",a,i,b,j,Obj[a,i,b,j]);
            Obj[a, i, b, j] = 'F';           
            Console.WriteLine(Obj);
            Console.WriteLine("Obj[\"{0}\",{1},\"{2}\",{3}] = {4}", a, i, b, j, Obj[a, i, b, j]);
            a = "Charlie";
            i = 1; j = 2;
            Console.WriteLine("Obj[\"{0}\",{1},\"{2}\",{3}] = {4}", a, i, b, j, Obj[a, i, b, j]);
        }
    }
}
