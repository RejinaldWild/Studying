using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    class MyFormL8 : Form
    {   
        private string Path = "D:/Programming/GitHubProject/Studying/UI/";
        private Label pict;
        private Button button;
        public MyFormL8() : base()
        {
            Size = new Size(550, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discovery";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MainMenu menu = new MainMenu();
            MenuItem programm = new MenuItem("Programm");
            programm.MenuItems.Add("Exit", OnButtonClick);
            MenuItem beautyful = new MenuItem("Beautyful");
            MenuItem fox = new MenuItem("Fox");
            fox.Click += (x, y) =>
            {
                Set("Fox", "Fox.jpg");
            };
            MenuItem raccoon = new MenuItem("Raccoon");
            raccoon.Click += (x, y) =>
            {
                Set("Raccoon", "Raccoon.jpg");
            };
            beautyful.MenuItems.Add(fox);
            beautyful.MenuItems.Add(raccoon);

            MenuItem strong = new MenuItem("Strong");
            MenuItem bear = new MenuItem("Bear");
            bear.Click += (x, y) =>
            {
                Set("Bear", "Bear.jpg");
            };
            MenuItem wolf = new MenuItem("Wolf");
            wolf.Click += (x, y) =>
            {
                Set("Wolf", "Wolf.jpg");
            };
            strong.MenuItems.Add(wolf);
            strong.MenuItems.Add(bear);
            menu.MenuItems.Add(programm);
            menu.MenuItems.Add(beautyful);
            menu.MenuItems.Add(strong);
            Menu = menu;

            ToolStrip tools = new ToolStrip();
            ToolStripButton toolSButtonA = new ToolStripButton(Image.FromFile(Path + "Fox.jpg"));
            ToolStripButton toolSButtonB = new ToolStripButton(Image.FromFile(Path + "Raccoon.jpg"));
            ToolStripButton toolSButtonC = new ToolStripButton(Image.FromFile(Path + "Wolf.jpg"));
            ToolStripButton toolSButtonD = new ToolStripButton(Image.FromFile(Path + "Bear.jpg"));
            toolSButtonA.ToolTipText = "Fox";
            toolSButtonB.ToolTipText = "Raccoon";
            toolSButtonC.ToolTipText = "Wolf";
            toolSButtonD.ToolTipText = "Bear";

            toolSButtonA.Click += (x, y) => fox.PerformClick();
            toolSButtonB.Click += (x, y) => raccoon.PerformClick();
            toolSButtonC.Click += (x, y) => wolf.PerformClick();
            toolSButtonD.Click += (x, y) => bear.PerformClick();

            tools.Items.Add(toolSButtonA);
            tools.Items.Add(toolSButtonB);
            tools.Items.Add(toolSButtonC);
            tools.Items.Add(toolSButtonD);
            Controls.Add(tools);

            pict = new Label();
            pict.SetBounds(35, 25, 450, 450);
            pict.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pict);

            button = new Button();
            button.Left = pict.Left + 20;
            button.Top = pict.Bottom + 10;
            button.Width = pict.Width - 40;
            button.Height = 30;
            button.Font = new Font("Comic Sans MS", 13, FontStyle.Bold);
            button.Click += OnButtonClick;
            Controls.Add(button);
            wolf.PerformClick();
        }

        private void Set(string name,string file)
        {
            button.Text = name;
            pict.Image = Image.FromFile(Path + file);
        }

        private void OnButtonClick(object obj,EventArgs ea)
        {
            Application.Exit();
        }
    }

    class Listing8
    {
        [STAThread]
        public static void ListingMain08()
        {
            Application.Run(new MyFormL8());
        }
    }
}
