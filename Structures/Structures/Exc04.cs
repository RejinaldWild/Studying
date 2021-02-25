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

        public int Min()
        {
            int min = 13;
            for(int i=0; i<ArrNum.Length-1; i++)
            {
                if (ArrNum[i] > ArrNum[i + 1])
                {
                    min = ArrNum[i+1];
                }
            }
            if (ArrNum[ArrNum.Length - 1] > ArrNum[ArrNum.Length])
            {
                min = ArrNum[ArrNum.Length];
            }
            return min;
        }
    }

    class Exc04
    {
        public static void MainExc04()
        {

        }
    }
}
