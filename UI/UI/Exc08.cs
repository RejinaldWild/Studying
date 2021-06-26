using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc08 : Form
    {
        string[] NameColours = { "Yellow", "Purple", "Green" };
        ContextMenuStrip ContextColours = new ContextMenuStrip();
        Label LabelColour = new Label();

        public MyFormExc08() : base()
        {
            Text = "Context Colouring";
            Width = 225;
            Height = 225;
            MaximizeBox = false;

            LabelColour.SetBounds(15, 15, 150, 150);
            LabelColour.BorderStyle = BorderStyle.Fixed3D;

            for(int i = 0; i < NameColours.Length; i++)
            {
                ContextColours.Items.Add(NameColours[i]);
            }
            for (int i = 0; i < ContextColours.Items.Count; i++)
            {
                ContextColours.Items[i].Click += (x, y) =>
                {
                    string txt = ((ToolStripMenuItem)x).Text;
                    switch (txt)
                    {
                        case "Yellow":
                            LabelColour.BackColor = Color.Yellow;
                            break;
                        case "Purple":
                            LabelColour.BackColor = Color.Purple;
                            break;
                        case "Green":
                            LabelColour.BackColor = Color.Green;
                            break;
                    }

                };
            }   

            Controls.Add(LabelColour);
            LabelColour.ContextMenuStrip = ContextColours;
        }
    }

    internal class Exc08
    {
        [STAThread]
        public static void ExcMain08()
        {
            Application.Run(new MyFormExc08());
        }
    }
}
