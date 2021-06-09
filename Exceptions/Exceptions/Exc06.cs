using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Exc06
    {
        public static void GenerateException(int number)
        {
            if (number % 2 == 0) throw new ArithmeticException();
            else throw new OverflowException();
        }

        public static void MainExc06()
        {
            try
            { 
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Input a number");
                        int number = Int32.Parse(Console.ReadLine());
                        GenerateException(number);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("It is odd number");
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("It is even number");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
