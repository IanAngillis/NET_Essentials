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

namespace Oefening_17_2
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

        public void LosOp(double a, double b, double c)
        {
            double d = 0;

            try
            {
                d = CalculateDiscriminant(a, b, c);
                
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            opl1TextBox_TextBox.Text = Convert.ToString(CalculateSoluion(a, b, d, 1));
            opl2TextBox_TextBox.Text = Convert.ToString(CalculateSoluion(a, b, d, 2));
        }

        private double CalculateSoluion(double a, double b, double d, int solution)
        {
            if (solution == 1)
            {
                return (-b + Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                return (-b - Math.Sqrt(d)) / (2 * a);
            }
        }

        private double CalculateDiscriminant(double a, double b, double c)
        {
            double temp = (b * b) - (4 * a * c);

            if (temp < 0)
            {
                throw new ArithmeticException("D < 0");
            }

            return temp;
        }

        private void startButton_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LosOp(Convert.ToInt32(aTextBox_TextBox.Text), Convert.ToInt32(bTextBox_TextBox.Text),
                    Convert.ToInt32(cTextBox_TextBox.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter integers or doubles");
            }
        }
    }
}
