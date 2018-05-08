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

namespace Oefening_17_3
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

        private void calculateButton_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculateTriangleArea(Convert.ToInt32(aTextBox_TextBox.Text), Convert.ToInt32(bTextBox_TextBox.Text), Convert.ToInt32(cTextBox_TextBox.Text));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Geef integers in");
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateTriangleArea(int a, int b, int c)
        {
            if(!TriangleIsValid(a, b, c))
            {
                throw new ArithmeticException("Er kan geen driehoek gemaakt worden met deze waarden");
            }

            sTextBlock_TextBlock.Text = Convert.ToString(CalculateS(a, b, c));
            oppTextBlock_TextBlock.Text = Convert.ToString(CalculateOpp(a, b, c));
        }

        private double CalculateOpp(double a , double b, double c)
        {
            return Math.Sqrt(CalculateS(a, b, c) * (CalculateS(a, b, c) - a) * (CalculateS(a, b, c) - b) * (CalculateS(a, b, c) - c));
        }

        private double CalculateS(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        private bool TriangleIsValid(int a, int b, int c)
        {
            return ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
        }
    }
}
