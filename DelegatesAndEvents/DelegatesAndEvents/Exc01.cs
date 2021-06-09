using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int DExc01(char symbol, string text);

    internal class Exc01
    {
        public static int FindSymbTimes(char symb, string txt)
        {
            int count = 0;
            for(int i = 0; i < txt.Length; i++)
            {
                if (symb == txt[i]) count++;
            }
            return count;
        }

        public static int FindFirstSymb(char symb,string txt)
        {
            int firstSymb = -1;
            for(int i = 0; i < txt.Length; i++)
            {
                if (symb == txt[i])
                {
                    firstSymb = i;
                    break;
                }
            }
            return firstSymb;
        }

        public static void MainExc01()
        {
            DExc01 Md = new DExc01(FindFirstSymb);
            Console.WriteLine(Md('m', "Come to me, my friend"));
            Md = FindSymbTimes;
            Console.WriteLine(Md('m', "Come to me, my friend"));
        }
    }
}
