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

namespace Oefening_4_8
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

        private void calculatebutton_Button_Click(object sender, RoutedEventArgs e)
        {
            double r1 = 4.7;
            double r2 = 6.8;
            double serie = r1 + r2;
            double parallel = (r1 * r2) / (r1 + r2);

            serieweerstandTextBlock_TextBlock.Text = serie.ToString();
            parallelweerstandTextBlock_TextBlock.Text = parallel.ToString();
        }
    }
}
