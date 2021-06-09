using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Exc05
    {
        public static int FindIndex(int[] arr, int number)
        {
            int index=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    index = i;
                    return index;
                }
            }
            throw new OverflowException();          
        }

        public static void MainExc05()
        {
            int[] array = new int[5] { 18, 15, 14, 17, 19 };
            Console.WriteLine("Input number of index");
            foreach(int item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            try
            {
                try
                {
                    int number = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(FindIndex(array, number));
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
