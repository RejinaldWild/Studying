using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing13
    {
        private int[] vals;
        private char[] ckey;
        private string[] skey;

        private void Add(char symb, string str, int n)
        {
            int size;
            char[] s;
            string[] t;
            int[] v;
            if (vals == null) size = 1;
            else size = vals.Length + 1;
            s = new char[size];
            s[s.Length - 1] = symb;
            t = new string[size];
            t[t.Length - 1] = str;
            v = new int[size];
            v[v.Length - 1] = n;

            for(int k = 0; k < size - 1; k++)
            {
                s[k] = ckey[k];
                t[k] = skey[k];
                v[k] = vals[k];
            }

            ckey = s;
            skey = t;
            vals = v;
        }

        public override string ToString()
        {
            string txt = "Object has:\n";
            if (vals != null)
            {
                for(int k = 0; k < ckey.Length; k++)
                {
                    txt += ckey[k] + ": " + skey[k] + ": " + vals[k] + "\n";
                }
            }
            else
            {
                txt += "Object is empty!\n";
            }
            return txt;
        }

        public int this [char a, string b]
        {
            get
            {
                if (vals != null)
                {
                    for(int k = 0; k < ckey.Length; k++)
                    {
                        if(a==ckey[k] && b == skey[k])
                        {
                            return vals[k];
                        }
                    }
                }
                int res = 0;
                Add(a, b, res);
                return res;
            }
            set
            {
                if (vals != null)
                {
                    for(int k = 0; k < ckey.Length; k++)
                    {
                        if(a==ckey[k] && b == skey[k])
                        {
                            vals[k] = value;
                            return;
                        }
                    }
                }
                Add(a, b, value);
            }
        }

        public static void ListingFunc()
        {
            Listing13 Obj = new Listing13();
            Console.WriteLine(Obj);
            Console.WriteLine("Value of element: "+ Obj['A',"First"]+"\n");
            Console.WriteLine(Obj);
            Obj['B', "Second"] = 200;
            Obj['C', "Third"] = 300;
            Console.WriteLine(Obj);
            Console.WriteLine("Value of element: " + Obj['B', "First"] + "\n");
            Console.WriteLine("Value of element: " + Obj['B', "Second"] + "\n");
            Console.WriteLine("Value of element: " + Obj['A', "Third"] + "\n");
            Console.WriteLine(Obj);
            Obj['A', "First"] = 100;
            Console.WriteLine(Obj);
            Console.WriteLine("Value of element: " + Obj['A', "First"] + "\n");
        }
    }
}
