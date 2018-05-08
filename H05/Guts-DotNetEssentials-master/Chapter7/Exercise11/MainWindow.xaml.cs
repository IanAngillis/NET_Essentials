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

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        private Random rand1 = new Random(1);
        private Random rand2 = new Random(10);
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void button1_Button_Click(object sender, RoutedEventArgs e)
        {
            label1_Label.Content = Convert.ToString(rand1.Next(5000));
        }

        private void button2_Button_Click(object sender, RoutedEventArgs e)
        {
            label2_Label.Content = Convert.ToString(rand2.Next(4999)+1);
        }
    }
}
