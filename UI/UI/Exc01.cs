using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc01 : Form
    {
        public MyFormExc01() : base()
        {
            Text = "Changing Window";
            Width = 200;
            Height = 200;
            Color Default = BackColor;

            Panel greeny = new Panel();
            greeny.Width = 195;
            greeny.Height = 195;
            greeny.MouseEnter += (x, y) =>
            {
                greeny.BackColor = Color.Green;
            };

            greeny.MouseLeave += (x, y) =>
            {
                greeny.BackColor = Default;
            };

            greeny.MouseClick += (x, y) =>
            {
                greeny.Width =Width + Width* 10 / 100;
                greeny.Height = Height + Height *10 / 100;
                Width = Width + Width * 10 / 100;
                Height = Height + Height * 10 / 100;
            };

            Controls.Add(greeny);
        }
    }

    internal class Exc01
    {
        [STAThread]

        public static void ExcMain01()
        {
            Application.Run(new MyFormExc01());
        }
    }
}
