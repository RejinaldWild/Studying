using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Listing0607
    {
        public static void MainListing0607()
        {
            string pathFrom = "D:/Programming/GitHubProject/Studying/Different/";
            string pathTo = "D:/";
            string file = "photo_2021-05-05_13-07-32.jpg";
            string name = "spider-man avatar.jpg";
            string f = pathFrom + file;
            string F = pathTo + name;
            try
            {
                FileStream fin = new FileStream(f, FileMode.Open);
                Console.WriteLine("Source file: \"{0}\"",f);
                FileStream fout = new FileStream(F, FileMode.Create);
                Console.WriteLine("New file: \"{0}\"",F);

                //fin.CopyTo(fout);// start
                int val = fin.ReadByte();           
                while (val != -1)
                {
                    fout.WriteByte((byte)val);
                    val = fin.ReadByte();
                }
                // end
                fout.Close();
                fin.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error! Error!");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("Copying file was successed");
        }
    }
}
