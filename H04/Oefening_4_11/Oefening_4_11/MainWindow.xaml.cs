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

namespace Oefening_4_11
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

        private void convertButton_Button_Click(object sender, RoutedEventArgs e)
        {
            string input = InputBox_TextBox.Text;
            int decimalNumber = Convert.ToInt32(input);
            string binaryNumber = "";

            while(decimalNumber / 2 != 0)
            {
                if(decimalNumber % 2 == 0)
                {
                        binaryNumber = "0" + binaryNumber;
                }
                else
                {
                    binaryNumber = "1" + binaryNumber;
                }

                decimalNumber /= 2;
            }

            if (decimalNumber % 2 != 0)
            {
                binaryNumber = "1" + binaryNumber;
            }

            binaryLabel_Label.Content = binaryNumber;
        }
    }
}
