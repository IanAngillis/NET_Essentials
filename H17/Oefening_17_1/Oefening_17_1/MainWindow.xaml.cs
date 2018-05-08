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

namespace Oefening_17_1
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
            double quotient1, quotient2;
            int a, b;

            try
            {
                a = Convert.ToInt32(aTextBox.Text);
                b = Convert.ToInt32(bTextBox.Text);

                quotient1 = a / b;
                quotient2 = b / a;

                MessageBox.Show(Convert.ToString(quotient1),
                    string.Format("{0} / {1}", Convert.ToString(a), Convert.ToString(b)));

                MessageBox.Show(Convert.ToString(quotient2),
                    string.Format("{0} / {1}", Convert.ToString(b), Convert.ToString(a)));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Fout datatype: gelieve integers in te geven.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("U kan niet delen door 0");
            }
            
        }
    }
}
