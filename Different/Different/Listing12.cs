using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Listing12
    {
        public static void MainListing12()
        {
            Hashtable ht = new Hashtable();
            ht.Add("First", 100);
            ht.Add("Second", 200);
            ht["Third"] = 300;
            ICollection keys = ht.Keys;
            Console.WriteLine("Collection elements:");
            foreach(string s in keys)
            {
                Console.WriteLine("{0} -> {1}",s,ht[s]);
            }

            SortedList sl = new SortedList();
            sl.Add("One", 11);
            sl.Add("Two", 22);
            sl["Three"] = 33;
            keys = sl.Keys;
            Console.WriteLine("Collection elements:");
            foreach (string s in keys)
            {
                Console.WriteLine("{0} -> {1}", s, sl[s]);
            }
        }
    }
}
