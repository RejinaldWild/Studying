using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int DExc04(int k);

    internal class MyClassExc04
    {   
        public DExc04 this[int k]=>(int n) => (int)Math.Pow(n,k);
    }

    internal class Exc04
    {
        public static void MainExc04()
        {
            MyClassExc04 A = new MyClassExc04();
            Console.WriteLine(A[2](4));
        }
    }
}
