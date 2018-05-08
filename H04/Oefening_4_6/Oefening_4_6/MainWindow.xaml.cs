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

namespace Oefening_4_6
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
            double fahrenheit = Convert.ToDouble(fahrenheitTextBox_TextBox.Text);

            double celsius = (fahrenheit - 32) * 5 / 9;
            celsiusTextBlock_TextBlock.Text = string.Format("{0:0.00}", celsius);

        }
    }
}
