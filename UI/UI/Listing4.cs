using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL4 : Form
    {
        private string[] Animals = { "Wolf", "Fox", "Bear", "Raccoon" };
        private string[] Files = { "Wolf.jpg", "Fox.jpg", "Bear.jpg", "Raccoon.jpg" };
        private string Path = "D:/Programming/GitHubProject/Studying/UI/";
        private int Index = 0;
        private Label pict;
        private ComboBox lists;
        public MyFormL4() : base()
        {
            Text = "Discovery";
            Size = new Size(600, 400);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            pict = new Label();
            pict.SetBounds(5, 5, 400, 300);
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Image = Image.FromFile(Path + Files[Index]);
            Controls.Add(pict);

            lists = new ComboBox();
            lists.Items.AddRange(Animals);
            lists.DropDownStyle = ComboBoxStyle.DropDownList;
            lists.SelectedIndex = Index;
            lists.Left = pict.Right + 5;
            lists.Top = pict.Top;
            lists.Size = new Size(110, 50);
            lists.Font = new Font("Courier New", 12, FontStyle.Bold);
            lists.SelectedIndexChanged += OnItemChanged;
            Controls.Add(lists);

            Button button = new Button();
            button.Text = "OK";
            button.Left = lists.Left;
            button.Top = lists.Bottom + 10;
            button.Width = lists.Width;
            button.Height = 30;
            button.Font = lists.Font;
            button.Click += OnButtonClick;
            Controls.Add(button);
        }

        private void OnItemChanged(object obj,EventArgs ea)
        {
            int index = lists.SelectedIndex;
            pict.Image = Image.FromFile(Path + Files[index]);
        }

        private void OnButtonClick (object obj, EventArgs ea)
        {
            Application.Exit();
        }
    }


    class Listing4
    {
        [STAThread]
        public static void ListingMain04()
        {
            Application.Run(new MyFormL4());
        }
    }
}
