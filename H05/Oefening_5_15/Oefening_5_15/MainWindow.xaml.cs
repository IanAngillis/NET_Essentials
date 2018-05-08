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

namespace Oefening_5_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SecNaarUMS(3662);
        }

        private void SecNaarUMS(int aantalSeconden)
        {
            int aantalUren;
            int aantalMinuten;

            aantalUren = aantalSeconden / 3600;
            aantalSeconden %= 3600;
            aantalMinuten = aantalSeconden / 60;
            aantalSeconden %= 60;

            MessageBox.Show(string.Format("{0} uur, {1} minuten, {2} seconden", aantalUren, aantalMinuten, aantalSeconden));

            
        }
    }
}
