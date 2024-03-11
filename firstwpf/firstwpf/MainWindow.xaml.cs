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

namespace firstwpf
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
        string n1str, n2str, operatorstr;

        private void button_delete_click(object sender, RoutedEventArgs e)
        {
            if (txtLCD.Text.Length == 0) return;
            txtLCD.Text = txtLCD.Text.Substring(0, txtLCD.Text.Length - 1);
        }

        private void button_equal_click(object sender, RoutedEventArgs e)
        {
            int operatorindex = txtLCD.Text.IndexOf(operatorstr)+1;
            int len = txtLCD.Text.Length-operatorindex;
            n2str = txtLCD.Text.Substring(operatorindex, len);

            int number1 =int.Parse(n1str);
            int number2 =int.Parse(n2str);
            int result = 0;
            if(operatorstr == "+"){
                result = number1 + number2;
            }
            else if (operatorstr == "-"){
                result = number1 - number2;

            }
            else if (operatorstr == "*")
            {
                result = number1 * number2;

            }
            else if (operatorstr == "/")
            {
                result = number1 / number2;
            }
            else
            {
                txtLCD.Text = result.ToString("no");
            }
            txtLCD.Text = result.ToString();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtLCD.Text += btn.Content.ToString();
        }
        private void button_operator_click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            string operat = bt.Content.ToString();
            if (txtLCD.Text.Contains("+") || txtLCD.Text.Contains("-")|| txtLCD.Text.Contains("*")|| txtLCD.Text.Contains("/"))
            {
                MessageBox.Show("only one allowed!");
                return;
            }
            n1str = txtLCD.Text;
            operatorstr = operat;
            txtLCD.Text += operat;
        }
    }
}
