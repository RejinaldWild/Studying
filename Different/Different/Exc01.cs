using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class Exc01
    {
        public static void MainExc01()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            string question, title;
            MessageBoxIcon icon;
            DialogResult answer = MessageBox.Show
                (question = "What's the number in my mind? From 1 to 10",
                title = "Guess number", 
                MessageBoxButtons.OK,
                icon = MessageBoxIcon.Question);
            TextBox result = new TextBox();         //???
            result.Text = Console.ReadLine();
            int num = 2;
            if(num == number)
            {
                MessageBox.Show("Gratz! You guessed!");
            }
            else
            {                
                while (true)
                {
                    answer = MessageBox.Show(question = "Do you want to try again?",
                        title = "One more chance",
                        MessageBoxButtons.YesNo,
                        icon = MessageBoxIcon.Error);
                    if (answer == DialogResult.Yes)
                    {
                        answer = MessageBox.Show
                            (question = "What's the number in my mind? From 1 to 10, " +
                            "it is the same number that was previous",
                            title = "Guess number again",
                            MessageBoxButtons.OK,
                            icon = MessageBoxIcon.Question);
                    }
                    else break;
                }
            }

        }
    }
}
