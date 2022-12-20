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

namespace SimpleCalculator
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

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            string n1 = txtBox1.Text;
            string n2 = txtBox2.Text;
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int sum = num1 + num2;
            txtBox3.Text = sum.ToString();
        }

        private void btnDiff_Click(object sender, RoutedEventArgs e)
        {
            string n1 = txtBox1.Text;
            string n2 = txtBox2.Text;
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int sum = num1 - num2;
            txtBox3.Text = sum.ToString();
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            string n1 = txtBox1.Text;
            string n2 = txtBox2.Text;
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int sum = num1 * num2;
            txtBox3.Text = sum.ToString();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            string n1 = txtBox1.Text;
            string n2 = txtBox2.Text;
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int sum = num1 / num2;
            txtBox3.Text = sum.ToString();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
        }
    }
}
