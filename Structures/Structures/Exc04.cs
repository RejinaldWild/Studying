using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc04
    {
        private int[] ArrNum;
        public StrExc04(int n)
        {
            Random rnd = new Random();
            ArrNum = new int[n];
            for(int i = 0; i < ArrNum.Length; i++)
            {
                ArrNum[i] = rnd.Next(13);
            }
        }

        public int FindMin()
        {
            int min=ArrNum[0];
            for(int i=0; i<ArrNum.Length-1; i++)
            {
                if (min > ArrNum[i])
                {
                    min = ArrNum[i];
                }
            }
            return min;
        }

        public int FindMax()
        {
            int max = ArrNum[0];
            for(int i=0; i < ArrNum.Length - 1; i++)
            {
                if (max < ArrNum[i])
                {
                    max = ArrNum[i];
                }
            }
            return max;
        }

        public double FindAverage()
        {
            double avrg = 0.0;
            for(int i = 0; i < ArrNum.Length; i++)
            {
                avrg += ArrNum[i];
            }
            return avrg/ArrNum.Length;
        }

        public void ShowArray()
        {
            for (int i = 0; i < ArrNum.Length; i++)
            {
                Console.Write("|"+ArrNum[i]+"|");
            }
            Console.WriteLine();
        }
    }

    class Exc04
    {
        public static void MainExc04()
        {
            StrExc04 RandomArr = new StrExc04(5);
            RandomArr.ShowArray();
            Console.WriteLine(RandomArr.FindMax());
            Console.WriteLine(RandomArr.FindMin());
            Console.WriteLine(RandomArr.FindAverage());            
        }
    }
}
