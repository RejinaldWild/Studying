using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class SecondClass
    {
        public char firstLetter, secondLetter;
        public void FromLetterToLetter()
        {
            char letter;
            if (firstLetter <= secondLetter)
            {
                for (int i = firstLetter; i <= secondLetter; i++)
                {
                    letter = (char)i;
                    Console.Write($"{letter}\t");
                }
            }
            else
            {
                for (int i = secondLetter; i <= firstLetter; i++)
                {
                    letter = (char)i;
                    Console.Write($"{letter}\t");
                }
            }
            Console.WriteLine();
        }
    }
}
