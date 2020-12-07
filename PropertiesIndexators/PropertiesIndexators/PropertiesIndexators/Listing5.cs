using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing5
    {
        private int[] nums;

        public string Content
        {
            get
            {
                if (nums == null) return "{}";
                string txt = "{" + nums[0];
                for(int i = 1; i < nums.Length; i++)
                {
                    txt += "," + nums[i];
                }
                txt += "}";
                return txt;
            }
        }

        public int Element
        {
            set
            {
                if (nums == null)
                {
                    nums = new int[1];
                    nums[0] = value;
                }
                else
                {
                    int[] n = new int[nums.Length+1];
                    for(int i = 0; i<nums.Length; i++)
                    {
                        n[i] = nums[i];
                    }
                    n[nums.Length] = value;
                    nums = n;
                }                
            }
        }

        public int[] Data
        {
            get
            {
                int[] res = new int[nums.Length];
                for(int i = 0; i<nums.Length; i++)
                {
                    res[i] = nums[i];
                }
                return res;
            }
            set
            {
                nums = new int[value.Length];
                for(int i = 0; i<value.Length; i++)
                {
                    nums[i] = value[i];
                }
            }
        }

        public static void ListingFunc()
        {
            Listing5 Obj = new Listing5();
            Console.WriteLine(Obj.Content);
            Obj.Element = 13;
            Console.WriteLine(Obj.Content);
            Obj.Element = 8;
            Obj.Element = 88;
            Console.WriteLine(Obj.Content);
            int[] arr = Obj.Data;            
            Obj.Element = 113;            
            for( int i =0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine(Obj.Content);
            int[] arr1 = { 5, 16, 59 };
            Obj.Data = arr1;
            Console.WriteLine(Obj.Content);
            arr1[0] = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Obj.Content);
        }
    }
}
