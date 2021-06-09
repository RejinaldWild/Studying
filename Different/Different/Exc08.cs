using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc08
    {
        public static void MainExc08()
        {
            ArrayList Lst = new ArrayList();
            string text = "This is Awesome!";
            string[] word = text.Split(' ');
            for(int i = 0; i < word.Length; i++)
            {
                Lst.Add(word[i]);
            }
            foreach(string str in Lst)
            {
                Console.WriteLine(str);
            }
        }
    }
}
