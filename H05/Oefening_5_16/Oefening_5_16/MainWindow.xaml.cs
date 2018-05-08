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

namespace Oefening_5_16
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

        private void actionButton_Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            Invoer3(out a, out b, out c);
            MessageBox.Show(string.Format("{0}, {1}, {2}", a, b, c));

        }

        private void Invoer3(out int a, out int b, out int c)
        {
            a = Convert.ToInt32(int1TextBox_TextBox.Text);
            b = Convert.ToInt32(int2TextBox_TextBox.Text);
            c = Convert.ToInt32(int3TextBox_TextBox.Text);
        }
    }
}
