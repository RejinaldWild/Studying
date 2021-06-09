using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc10
    {
        public static void MainExc10()
        {
            Random rnd = new Random();
            //Hashtable ht = new Hashtable();            
            SortedList ht = new SortedList();
            int n = 8;
            int a = 1;
            int b = 2;
            int c;
            char val = Convert.ToChar(rnd.Next(65, 90));
            ht.Add(a, val);
            val = Convert.ToChar(rnd.Next(65, 90));
            ht.Add(b, val);
            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                val = Convert.ToChar(rnd.Next(65, 90));
                ht.Add(c, val);
            }
            ICollection keys = ht.Keys;
            ICollection values = ht.Values;
            foreach (int i in keys)
            {
                Console.Write(i+"\t");                
            }
            Console.WriteLine();
            foreach (char i in ht.Values)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
        }
    }
}
