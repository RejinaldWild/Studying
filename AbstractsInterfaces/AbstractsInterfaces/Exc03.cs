using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceExc031
    {
        int GetNumber();
    }

    internal class MyClassExc031:IMyInterfaceExc031
    {
        int Number;
        public MyClassExc031(int n)
        {
            Number = n;
        }
        public int GetNumber()
        {
            int sum = 0;
            for(int i=0; i < Number; i++)
            {
                sum += 2*i;
            }
            return sum;
        }
    }
    internal class MyClassExc032 : IMyInterfaceExc031
    {
        int Number;
        public MyClassExc032(int n)
        {
            Number = n;
        }
        public int GetNumber()
        {
            int sum = 0;
            for (int i = 0; i < Number; i++)
            {
                sum += 2 * i+1;
            }
            return sum;
        }
    }

    internal class Exc03
    {
        public static void Main03()
        {
            MyClassExc031 A = new MyClassExc031(4);
            MyClassExc032 B = new MyClassExc032(7);            
            Console.WriteLine(A.GetNumber());
            Console.WriteLine(B.GetNumber()); 
            IMyInterfaceExc031 R;
            R = B;
            Console.WriteLine(R.GetNumber());

        }
    }
}
