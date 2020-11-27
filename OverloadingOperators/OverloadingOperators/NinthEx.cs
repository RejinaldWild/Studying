using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class NinthEx
    {
        private int Num;
        public NinthEx(int number)
        {
            Num = number;
        }

        public static implicit operator NinthEx(int num)
        {
            return new NinthEx(num);
        }

        public static int operator +(NinthEx obj, NinthEx obj1)
        {
            return obj.Num + obj1.Num;
        }
        public static int operator -(NinthEx obj, NinthEx obj1)
        {
            return obj.Num - obj1.Num;
        }
        public static int operator *(NinthEx obj, NinthEx obj1)
        {
            return obj.Num * obj1.Num;
        }

        public static void NinthEsx()
        {
            NinthEx A = new NinthEx(2);
            NinthEx B = new NinthEx(3);
            A+=B;
            A *= B;
            A -= B;
        }
    }
}
