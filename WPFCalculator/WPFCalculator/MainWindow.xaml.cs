using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lefttop = "" ;
        string operation = "" ;
        string righttop = "" ;

        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement button in LayoutRoot.Children)
            {
                if(button is Button)
                {
                    ((Button)button).Click += ButtonClick;
                }
            }
        }
        private void ButtonClick(object x,RoutedEventArgs e)
        {
            string buttonName = ((Button)e.OriginalSource).Content.ToString();
            textBlock.Text += buttonName;
            int num;
            bool isNum = Int32.TryParse(buttonName, out num);
            if (isNum == true)
            {
                if (operation == "")
                {
                    lefttop += buttonName;
                }
                else
                {
                    righttop += buttonName;
                }
            }
            else
            {
                if (buttonName == "Clear")
                {
                    lefttop = "";
                    righttop = "";
                    operation = "";
                    textBlock.Text = "";
                }
                else if (buttonName == "=")
                {
                    Operations();
                    textBlock.Text += righttop;
                    operation = "";
                }
                else
                {
                    if (righttop != "")
                    {
                        Operations();
                        lefttop = righttop;
                        righttop = "";
                    }
                    operation = buttonName;
                }
            }
        }

        private void Operations()
        {
            int num1 = Int32.Parse(lefttop);
            int num2 = Int32.Parse(righttop);
            switch (operation)
            {
                case "+":
                    righttop = (num1 + num2).ToString();
                    break;
                case "-":
                    righttop = (num1 - num2).ToString();
                    break;
                case "*":
                    righttop = (num1 * num2).ToString();
                    break;
                case "/":
                    righttop = (num1 / num2).ToString();
                    break;
            }
        }
    }
}
