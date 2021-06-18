using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc04 : Form
    {
        public MyFormExc04() : base()
        {
            Width = 300;
            Height = 200;
            Text = "Texting";
            TextBox txt = new TextBox();
            Label txtLabel = new Label();
            Button italian = new Button();
            Button bold = new Button();
            txt.Width = 200;
            txt.Height = 20;
            txt.Location = new Point(40, 5);
            txt.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            Controls.Add(txt);

            txtLabel.Width = 200;
            txtLabel.Height = 20;
            txtLabel.BorderStyle = BorderStyle.Fixed3D;
            txtLabel.Left = txt.Left;
            txtLabel.Top = txt.Bottom + 20;
            Controls.Add(txtLabel);

            italian.Text = "I";
            italian.Width = 20;
            italian.Height = 20;
            italian.Left = (txtLabel.Width / 3)+txtLabel.Left;
            italian.Top = txtLabel.Bottom + 20;
            italian.Width = 20;
            Controls.Add(italian);

            bold.Text = "B";
            bold.Width = 20;
            bold.Height = 20;
            bold.Top = txtLabel.Bottom + 20;
            bold.Left = (txtLabel.Width * 2 / 3) + txtLabel.Left + italian.Width;
            bold.Width = 20;
            Controls.Add(bold);

            txt.KeyUp += (x, y) =>
            {
                txtLabel.Text = txt.Text;
            };

            italian.Click += (x, y) =>
            {
                if (txtLabel.Font.Style == FontStyle.Italic)
                {
                    txtLabel.Font = new Font(txt.Font, FontStyle.Regular);
                }
                else
                {
                    txtLabel.Font = new Font(txt.Font, FontStyle.Italic);
                }
            };

            bold.Click += (x, y) =>
            {
                if (txtLabel.Font.Style == FontStyle.Bold)
                {
                    txtLabel.Font = new Font(txt.Font, FontStyle.Regular);
                }
                else
                {
                    txtLabel.Font = new Font(txt.Font, FontStyle.Bold);
                }
            };
        }
    }

    internal class Exc04
    {
        [STAThread]
        public static void ExcMain04()
        {
            Application.Run(new MyFormExc04());
        }
    }
}
