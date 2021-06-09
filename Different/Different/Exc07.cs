using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Smartphone
    {
        public int Model = 55;
        public char Symb = 'M';
        public string Company = "Siemens";
    }

    internal class Exc07
    {
        public static void MainExc07()
        {
            Smartphone Phone = new Smartphone();
            string path = "D:/Programming/GitHubProject/Studying/Different/MyDataExc07.dat";
            try
            {
                BinaryWriter fileBWriter = new BinaryWriter(new FileStream(path, FileMode.Create));
                fileBWriter.Write(Phone.Company);
                fileBWriter.Write(Phone.Symb);
                fileBWriter.Write(Phone.Model);
                fileBWriter.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
            try
            {
                BinaryReader fileBReader = new BinaryReader(new FileStream(path, FileMode.Open));
                Console.WriteLine(fileBReader.ReadString());
                Console.WriteLine(fileBReader.ReadChar());
                Console.WriteLine(fileBReader.ReadInt32());
                fileBReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
