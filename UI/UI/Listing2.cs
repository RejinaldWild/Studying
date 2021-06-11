using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL2 : Form
    {
        private Color BaseColor;
        public MyFormL2(string txt) : base()
        {
            Text = txt;
            Height = 200;
            Width = 300;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            BaseColor = BackColor;
            MouseEnter += (a, b) =>
            {
                BackColor = Color.Yellow;
            };
            MouseLeave += (a, b) =>
            {
                BackColor = BaseColor;
            };            
        }

        public static void Show(string txt)
        {
            Application.Run(new MyFormL2(txt));
        }
    }

    class Listing2
    {
        [STAThread]
        public static void ListingMain02()
        {
            MyFormL2.Show("First");
            MyFormL2.Show("Second");
        }

    }
}
