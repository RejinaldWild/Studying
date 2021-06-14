using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL9 : Form
    {
        private TextBox Tb;
        private Label Lbl;

        private bool CheckIt(string name)
        {
            switch (name)
            {
                case "Wolf":
                case "Fox":
                case "Bear":
                case "Raccoon":
                default:
                    return false;
            }
        }

        private string GetFile(string name)
        {
            string Path = "D:/Programming/GitHubProject/Studying/UI/";
            string res = "";
            switch (name)
            {
                case "Wolf":
                    res = "Wolf.jpg";
                    break;
                case "Fox":
                    res = "Fox.jpg";
                    break;
                case "Bear":
                    res = "Bear.jpg";
                    break;
                case "Raccoon":
                    res = "Raccoon.jpg";
                    break;
            }
            return Path + res;
        }

        public MyFormL9() : base()
        {
            int h = 550;
            int w = 600;
            Width = w + 25;
            Height = 700;
            Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterScreen;

            Tb = new TextBox();
            Tb.Location = new Point(5, 5);
            Tb.Width = w;
            Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Tb.KeyUp += (x, y) =>
            {
                if (CheckIt(Tb.Text))
                {
                    Text = Tb.Text;
                    Lbl.Image = Image.FromFile(GetFile(Tb.Text));
                }
            };
            Controls.Add(Tb);

            Lbl = new Label();
            Lbl.Top = Tb.Bottom + 5;
            Lbl.Left = 5;
            Lbl.Size = new Size(w, h);
            Lbl.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Lbl);

            CheckBox option = new CheckBox();
            option.Width = w;
            option.Height = 20;
            option.Left = 5;
            option.Top = Lbl.Bottom + 5;
            option.Text = "Block text field";
            option.CheckedChanged += (x, y) =>
            {
                Tb.Enabled = !option.Checked;
                Tb.Text = "";
            };
            Controls.Add(option);

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Wolf");
            menu.Items.Add("Fox");
            menu.Items.Add("Bear");
            menu.Items.Add("Raccoon");
            for(int i = 0; i < menu.Items.Count; i++)
            {
                menu.Items[i].Click += (x, y) =>
                {
                    string txt = ((ToolStripMenuItem)x).Text;
                    Lbl.Image = Image.FromFile(GetFile(txt));
                    Text = txt;
                    option.Checked = true;
                };
            }
            Lbl.ContextMenuStrip = menu;

            Button button = new Button();
            button.Text = "OK";
            button.SetBounds(5, option.Bottom + 5, w, 30);
            button.Click += (x, y) =>
            {
                Application.Exit();
            };

            Controls.Add(button);
            menu.Items[0].PerformClick();
        }
    }

    class Listing9
    {
        [STAThread]
        public static void ListingMain09()
        {
            Application.Run(new MyFormL9());
        }
    }
}
