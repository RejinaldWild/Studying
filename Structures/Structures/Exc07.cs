using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc07
    {
        public char Symb;
    }

    class Exc07
    {
        public static StrExc07[] TextCh(string txt)
        {
            StrExc07[] A = new StrExc07[txt.Length];
            for(int i = 0; i < txt.Length; i++)
            {
                A[i].Symb = txt[i];
            }
            return A;
        }

        public static string CharTxt(StrExc07[] A)
        {
            string text = "";
            for(int i = 0; i < A.Length; i++)
            {
                text += A[i].Symb.ToString();
            }
            return text;
        }

        public static void MainExc07()
        {
            StrExc07 A;
            A.Symb = 'a';
            string texty = "comeon!";
            CharTxt(TextCh(texty));
        }
    }
}
