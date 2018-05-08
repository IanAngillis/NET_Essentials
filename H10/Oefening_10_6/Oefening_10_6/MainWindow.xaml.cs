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

namespace Oefening_10_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PRandom rand = new PRandom(8);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void genereerButton_Button_Click(object sender, RoutedEventArgs e)
        {
            valueTextBlock_TextBlock.Text = Convert.ToString(rand.NextRandom());
        }
    }
}
