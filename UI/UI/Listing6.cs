using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyButtonL6 : Button
    {
        public MyButtonL6(string name):base()
        {
            Text = name;
            Click += (x, y) =>
            {
                Application.Exit();
            };
        }
    }

    class MyFormL6 : Form
    {
        private string[] Animals = { "Wolf", "Fox", "Bear", "Raccoon" };
        private string[] Files = { "Wolf.jpg", "Fox.jpg", "Bear.jpg", "Raccoon.jpg" };
        private string Path = "D:/Programming/GitHubProject/Studying/UI/";
        private int Index = 0;
        private Label pict;
        private RadioButton[] radio;
        public MyFormL6() : base()
        {
            Width = 400;
            Height = 200;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 300);
            Text = "Discovery";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Panel mainPanel = new Panel();
            mainPanel.Width = ClientSize.Width - 10;
            mainPanel.Height = ClientSize.Height - 10;
            mainPanel.Left = 5;
            mainPanel.Top = 5;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;

            pict = new Label();
            pict.SetBounds(5, 5, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Image = Image.FromFile(Path + Files[Index]);

            mainPanel.Controls.Add(pict);

            radio = new RadioButton[Animals.Length];
            GroupBox gb = new GroupBox();
            gb.Left = pict.Right + 5;
            gb.Top = pict.Top;
            gb.Width = 200;
            gb.Height = pict.Height;
            gb.Text = "Your choice";
            gb.Font = new Font("Courier New", 12, FontStyle.Bold);

            int h = 17;
            for(int k = 0; k < radio.Length; k++)
            {
                radio[k] = new RadioButton();
                radio[k].Text = Animals[k];
                radio[k].Checked = (k == Index);
                radio[k].SetBounds(10, 20 + k * (h + 4), 100, h);
                radio[k].CheckedChanged +=OnRadioClick;
                gb.Controls.Add(radio[k]);
            }

            mainPanel.Controls.Add(gb);

            MyButtonL6 button = new MyButtonL6("OK");
            button.Width = mainPanel.Width / 3;
            button.Height = 30;
            button.Left = mainPanel.Width / 3;
            button.Top = pict.Bottom + 5;
            button.Font = gb.Font;

            mainPanel.Controls.Add(button);
            Controls.Add(mainPanel);
        }

        private void OnRadioClick(object obj, EventArgs ea)
        {
            for(int k = 0; k < radio.Length; k++)
            {
                if (radio[k].Checked)
                {
                    pict.Image = Image.FromFile(Path + Files[k]);
                    return;
                }
            }
        }
    }

    class Listing6
    {
        [STAThread]
        public static void ListingMain06()
        {
            Application.Run(new MyFormL6());
        }
    }
}
