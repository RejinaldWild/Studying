using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class Listing1
    {
        [STAThread] // использовать в мейне, однопоточность, UI подразумевает однопоточность приложения
        public static void ListingMain01()
        {            
            Form emptyWin = new Form();
            emptyWin.Text = "Simple Window";
            emptyWin.Height = 200;
            emptyWin.Width = 300;
            Application.Run(emptyWin);            
        }
    }
}
