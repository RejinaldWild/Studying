using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Listing08
    {
        public static void MainListing08()
        {
            string file = "C:/Users/Hero/Desktop/MyTestText.txt";
            string str;
            string word = "exit";
            int k = 1;
            try
            {
                StreamWriter fw = new StreamWriter(file);
                Console.WriteLine("Please, write to quit: \"{0}\"",word);
                do
                {
                    Console.WriteLine("{0}th string: >", k);
                    k++;
                    str = Console.ReadLine();
                    if (str == word) break;
                    else fw.WriteLine(str);
                }
                while (true);
                fw.Close();
                Console.WriteLine("File was created!");
                StreamReader fr = new StreamReader(file);
                Console.WriteLine("Into file:");
                str = fr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = fr.ReadLine();
                }
                fr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error! Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
