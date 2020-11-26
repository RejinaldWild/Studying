using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class SeventhEx
    {
        public string text;
        public SeventhEx (string txt)
        {
            text = txt;
        }
        public static int operator~(SeventhEx obj)
        {
            int num = 0;
            return num = obj.text.Length;
        }
        public static char operator-(SeventhEx obj)
        {
            return obj.text[0];
        }
        public static SeventhEx operator +(int num, SeventhEx obj)
        {
            SeventhEx result = new SeventhEx("");
            for (int i = 0; i < num; i++)
            {
                result.text += 'A';
            }
            return result;
        }
        public static SeventhEx operator +(SeventhEx obj,int num)
        {
            SeventhEx result = new SeventhEx("");
            result.text = new String('A', num);
            return result;
        }
        // Для вывода на консоль надо переопределять метод ToString(), задание не предполагает этого, а программа работает исправно

        public static void SeventhExs()
        {
            SeventhEx A = new SeventhEx("Hello");
            int lenghtOfText = ~A;
            Console.WriteLine(lenghtOfText);
            char firstSymbol = -A;
            Console.WriteLine(firstSymbol);
            string textA = (6+A).ToString();
            Console.WriteLine(textA);
            string textB = (A + 3).ToString();
            Console.WriteLine(textB);
        }
    }
}
