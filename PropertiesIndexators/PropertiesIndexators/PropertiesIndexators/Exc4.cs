using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc4
    {
        private uint num;
        private string text;
        public Exc4(uint nums)
        {
            num = nums;
            text = Convert.ToString(nums, 8);
        }
        public uint SetProp
        {
            set
            {
                num = value;
                text = Convert.ToString(value, 8);
            }
        }
        public string GetProp
        {
            get
            {
                return text;
            }
        }

        public static void Excs()
        {
            Exc4 Obj = new Exc4(8);
            Console.WriteLine(Obj.GetProp);
            Obj.SetProp = 13;
            Console.WriteLine(Obj.GetProp);
        }
    }
}
