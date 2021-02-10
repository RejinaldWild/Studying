using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate double Powers(double x);

    internal class MoreAnonymAsResultDemo
    {
        static Powers Maker(int n)
        {
            Powers meth;
            meth = delegate (double x)
              {
                  double s = 1;
                  for(int i = 1; i <= n; i++)
                  {
                      s *= x;
                  }
                  return s;
              };
            return meth;
        }
        internal class Listing10
        {
            public static void Main10()
            {
                Powers Sqr = Maker(2);
                Powers Cube = Maker(3);
                for(int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("{0,2}:{1,5}{2,5}{3,5}",i,Sqr(i),Cube(i),Maker(4)(i));
                }
            }
        }
    }
}
