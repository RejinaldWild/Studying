using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyClass07
    {      
        private int[] arr = new int[4];
        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }

    class Exc07
    {
        public static int FindLength(MyClass07 A)
        {   
            int n=0;
            try
            {
                for (int i = 0; i < 5000; i++)
                {
                    A[i] = i + 2;
                    Console.WriteLine(A[i]);
                    n++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return n;
        }

        public static void MainExc07()
        {            
            MyClass07 Ind = new MyClass07();            
            int sizeArr = FindLength(Ind);
            Console.WriteLine(sizeArr);
        }
    }
}
