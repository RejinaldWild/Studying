using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class TenthClass
    {        
        int[] array;

        public TenthClass(int elem,int min,int max)
        {
            array = new int[elem];
            Random rndNumber = new Random();            
            for (int i=0;i<array.Length;i++)
            {
                array[i] = rndNumber.Next(min, max);
            }
        }

        public override string ToString()
        {
            int elements=0;
            int average = 1;
            foreach (int i in array)
            {
                elements++;
            }
            Console.WriteLine("Elements in array = "+elements);
            foreach(int i in array)
            {
                average += array[i];
            }
            Console.WriteLine("Average values of elements = "+(average /= elements));
            string text="";
            foreach(int i in array)
            {
                text += array[i];
            }
            Console.WriteLine(text);
            return text;
        }
    }
}
