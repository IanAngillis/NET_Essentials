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

namespace Oefening_17_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankRekening b = new BankRekening();

        public MainWindow()
        {
            InitializeComponent();
            bedragTextBlock_TextBlock.Text = "0";
        }

        private void opneemButton_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                b.Opnemen(Convert.ToInt32(bedragTextBox_TextBox.Text));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Geef een correct bedrag in (integers)");
            }
            catch(BankRekeningException ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateBedragTextBox();
        }

        private void stortButton_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                b.Storten(Convert.ToInt32(bedragTextBox_TextBox.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Geef een correct bedrag in (integers)");
            }
            catch (BankRekeningException ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateBedragTextBox();
        }

        private void UpdateBedragTextBox()
        {
            bedragTextBlock_TextBlock.Text = Convert.ToString(b.Saldo);
        }
    }
}
