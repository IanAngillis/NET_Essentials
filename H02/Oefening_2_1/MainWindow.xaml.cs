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

namespace Oefening_2_1
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

        private void button1_Button_Click(object sender, RoutedEventArgs e)
        {
            label1_Label.Content = "Ja";
            label2_Label.Content = "Ja";
            label3_Label.Content = "Ja";
        }

        private void button2_Button_Click(object sender, RoutedEventArgs e)
        {
            label1_Label.Content = "Nee";
            label2_Label.Content = "Nee";
            label3_Label.Content = "Nee";
        }

        private void button3_Button_Click(object sender, RoutedEventArgs e)
        {
            label1_Label.Content = "A";
            label2_Label.Content = "B";
            label3_Label.Content = "C";
        }
    }
}
