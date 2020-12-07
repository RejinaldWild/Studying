using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing7
    {
        private int[] nums;
        public Listing7(int n)
        {
            nums = new int[n];
            for(int i =0; i<nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public override string ToString()
        {
            string txt = "{" + nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                txt += "," + nums[i];
            }
            txt += "}";
            return txt;
        }

        public int Length
        {
            get { return nums.Length; }
        }

        public int this[int i]
        {
            get { return nums[i]; }
            set { nums[i] = value; }
        }

        public static void ListingFunc()
        {
            Listing7 Obj = new Listing7(5);
            Console.WriteLine(Obj);
            for(int i=0; i < Obj.Length; i++)
            {
                Obj[i] = 2 * i + 1;
            }
            Console.WriteLine(Obj);
            for(int i=0;i<Obj.Length; i++)
            {
                Console.Write(" "+Obj[i]);
            }
            Console.WriteLine();
        }
    }
}
