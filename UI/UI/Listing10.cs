using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL10 : Form
    {
        Pen P;
        Graphics G;
        public MyFormL10() : base()
        {
            Width = 325;
            Height = 380;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Text = "Mouse Coordinates";

            Label Lbl = new Label();
            Lbl.Width = 300;
            Lbl.Height = 30;
            Lbl.Location = new Point(5, 5);
            Lbl.BorderStyle = BorderStyle.Fixed3D;
            Lbl.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            Lbl.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(Lbl);

            Panel Pnl = new Panel();
            Pnl.Width = Lbl.Width;
            Pnl.Height = 300;
            Pnl.Top = Lbl.Bottom + 5;
            Pnl.Left = Lbl.Left;
            Pnl.BorderStyle = BorderStyle.Fixed3D;
            Pnl.BackColor = Color.Yellow;
            Pnl.Cursor = Cursors.Hand;

            P = new Pen(Color.Violet,3);
            G = Pnl.CreateGraphics();

            Pnl.MouseMove += (obj, ea) =>
            {
                Pnl.Refresh();
                Lbl.Text = "Horizontal: " + ea.X;
                Lbl.Text += "    ";
                Lbl.Text += "Vertical: " + ea.Y;
                G.DrawLine(P, new Point(0, ea.Y), new Point(Pnl.ClientSize.Width, ea.Y));
                G.DrawLine(P, new Point(ea.X, 0), new Point(ea.X, Pnl.ClientSize.Height));
            };

            Pnl.MouseLeave += (obj, ea) =>
            {
                Lbl.Text = "";
                Pnl.Refresh();
            };
            Controls.Add(Pnl);
        }

        ~MyFormL10()
        {
            G.Dispose();
            P.Dispose();
        }
    }

    class Listing10
    {
        [STAThread]
        public static void ListingMain10()
        {
            Application.Run(new MyFormL10());
        }
    }
}
