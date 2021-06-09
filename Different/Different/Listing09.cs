using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Listing09
    {
        public static void MainListing09()
        {
            int num = 13;
            char symb = 'R';
            double x = 8.4;
            string txt = "wow!";
            string file = "C:/Users/Hero/Desktop/MyData.dat";
            Console.WriteLine("Writing data in file...");
            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
                bw.Write(num);
                bw.Write(symb);
                bw.Write(x);
                bw.Write(txt);
                bw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops!");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("File was created \"{0}\"",file);
            Console.WriteLine("Reading data in file...");
            try
            {
                BinaryReader br = new BinaryReader(new FileStream(file, FileMode.Open));                
                Console.WriteLine(br.ReadInt32());                
                Console.WriteLine(br.ReadChar());
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadString());
                br.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erreading!");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Programm has done!");
        }
    }
}
