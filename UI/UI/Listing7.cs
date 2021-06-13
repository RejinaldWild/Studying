using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyInputBoxL7 : Form
    {
        private class MyFormL7 : Form
        {
            private string[] Animals = { "Wolf", "Fox", "Bear", "Raccoon" };
            private string[] Files = { "Wolf.jpg", "Fox.jpg", "Bear.jpg", "Raccoon.jpg" };
            private string Path = "D:/Programming/GitHubProject/Studying/UI/";
            public MyFormL7(string t,bool state) : base()
            {
                string txt = "Giraffe";
                string file = "Giraffe.jpg";
                for(int k = 0; k < Animals.Length; k++)
                {
                    if ((t == Animals[k]) || ((t.ToLower() == Animals[k].ToLower()) & state))
                    {
                        txt = Animals[k];
                        file = Files[k];
                        break;
                    }
                }
                Text = txt;
                Font = new Font("Comic Sans MC", 12, FontStyle.Bold);
                FormBorderStyle = FormBorderStyle.Fixed3D;
                MaximizeBox = false;
                Image img = Image.FromFile(Path + file);
                int h = img.Height;
                int w = img.Width;

                Label lbl = new Label();
                lbl.Image = img;
                lbl.SetBounds(10, 10, w + 4, h + 4);
                lbl.BorderStyle = BorderStyle.FixedSingle;

                Button button = new Button();
                button.Text = "OK";
                button.SetBounds(w / 4 + 10, lbl.Bottom + 5, w / 2, 30);
                button.Click += (x, y) =>
                {
                    Application.Exit();
                };

                Size = new Size(w + 40, button.Bottom + 50);
                StartPosition = FormStartPosition.CenterScreen;
                Controls.Add(lbl);
                Controls.Add(button);
            }
        }

        private CheckBox Option;
        private Button Ok;
        private Button Cancel;
        private TextBox TextInput;
        public MyInputBoxL7() : base()
        {
            Size = new Size(900, 900);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Call the animal";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Font = new Font("Times New Roman", 18, FontStyle.Regular);

            Label lbl = new Label();
            lbl.Text = "What animal you want to see?";
            lbl.Height = 30;
            lbl.Width = Width - 30;
            lbl.Left = 10;
            lbl.Top = 10;
            Controls.Add(lbl);

            TextInput = new TextBox();
            TextInput.Width = Width - 30;
            TextInput.Left = lbl.Left;
            TextInput.Top = lbl.Bottom + 5;
            Controls.Add(TextInput);

            Option = new CheckBox();
            Option.Text = "Do not consider register";
            Option.Left = TextInput.Left;
            Option.Top = TextInput.Bottom + 5;
            Option.Height = 30;
            Option.Width = TextInput.Width;
            Option.Checked = true;
            Controls.Add(Option);

            Ok = new Button();
            Ok.Text = "OK";
            Ok.Width = Width / 2 - 20;
            Ok.Height = 30;
            Ok.Left = TextInput.Left;
            Ok.Top = Option.Bottom + 5;
            Ok.Click +=OnButtonsClick;

            Cancel = new Button();
            Cancel.Text = "Cancel";
            Cancel.Size = Ok.Size;
            Cancel.Top = Ok.Top;
            Cancel.Left = TextInput.Right - Cancel.Width;
            Cancel.Click += OnButtonsClick;

            Controls.Add(Ok);
            Controls.Add(Cancel);
        }

        public static void ShowInputBox()
        {
            Application.Run(new MyInputBoxL7());
        }

        public void OnButtonsClick(object obj, EventArgs ea)
        {
            Button button = (Button)obj;
            if (button == Ok)
            {
                Visible = false;
                new MyFormL7(TextInput.Text, Option.Checked).ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }
    }

    class Listing7
    {
        [STAThread]
        public static void ListingMain07()
        {
            MyInputBoxL7.ShowInputBox();
        }
    }
}
