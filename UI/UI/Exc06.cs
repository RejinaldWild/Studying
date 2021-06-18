using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc06 : Form
    {
        string[] Names = { "Spidey.jpg", "Venom.jpg", "MJ.jpg", "SPMJ.jpg" };
        string Path = "D:\\Programming\\GitHubProject\\Studying\\UI\\";
        int Index = 0;
        Button Previous = new Button();
        Button Next = new Button();
        Label Picture = new Label();
        public MyFormExc06() : base()
        {
            Text = "Spider-man Pictures";
            Width = 800;
            Height = 800;
            MaximizeBox = false;

            Picture.SetBounds(10,10,Width-30, Height - 100);
            Picture.BorderStyle = BorderStyle.Fixed3D;
            Picture.Image = Image.FromFile(Path+Names[Index]);
            Controls.Add(Picture);

            Previous.Width = 40;
            Previous.Height = 20;
            Previous.Text = "<=";
            Previous.Left = Width / 3 + 10;
            Previous.Top = Picture.Bottom + 20;
            Controls.Add(Previous);

            Previous.Click += (x, y) =>
            {   
                if (Index == 0) Index = Names.Length-1;
                else Index--;
                Picture.Image = Image.FromFile(Path + Names[Index]);
            };

            Next.Width = 40;
            Next.Height = 20;
            Next.Text = "=>";
            Next.Left = 2*(Width / 3) + 10 + Previous.Width/2;
            Next.Top = Picture.Bottom + 20;
            Controls.Add(Next);

            Next.Click += (x, y) =>
            {   
                if (Index == Names.Length-1) Index = 0;
                else Index++;
                Picture.Image = Image.FromFile(Path + Names[Index]);
            };
        }
    }

    internal class Exc06
    {
        [STAThread]
        public static void ExcMain06()
        {
            Application.Run(new MyFormExc06());
        }
    }
}
