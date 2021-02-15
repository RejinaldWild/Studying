using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate char DExc03();

    internal class MyClassExc03
    {
        public string Text;
        private DExc03 Md;
        public DExc03 PropMd => Md;
        public MyClassExc03(string txt, bool yn)
        {
            Text = txt;
            if (yn == true)
            {
                Md = () => Text[0];
            }
            else Md = () => Text[Text.Length - 1];
        }
        
    }

    internal class Exc03
    {
        public static void MainExc03()
        {
            MyClassExc03 A = new MyClassExc03("OMFG!", true);
            MyClassExc03 B = new MyClassExc03("OMFG!", false);
        }
    }
}
