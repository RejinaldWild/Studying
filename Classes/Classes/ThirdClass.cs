using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ThirdClass
    {
        private int first;
        private int second;
        public ThirdClass()
        {
            first = 1;
            second = 2;
            Console.WriteLine("1st = {0}\n2nd = {1}",first,second);
        }
        public ThirdClass(int first)
        {
            this.first = first;
            second = 4;
            Console.WriteLine("1st = {0}\n2nd = {1}", first, second);
        }
        public ThirdClass(int first,int second)
        {
            this.first = first;
            this.second = second;
            Console.WriteLine("1st = {0}\n2nd = {1}", first, second);
        }
    }
}
