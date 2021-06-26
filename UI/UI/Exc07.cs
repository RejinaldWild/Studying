using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc07 : Form
    {
        TextBox Txt = new TextBox();
        Label LColour = new Label();
        ListBox NameFont = new ListBox();
        ComboBox NameColour = new ComboBox();
        string[] FontList = { "Regular", "Bold", "Italic", "Comic Sans MS" };
        string[] ColourList = { "Yellow", "Purple", "Green", "Blue" };

        public MyFormExc07():base()
        {
            Width = 320;
            Height = 150;
            MaximizeBox = false;
            Text = "Texting and Colouring";

            NameFont.SetBounds(10, 10, 90, 90);
            NameFont.Items.AddRange(FontList);
            NameFont.SelectedIndexChanged += (x, y) =>
            {
                int index = NameFont.SelectedIndex;
                switch (index)
                {
                    case 0:
                        Txt.Font = new Font("Times New Roman", 13, FontStyle.Regular);
                        break;
                    case 1:
                        Txt.Font = new Font("Times New Roman", 13, FontStyle.Bold);
                        break;
                    case 2:
                        Txt.Font = new Font("Times New Roman", 13, FontStyle.Italic);
                        break;
                    case 3:
                        Txt.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);
                        break;
                }
            };

            Txt.SetBounds(NameFont.Right + 10, NameFont.Top, 100, 20);
            Txt.Font = new Font("Times New Roman", 13, FontStyle.Regular);

            LColour.SetBounds(NameFont.Right + 10, Txt.Bottom + 10, Txt.Width, 50);
            LColour.BorderStyle = BorderStyle.Fixed3D;
            LColour.BackColor = Color.Yellow;

            NameColour.SetBounds(Txt.Right + 10, NameFont.Top, 70, 200);
            NameColour.Items.AddRange(ColourList);
            NameColour.Text = "Yellow";
            NameColour.SelectedIndexChanged += (x, y) =>
            {
                int index = NameColour.SelectedIndex;
                switch (index)
                {
                    case 0:
                        LColour.BackColor = Color.Yellow;
                        break;
                    case 1:
                        LColour.BackColor = Color.Purple;
                        break;
                    case 2:
                        LColour.BackColor = Color.Green;
                        break;
                    case 3:
                        LColour.BackColor = Color.Blue;
                        break;
                }
            };

            Controls.Add(Txt);
            Controls.Add(NameColour);
            Controls.Add(NameFont);
            Controls.Add(LColour);
        }
    }

    internal class Exc07
    {
        [STAThread]
        public static void ExcMain07()
        {
            Application.Run(new MyFormExc07());
        }
    }
}
