using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc05 : Form
    {
        TextBox Tb1 = new TextBox();
        TextBox Tb2 = new TextBox();
        Label InfoLabel = new Label();
        public MyFormExc05():base()
        {
            Text = "More,Less or Equal?";
            Width = 300;
            Height = 200;

            Tb1.Width = 200;
            Tb1.Location = new Point(10, 10);
            Tb1.Height = 20;
            Tb1.Font = new Font("Comic Sans MS", 10, FontStyle.Regular);

            Tb2.Width = 200;            
            Tb2.Height = 20;
            Tb2.Left = Tb1.Left;
            Tb2.Top = Tb1.Bottom + 10;
            Tb2.Font = new Font("Comic Sans MS", 10, FontStyle.Regular);

            InfoLabel.Width = 200;
            InfoLabel.Height = 50;
            InfoLabel.BorderStyle = BorderStyle.Fixed3D;
            InfoLabel.Left = Tb1.Left;
            InfoLabel.Top = Tb2.Bottom + 10;
            InfoLabel.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

            Controls.Add(Tb1);
            Controls.Add(Tb2);
            Controls.Add(InfoLabel);

            Tb1.KeyUp += Comparing;
            Tb2.KeyUp += Comparing;
        }

        public void Comparing(object obj, EventArgs ea)
        {
            try
            {   
                int num1 = Convert.ToInt32(Tb1.Text);
                int num2 = Convert.ToInt32(Tb2.Text);
                if (num1 > num2)
                {
                    InfoLabel.Text = "The first number is bigger than second";
                }
                else if (num1 < num2)
                {
                    InfoLabel.Text = "The first number is lower than second";
                }
                else
                {
                    InfoLabel.Text = "The numbers are equal";
                }
            }
            catch(FormatException ex)
            {
                InfoLabel.Text = ex.Message;
            }
            
        }
    }

    internal class Exc05
    {
        [STAThread]
        public static void ExcMain06()
        {
            Application.Run(new MyFormExc05());
        }
    }
}
