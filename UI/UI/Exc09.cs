using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    internal class MyFormExc09 : Form
    {
        TextBox FontStyleTextBox = new TextBox();
        MainMenu MenuFonts = new MainMenu();

        public MyFormExc09() : base()
        {
            Width = 600;
            Height = 150;
            Text = "TextPlaying";
            MaximizeBox = false;
            FontStyleTextBox.SetBounds(10, 10, 500, 150);
            FontStyleTextBox.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            FontStyleTextBox.Text = "TimesNewRoman, 13, Regular";
            Controls.Add(FontStyleTextBox);

            MenuItem program = MenuFonts.MenuItems.Add("Program");
            MenuItem font = MenuFonts.MenuItems.Add("Font");
            MenuItem fontSize = MenuFonts.MenuItems.Add("Font Size");
            MenuItem fontStyle = MenuFonts.MenuItems.Add("Font Style");
            Menu = MenuFonts;

            MenuItem exit = new MenuItem("Exit");
            program.MenuItems.Add(exit);
            exit.Click += (x, y) =>
            {
                Application.Exit();
            };

            MenuItem timesNewRoman = new MenuItem("Times New Roman");
            MenuItem comicSansMS = new MenuItem("Comic Sans MS");
            font.MenuItems.Add(timesNewRoman);            
            timesNewRoman.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font("Times New Roman", FontStyleTextBox.Font.Size, FontStyleTextBox.Font.Style);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };

            font.MenuItems.Add(comicSansMS);
            comicSansMS.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font("Comic Sans MS", FontStyleTextBox.Font.Size, FontStyleTextBox.Font.Style);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };

            MenuItem sizeSmall = new MenuItem("Small Size");
            MenuItem sizeMedium = new MenuItem("Medium Size");
            MenuItem sizeBig = new MenuItem("Big Size");
            fontSize.MenuItems.Add(sizeSmall);
            sizeSmall.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, 8, FontStyleTextBox.Font.Style);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };

            fontSize.MenuItems.Add(sizeMedium);
            sizeMedium.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, 13, FontStyleTextBox.Font.Style);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };

            fontSize.MenuItems.Add(sizeBig);
            sizeBig.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, 25, FontStyleTextBox.Font.Style);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };

            MenuItem italic = new MenuItem("Italic");
            MenuItem bold = new MenuItem("Bold");
            MenuItem regular = new MenuItem("Regular");
            fontStyle.MenuItems.Add(italic);
            fontStyle.MenuItems.Add(bold);
            fontStyle.MenuItems.Add(regular);

            italic.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, FontStyleTextBox.Font.Size, FontStyle.Italic);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };
            bold.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, FontStyleTextBox.Font.Size, FontStyle.Bold);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };
            regular.Click += (x, y) =>
            {
                FontStyleTextBox.Font = new Font(FontStyleTextBox.Font.Name, FontStyleTextBox.Font.Size, FontStyle.Regular);
                FontStyleTextBox.Text = (FontStyleTextBox.Font.Name + ", " + FontStyleTextBox.Font.Size + ", " + FontStyleTextBox.Font.Style).ToString();
            };
        }
    }

    internal class Exc09
    {
        [STAThread]
        public static void ExcMain09()
        {
            Application.Run(new MyFormExc09());
        }
    }
}
