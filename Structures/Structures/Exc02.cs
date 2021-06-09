using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc02
    {
        private int Number;
        private string Text;
        private char Symb;

        public StrExc02(int n, char sb, string txt)
        {
            Number = n;
            Text = txt;
            Symb = sb;
        }

        public StrExc02(int n, string txt)
        {
            Number = n;
            Text = txt;
            Symb = 'V';
        }

        public StrExc02(string txt)
        {
            Text = txt;
            Number = 4;
            Symb = 'M';
        }

        public void Show()
        {
            Console.WriteLine(Number);
            Console.WriteLine(Symb);
            Console.WriteLine(Text);
        }
        
    }

    class Exc02
    {
        public static void MainExc02()
        {
            StrExc02 A=new StrExc02();
            A.Show();
            StrExc02 B = new StrExc02("Text");
            B.Show();
            StrExc02 C = new StrExc02(13, "TText");
            C.Show();
            StrExc02 D = new StrExc02(8, 'R', "Tetetetete");
            D.Show();

        }
    }
}
