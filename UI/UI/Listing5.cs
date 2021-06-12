using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL5 : Form
    {   
        public MyFormL5(string[,] data,string title,string path) : base()
        {
            Text = title;
            Size = new Size(600, 400);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new Font("Times New Roman", 11, FontStyle.Italic | FontStyle.Bold);
            Label pict = new Label();
            pict.SetBounds(5, 5, 400, 300);
            pict.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pict);

            ListBox lists = new ListBox();
            lists.Size = new Size(110, 80);
            lists.Left = pict.Right + 5;
            lists.Top = pict.Top;
            for(int k = 0; k < data.GetLength(1); k++)
            {
                lists.Items.Add(data[0, k]);
            }
            lists.SelectedIndexChanged += (x, y) =>
            {
                int index = lists.SelectedIndex;
                pict.Image = Image.FromFile(path + data[1, index]);
            };
            Controls.Add(lists);

            Button button = new Button();
            button.Text = "OK";
            button.Left = lists.Left;
            button.Top = lists.Bottom -button.Height;
            button.Width = lists.Width;
            button.Height = 25;
            button.Font = lists.Font;
            button.Click += (x, y) =>
            {
                Application.Exit();
            };
            Controls.Add(button);

            lists.SetSelected(lists.Items.Count - 1, true);
        }
    }

    class Listing5
    {
        [STAThread]
        public static void ListingMain05()
        {
            string[,] data = {{ "Wolf", "Fox", "Bear", "Raccoon" },
                { "Wolf.jpg", "Fox.jpg", "Bear.jpg", "Raccoon.jpg" } };
            string title = "Discovery";
            string path = "D:/Programming/GitHubProject/Studying/UI/";
            MyFormL5 window = new MyFormL5(data, title, path);
            Application.Run(window);
        }
    }
}
