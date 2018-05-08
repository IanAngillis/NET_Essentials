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

namespace Oefening_4_7
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
            int totaalAantalSeconden = Convert.ToInt32(inputTextBox_TextBox.Text);
            int uren;
            int minuten;
            int seconden;

            uren = totaalAantalSeconden / 3600;
            totaalAantalSeconden %= 3600;

            minuten = totaalAantalSeconden / 60;
            totaalAantalSeconden %= 60;

            seconden = totaalAantalSeconden;

            outputTextBlock_TextBlock.Text = string.Format("H:{0}\tM:{1}\tS:{2}", uren, minuten, seconden);
        }
    }
}
