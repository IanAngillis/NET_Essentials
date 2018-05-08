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

namespace Oefening_11_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BankRekening r1 = new BankRekening();
            r1.DebitSaldo(1000);

            GoudenRekening r2 = new GoudenRekening();
            r2.DebitSaldo(1000);

            MessageBox.Show(Convert.ToString(r1.BerekenRente()), "Bankrekening");
            MessageBox.Show(Convert.ToString(r2.BerekenRente()), "Gouden bankrekening");

        }
    }
}
