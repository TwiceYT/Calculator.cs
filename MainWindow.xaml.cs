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

namespace Calcylator
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String CalTotal;
        double num1;
        double num2;
        string option;
        double results;

        string output = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonNr_click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "BtnNr1":
                    output += "1";
                    break;

                case "BtnNr2":
                    output += "2";
                    break;

                case "BtnNr3":
                    output += "3";
                    break;

                case "BtnNr4":
                    output += "4";
                    break;

                case "BtnNr5":
                    output += "5";
                    break;

                case "BtnNr6":
                    output += "6";
                    break;

                case "BtnNr7":
                    output += "7";
                    break;

                case "BtnNr8":
                    output += "8";
                    break;

                case "BrnNr9":
                    output += "9";
                    break;

                case "BtnNr0":
                    output += "0";
                    break;
            }

            Txtsvar.Text = output;
        }

        private void Btnplus(object sender, RoutedEventArgs e)
        {
            option = "+";
            num1 = double.Parse(Txtsvar.Text);
            Clear();
        }

        private void Btnminus(object sender, RoutedEventArgs e)
        {
            option = "-";
            num1 = double.Parse(Txtsvar.Text);
            Clear();
        }

        private void Btnmulti(object sender, RoutedEventArgs e)
        {
            option = "x";
            num1 = double.Parse(Txtsvar.Text);
            Clear();

        }

        private void Btndivision(object sender, RoutedEventArgs e)
        {
            option = "/";
            num1 = double.Parse(Txtsvar.Text);
            Clear();
        }

        private void BtnEql(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(Txtsvar.Text);

            if (option.Equals("+"))
                results = num1 + num2;

            if (option.Equals("-"))
                results = num1 - num2;

            if (option.Equals("x"))
                results = num1 * num2;

            if (option.Equals("/"))
                results = num1 / num2;

            Txtsvar.Text = results + "";
        }

        private void Btnclear(object sender, RoutedEventArgs e)
        {
            Clear();
            results = (0);
            num1 = (0);
            num2 = (0);

        }

        void Clear()
        {
            output = "";
            Txtsvar.Text = "";
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
