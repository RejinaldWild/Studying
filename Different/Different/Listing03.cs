using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using myclass = Second.MyClass;

namespace Different
{
    class Listing03
    {
        public static void MainListing03()
        {
            MyClass A = new MyClass(4);
            myclass B = new myclass("Oops, I am late...");
            A.Show();
            B.Show();
        }
    }
}
