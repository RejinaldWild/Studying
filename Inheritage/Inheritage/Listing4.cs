using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class AlphaBase2
    {
        public AlphaBase2()
        {
            Console.WriteLine("Constructor of class AlphaBase2");
        }
        ~AlphaBase2()
        {
            Console.WriteLine("Destructor of class AlphaBase2");
        }
    }

    internal class BravoClass2 : AlphaBase2
    {
        public BravoClass2() : base()
        {
            Console.WriteLine("Constructor of class BravoClass2");
        }
        ~BravoClass2()
        {
            Console.WriteLine("Destructor of class BravoClass2");
        }
    }

    internal class CharlieClass2 : BravoClass2
    {
        public CharlieClass2() : base()
        {
            Console.WriteLine("Constructor of class CharlieClass2");
        }
        ~CharlieClass2()
        {
            Console.WriteLine("Destructor of class CharlieClass2");
        }
    }

    internal class DoL4
    {
        public static void DoMain()
        {
            new CharlieClass2();
        }
    }
}
