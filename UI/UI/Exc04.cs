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
            TextBox txt = new TextBox();
            Label txtLabel = new Label();
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
