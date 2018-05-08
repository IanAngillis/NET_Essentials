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

namespace Oefening_6_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int number = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void incrementButton_Button_Click(object sender, RoutedEventArgs e)
        {
            number++;

            numberLabel_Label.Content = Convert.ToString(number);
        }
    }
}
