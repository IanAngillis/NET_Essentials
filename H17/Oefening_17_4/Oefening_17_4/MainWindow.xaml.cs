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

namespace Oefening_17_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckDate(Convert.ToInt32(dayTextBox_TextBox.Text), Convert.ToInt32(monthTextBox_TextBox.Text), Convert.ToInt32(yearTextBox_TextBox.Text));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Please enter integers");
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckDate(int day, int month, int year)
        {
            if(day < 1 || month < 1 || year < 1)
            {
                throw new ArithmeticException("Please enter numbers > 0");
            } else if(day > 31)
            {
                throw new ArithmeticException("A month does not have more than 31 days");
            }else if(month > 12)
            {
                throw new ArithmeticException("A year does not have more than 12 months");
            } else if(month == 2 && day > 29)
            {
                throw new ArithmeticException("Februari cannot have 30 days");
            } else
            {
                MessageBox.Show(string.Format("The date is: {0}/{1}/{2}", day, month, year));
            }
        }
    }
}
