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

namespace pz_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "1";
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "2";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "3";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "4";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "5";
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "6";
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "7";
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "8";
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "9";
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "0";
        }

        private void b_plus_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += " + ";
        }

        private void b_minus_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += " - ";
        }

        private void b_umn_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += " * ";
        }

        private void b_del_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += " / ";
        }

        private void b_result_Click(object sender, RoutedEventArgs e)
        {
            string text = text_box.Text;
            text_box.Text = Calculation(text).ToString();
        }

        private double Calculation(string text)
        {
            double a = double.Parse(text_box.Text);
            char action = char.Parse(text_box.Text);
            double b = double.Parse(text_box.Text);

            switch (action)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            }

            return 0;
        }
    }
}
