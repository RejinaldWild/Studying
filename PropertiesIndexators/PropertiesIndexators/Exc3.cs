using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc3
    {
        private int[] arr;
        public Exc3(int num)
        {
            arr = new int[Math.Abs(num)];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
        }

        public int Prop
        {
            get
            {
                int res = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    res += arr[i];
                }
                return res;
            }
        }
        public static void Excs()
        {
            Exc3 Obj = new Exc3(-6);
            Console.WriteLine(Obj.Prop);
        }
    }
}
