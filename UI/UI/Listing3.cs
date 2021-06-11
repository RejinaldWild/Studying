using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL3 : Form
    {
        public MyFormL3 (string msg,string title) : base()
        {
            this.Text = title;
            this.Size = new Size(300, 140);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            string file = "D:\\covid_coronavirus_cough_coughing_flu_icon_189128.ico";
            this.Icon = new Icon(file);
            Label helloLabel = new Label();
            helloLabel.Text = msg;
            helloLabel.Location = new Point(10, 10);
            helloLabel.Width = 265;
            helloLabel.Height = 40;
            helloLabel.TextAlign = ContentAlignment.MiddleCenter;
            helloLabel.BorderStyle = BorderStyle.Fixed3D;
            Font font = new Font("Comic Sans MS", 13, FontStyle.Italic);
            helloLabel.Font = font;
            helloLabel.ForeColor = Color.Purple;
            this.Controls.Add(helloLabel);

            Button buttonClose = new Button();
            buttonClose.Text = "Close";
            buttonClose.Bounds = new Rectangle(100, 60, 90, 30);
            buttonClose.Font = new Font(buttonClose.Font.Name,
                buttonClose.Font.Size + 3,
                FontStyle.Underline | FontStyle.Bold);
            buttonClose.Click += delegate (object a, EventArgs b)
              {
                  Application.Exit();
              };
            this.Controls.Add(buttonClose);
        }
    }
    class Listing3
    {
        [STAThread]
        public static void ListingMain03()
        {
            MyFormL3 mainForm = new MyFormL3("Everybody hi!", "Form with a button");
            Application.Run(mainForm);
        }
    }
}
