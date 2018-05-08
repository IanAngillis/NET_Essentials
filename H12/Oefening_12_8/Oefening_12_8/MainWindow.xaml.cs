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

namespace Oefening_12_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(aInput_TextBox.Text);
            b = Convert.ToDouble(bInput_TextBox.Text);
            c = Convert.ToDouble(cInput_TextBox.Text);

            if(SidesFormTriangle())
            {
                sValue_TextBlock.Text = Convert.ToString( this.CalculateS());
                areaValue_TextBlock.Text = Convert.ToString(this.CalculateArea());
            } else
            {

                MessageBox.Show("Sides are not valid, make sure the sides can form a triangle");
            }
        }

        private double CalculateArea()
        {
            return Math.Sqrt(this.CalculateS() * (this.CalculateS() - a) * (this.CalculateS() - b) * (this.CalculateS() - c));
        }

        private double CalculateS()
        {
            return ((a + b + c) / 2);
        }

        private bool SidesFormTriangle()
        {
            return ((a + b) > c);
        }
    }
}
