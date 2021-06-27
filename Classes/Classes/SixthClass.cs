using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class SixthClass
    {
        private int min, max;

        public void SetMinMax(int a,int b)
        {
            SetMinMax(a);
            SetMinMax(b);            
        }
        public void SetMinMax(int a)
        {
            if (a > max)
            {
                max = a;
            }
            if (a < min)
            {
                min = a;
            }
        }
        public void Show()
        {
            Console.WriteLine($"Min Value is {min}\nMax Value is {max}");
        }
        public SixthClass(int a)
        {
            min = a;
            max = a;
        }
        public SixthClass(int a, int b)
        {
            if (a > b)
            {
                max = a;
                min = b;                
            }
            else
            {
                max = b;
                min = a;
            }            
        }
    }
}
