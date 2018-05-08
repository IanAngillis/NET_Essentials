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

namespace Oefening_10_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PuntenTeller teller = new PuntenTeller();

            teller.IncreaseScore();
            teller.IncreaseScore();
            teller.IncreaseScore();
            teller.DecreaseScore();
            teller.IncreaseScore();

            MessageBox.Show(Convert.ToString(teller.Score));

        }
    }
}
