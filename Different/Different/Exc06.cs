using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc06
    {
        public static void MainExc06()
        {
            string pathFrom = "D:/Programming/GitHubProject/Studying/Different/";
            string pathTo = "D:/Programming/GitHubProject/Studying/Different/";
            string nameFile = "Test01.txt";
            string nameFileNew = "NewTest01.txt";
            string fileFrom = pathFrom + nameFile;
            string fileNew = pathTo + nameFileNew;
            try
            {
                //1st
                //StreamReader FileRead = new StreamReader(fileFrom);
                //StreamWriter FileWrite = new StreamWriter(fileNew);
                //string text = FileRead.ReadToEnd();
                //text = text.ToLower();
                //text = text.Replace(" ", "_");
                //FileWrite.Write(text, 0, text.Length);
                //FileWrite.Close();
                //FileRead.Close();

                //2nd
                FileStream FileRead = new FileStream(fileFrom, FileMode.Open);
                FileStream FileWrite = new FileStream(fileNew, FileMode.Create);
                FileRead.CopyTo(FileWrite);
                FileWrite.Close();
                FileRead.Close();
                string text = File.ReadAllText(fileFrom);
                text = text.ToLower();
                text = text.Replace(" ", "_");                
                File.WriteAllText(fileNew, text);              
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
