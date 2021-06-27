using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class TenthClass
    {
        static private double Factorial(double n)
        {            
            if (n == 0||n==1) { return 1; }            
            double result = 1.0;
            result = n * Factorial(n - 1);            
            return result;
        }

        static public void Cosinus(double x, int n)
        {
            double cosinus = 0.0;
            for (int i = 0; i <= n; i++)
            {
                cosinus += (Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / (Factorial(2 * i));
            }            
            Console.WriteLine(cosinus);
        }

        static public void HyperCosinus (double x, int n)
        {
            double hcosinus = 0.0;
            for (int i = 0; i <= n; i++)
            {
                hcosinus +=  Math.Pow(x, 2 * i) / (Factorial(2 * i));
            }            
            Console.WriteLine(hcosinus);
        }

        static public void HyperSinus (double x,int n)
        {
            double hsinus = 0.0;
            for (int i = 0; i <= n; i++)
            {
                hsinus += Math.Pow(x, 2 * i+1) / (Factorial(2 * i+1));
            }
            Console.WriteLine(hsinus);
        }
    }
}
