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

namespace Oefening_10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bankrekening bankr;

        public MainWindow()
        {
            InitializeComponent();

            bankr = new Bankrekening();
            saldoTextBlock_TextBlock.Text = Convert.ToString(bankr.Saldo);
        }

        private void transactieButton_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToDouble(stortingEnOpnameTextBox_TextBox.Text) < 0 )
            {
                bankr.Opname(Convert.ToDouble(stortingEnOpnameTextBox_TextBox.Text));
            } else
            {
                bankr.Storting(Convert.ToDouble(stortingEnOpnameTextBox_TextBox.Text));
            }

            saldoTextBlock_TextBlock.Text = Convert.ToString(bankr.Saldo);
        }
    }
}
