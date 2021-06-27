using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing15
    {
        private int[] nums;
        public Listing15(int size)
        {
            nums = new int[size];
            for(int i = 0; i < nums.Length; i++)
            {
                this[i] = i + 1;
            }
        }
        public override string ToString()
        {
            string text = "Object has:\n";
            for(int i = 0; i < nums.Length; i++)
            {
                text += this[i] + (i == nums.Length - 1 ? "\n" : " ");
            }
            return text;
        }
        public int this[int i]
        {
            get{return nums[i % nums.Length];}
            set{nums[i % nums.Length] = value;}
        }
        public int this[char s]
        {
            get{return this[s - 'a'];}
            set{this[s - 'a'] = value;}
        }
        public int this[int k, string t]
        {
            get{return this[t[k]];}
            set{this[t[k]] = value;}
        }
        public int this[string t,int k]
        {
            get{return this[k, t];}
            set{this[k, t] = value;}
        }

        public static void ListingFunc()
        {
            int n = 6;
            Listing15 Obj = new Listing15(n);
            Console.WriteLine(Obj);
            for(int k = 0; k < n + 3; k++)
            {
                Console.Write(Obj[k]+" ");
            }
            Console.WriteLine("\n");
            Obj[1] = 7;
            Obj[n + 3] = 8;
            Console.WriteLine(Obj);
            Obj['a'] = 9;
            Obj['k'] = 0;
            Console.WriteLine(Obj);
            Console.WriteLine("Testing:");
            for(char s = 'a'; s < 'a' + n + 3; s++)
            {
                Console.Write(Obj[s]+" ");
            }
            Console.WriteLine("\n");
            Obj[4, "alpha"] = 0;
            Obj["bravo", 0] = 6;
            Console.WriteLine(Obj);
            string txt = "abc";
            Console.WriteLine("Testing:");
            for(int k = 0; k < txt.Length; k++)
            {
                Console.WriteLine(Obj[k,txt]+": " + Obj[txt, k]);
            }
        }
    }
}
