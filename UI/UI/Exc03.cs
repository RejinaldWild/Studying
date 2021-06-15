using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc03 : Form
    {
        private string[] Colors = { "Red", "Yellow", "Blue", "Green" };
        public MyFormExc03() : base()
        {
            Width = 300;
            Height = 300;
            Text = "Coloring Square";

            ComboBox lists = new ComboBox();            
            lists.Font = new Font("Comic Sans MS", 13, FontStyle.Bold);
            lists.Location = new Point(25, 25);
            lists.Items.AddRange(Colors);
            lists.Text = "Red";
            Controls.Add(lists);

            Label coloredLabel = new Label();            
            coloredLabel.SetBounds(lists.Right+10,lists.Top,50,50);
            coloredLabel.BorderStyle = BorderStyle.Fixed3D;
            coloredLabel.BackColor = Color.Red;
            Controls.Add(coloredLabel);

            lists.SelectedIndexChanged += (x, y) =>
            {
                int index = lists.SelectedIndex;
                switch (index)
                {
                    case 0:
                        coloredLabel.BackColor = Color.Red;
                        break;
                    case 1:
                        coloredLabel.BackColor = Color.Yellow;
                        break;
                    case 2:
                        coloredLabel.BackColor = Color.Blue;
                        break;
                    case 3:
                        coloredLabel.BackColor = Color.Green;
                        break;
                    default:
                        coloredLabel.BackColor = Color.Red;
                        break;
                }
            };
        }
    }

    internal class Exc03
    {
        [STAThread]
        public static void ExcMain03()
        {
            Application.Run(new MyFormExc03());
        }
    }
}
