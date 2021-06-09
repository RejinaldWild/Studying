using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForExc1
{
    internal class MyClassBase
    {
        public int Num1;
        public MyClassBase(int num)
        {
            Num1 = num;
        }
    }
}

namespace ForExc2
{
    interface IMath
    {
        int Add();
    }
}

namespace ForExc3
{
    internal class MyClassD : ForExc1.MyClassBase, ForExc2.IMath
    {
        public int Num2;
        public MyClassD(int num1,int num2):base(num1)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Add()
        {
            int z= Num1 + Num2;
            return z;
        }
    }
}

namespace Different
{
    internal class Exc02
    {
        public static void MainExc02()
        {
            ForExc3.MyClassD A = new ForExc3.MyClassD(13, 8);
            int sum = A.Add();
            Console.WriteLine(sum);
        }
    }
}
