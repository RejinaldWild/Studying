using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc07 : Form
    {

    }

    internal class Exc07
    {
        [STAThread]
        public static void ExcMain07()
        {
            Application.Run(new MyFormExc07());
        }
    }
}
