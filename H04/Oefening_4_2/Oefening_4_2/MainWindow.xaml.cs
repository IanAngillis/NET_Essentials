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

namespace Oefening_4_2
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
            double straal = Convert.ToDouble(inputTextBox_TextBox.Text);

            double omtrek = 2 * Math.PI * straal;
            double oppervlakte = Math.PI * Math.Pow(straal, 2);
            double volume = (4 * Math.PI / 3) * Math.Pow(straal, 3);

            omtrekTextBlock_TextBlock.Text = omtrek.ToString();
            oppervlakteTextBlock_TextBlock.Text = oppervlakte.ToString();
            volumeTextBlock_TextBlock.Text = volume.ToString();
        }
    }
}
