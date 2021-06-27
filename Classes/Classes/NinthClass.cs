using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class NinthClass
    {
        static public void MaxValue(params int[] number)
        {
            int max=0;
            for(int i =0; i<number.Length; i++)
            {
                if (max < number[i])
                {
                    max=number[i];
                }                
            }            
            Console.WriteLine("Max value is {0}",max);
        }
        static public void MinValue(params int[] number)
        {
            int min = 320000000;
            for(int i = 0; i < number.Length; i++)
            {
                if (min > number[i])
                {
                    min = number[i];
                }
            }            
            Console.WriteLine("Min value is {0}",min);
        }
        static public void AverageValue(params int[] number)
        {
            double count = 0.0;
            for(int i = 0; i < number.Length; i++)
            {
                count += number[i];
            }
            double avr = (double)(count / number.Length);
            Console.WriteLine("Average value is {0}",avr);
        }
    }
}
