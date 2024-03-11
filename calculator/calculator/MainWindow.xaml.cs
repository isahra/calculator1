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

namespace calculator
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
        string number1txt, number2txt, operatortxt;

        private void button_opetate_click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            string operate = bt.Content.ToString();
            if (resulttxt.Text.Contains("+") || resulttxt.Text.Contains("-") || resulttxt.Text.Contains("*") || resulttxt.Text.Contains("/"))
            {
                MessageBox.Show("only one operator allowed!");
                return;
            }
            number1txt = resulttxt.Text;
            operatortxt = operate;
            resulttxt.Text +=operate ;

        }

        private void button_equal_click(object sender, RoutedEventArgs e)
        {
            int operatorindex = resulttxt.Text.IndexOf(operatortxt)+1;
            int len = resulttxt.Text.Length - operatorindex ;
            number2txt = resulttxt.Text.Substring(operatorindex,len);
            double result = 0;
            int number1 = Convert.ToInt32(number1txt);
            int number2 = Convert.ToInt32(number2txt);

            if (operatortxt == "+") result = number1 + number2;
            else if (operatortxt == "*") result = number1 * number2;
            else if (operatortxt == "/") result = number1 / number2;
            else if (operatortxt == "-") result = number1 - number2;
            resulttxt.Text = result.ToString();

        }

        private void button_delete_click(object sender, RoutedEventArgs e)
        {   if (resulttxt.Text.Length == 0) return;
            resulttxt.Text = resulttxt.Text.Substring(0,resulttxt.Text.Length-1);

        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            resulttxt.Text += btn.Content.ToString();
        }
    }
}
