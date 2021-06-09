using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate double DExc09(double x);

    internal class Exc09
    {
        public static void MainExc09()
        {
            DExc09 Root = new DExc09(QuadraticSolve(2.0, -3.0, -4.0));
            Console.WriteLine(Root(2.0));
        }

        public static DExc09 QuadraticSolve(double a,double b,double c)
        {   
            double result=0.0;
            return (double x) =>
            {
                return result = a*x*x + b*x + c;
                };
        }
    }
}
