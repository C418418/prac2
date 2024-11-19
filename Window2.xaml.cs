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
using System.Windows.Shapes;

namespace evdokimovpractice2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            string result;
            double first;
            double second;
            double answer;
            string op = Operator.Text;
            switch (op)
            {
                case "+":
                    first = Convert.ToDouble(NumberA.Text);
                    second = Convert.ToDouble(NumberB.Text);
                    answer = first + second;
                    result = Convert.ToString(answer);
                    ResultL.Content = result;
                    break;
                case "-":
                    first = Convert.ToDouble(NumberA.Text);
                    second = Convert.ToDouble(NumberB.Text);
                    answer = first - second;
                    result = Convert.ToString(answer);
                    ResultL.Content = result;
                    break;
                case "*":
                    first = Convert.ToDouble(NumberA.Text);
                    second = Convert.ToDouble(NumberB.Text);
                    answer = first * second;
                    result = Convert.ToString(answer);
                    ResultL.Content = result;
                    break;
                case "/":
                    first = Convert.ToDouble(NumberA.Text);
                    second = Convert.ToDouble(NumberB.Text);
                    if (second == 0)
                    {
                        ResultL.Content = "На 0 делить нельзя";
                    }
                    else
                    {
                        answer = first / second;
                        result = Convert.ToString(answer);
                        ResultL.Content = result;
                    }
                    break;
                default:
                    ResultL.Content = "Ошибка";
                    break;
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }
    }
}
