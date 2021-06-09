using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc101
    {
        public int Num;

        public static StrExc102 operator +(StrExc101 A, StrExc101 B)
        {
            StrExc102 AStr;
            AStr.Num = A.Num;
            AStr.Num1 = B.Num;
            return AStr;
        }
    }

    struct StrExc102
    {
        public int Num;
        public int Num1;

        public StrExc101[] ArrStr()
        {
            StrExc101[] Arr = new StrExc101[2];
            Arr[0].Num = Num;
            Arr[1].Num = Num1;
            return Arr;
        }
    }

    class Exc10
    {
        public static void MainExc10()
        {
            StrExc101 A;
            A.Num = 4;
            StrExc101 B;
            B.Num = 13;
            StrExc102 AB;
            AB = A + B;
            StrExc102 AD;
            AD.Num = 3;
            AD.Num1 = 8;
            AD.ArrStr();
            Console.WriteLine(AB);
        }
    }
}
