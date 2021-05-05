using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Different
{
    internal class Listing01
    {
        public static void MainListing01()
        {
            string msg, title;
            MessageBoxIcon icon;
            DialogResult result;
            result = MessageBox.Show("Do you like C#?", 
                "Ritorical question :D", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            {
                msg = "Welcome to team!";
                title = "That's my boy!";
                icon = MessageBoxIcon.Information;
            }
            else
            {
                msg = "OMG!";
                title = "That cannot be!";
                icon = MessageBoxIcon.Error;
            }

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}
