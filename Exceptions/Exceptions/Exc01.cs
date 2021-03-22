using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Exc01
    {
        public static void MainExc01()
        {
            int size = 0;
            try
            {   
                Console.WriteLine("Input integer number more than 0");
                size = Int32.Parse(Console.ReadLine());
                double[] arr = new double[size];
                Random RandomNumbers = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = RandomNumbers.Next(-13, 13);
                }
                foreach (double item in arr)
                {
                    Console.Write(item + "|");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong format in data");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Wrong integer number");
            }
        }
    }
}
