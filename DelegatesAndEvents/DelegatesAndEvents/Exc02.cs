using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate void DExc02(char symb);

    internal class MyClassExc02
    {
        public char Symbol;        
        public void SetSymb(char symb)
        {
            Symbol = symb;
        }
    }

    internal class Exc02
    {
        public static void MainExc02()
        {
            int n = 4;
            MyClassExc02[] ArrObj = new MyClassExc02[n];
            ////DExc02 Md=new DExc02;
            //for (int i = 0; i < n; i++)
            //{
            //    ArrObj[i] = new MyClassExc02();
            //    Md += ArrObj[i].SetSymb;
            //}
            ////Md = ArrObj[0].SetSymb;
            ////Md += ArrObj[1].SetSymb;
            ////Md += ArrObj[2].SetSymb;
            ////Md += ArrObj[3].SetSymb;
            //Md('a');
        }
    }
}
