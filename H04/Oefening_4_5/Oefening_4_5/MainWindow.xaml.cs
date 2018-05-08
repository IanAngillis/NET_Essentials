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

namespace Oefening_4_5
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
            int belastingsTarief = Convert.ToInt32(inkomensBelastingsTariefInputTextBox_TextBox.Text);
            double belastingsPercentage = (double) belastingsTarief / 100;

            double inkomen = Convert.ToDouble(inkomenTextBox_TextBox.Text);
            double belastingen = inkomen * belastingsPercentage;
            double inkomenNaBelastingAftrek = inkomen - belastingen;

            inkomenNaBelastingTextBlock_TextBlock.Text = String.Format("{0:c}", inkomenNaBelastingAftrek);
            inkomenBelastingTextBlock_TextBlock.Text = String.Format("{0:c}", belastingen);
        }
    }
}
