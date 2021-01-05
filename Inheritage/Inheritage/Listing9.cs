using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Alpha3
    {
        public int Alpha;
        public void Set()
        {
            Alpha = 10;
            Console.WriteLine("Alpha (without arguments): {0}", Alpha);
        }
        public virtual void Set(int n)
        {
            Alpha = n;
            Console.WriteLine("Alpha (one argument): {0}", Alpha);
        }
    }
    internal class Bravo3 : Alpha3
    {
        public int Bravo;
        public override void Set(int n)
        {
            Alpha = n;
            Bravo = Alpha;
            Console.WriteLine("Bravo (one argument): {0} and {1}", Alpha, Bravo);
        }
        public void Set(int m,int n)
        {
            Alpha = m;
            Bravo = n;
            Console.WriteLine("Bravo (two arguments): {0} and {1}", Alpha, Bravo);
        }
    }

    internal class DoL9
    {
        public static void DoMain()
        {
            Alpha3 A = new Alpha3();
            A.Set();
            A.Set(13);
            Console.WriteLine();
            Bravo3 B = new Bravo3();
            B.Set();
            B.Set(4);
            B.Set(8, 18);
        }
    }
}
