using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc02 : Form
    {
        public MyFormExc02() : base()
        {
            Text = "Clicker!";            
            Width = 200;
            Height = 200;
            MaximizeBox = false;

            TextBox number = new TextBox();
            number.Width = Width - 10;
            number.Location = new Point(5, 5);
            number.Text = "0";
            Controls.Add(number);

            Button plus = new Button();
            plus.Text = "+";
            plus.Width = 50;
            plus.Height = 30;
            plus.Left = number.Left;
            plus.Top = number.Bottom + 5;
            plus.Click += (x, y) =>
            {
                number.Text = (Convert.ToInt32(number.Text) + 1).ToString();
            };
            Controls.Add(plus);
            
            Button exit = new Button();
            exit.Text = "Exit";
            exit.Width = 50;
            exit.Height = 30;
            exit.Left = plus.Right+10;
            exit.Top = number.Bottom + 5;
            exit.Click += (x, y) =>
            {
                Application.Exit();
            };
            Controls.Add(exit);

            Button minus = new Button();
            minus.Text = "-";
            minus.Width = 50;
            minus.Height = 30;
            minus.Left = exit.Right + 10;
            minus.Top = number.Bottom + 5;
            minus.Click += (x, y) =>
            {
                number.Text = (Convert.ToInt32(number.Text) - 1).ToString();
            };
            Controls.Add(minus);
        }
    }

    internal class Exc02
    {
        [STAThread]
        public static void ExcMain02()
        {
            Application.Run(new MyFormExc02());
        }
    }
}
