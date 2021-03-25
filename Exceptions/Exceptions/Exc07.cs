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
            for(int i = 0; i < 5000; i++)
            {
                A[i] = i + 2;
                Console.WriteLine(A[i]);
                n++;
            }
            return n;
        }

        public static void MainExc07()
        {
            int sizeArr;
            MyClass07 Ind = new MyClass07();
            try
            {
                sizeArr = FindLength(Ind);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
