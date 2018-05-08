using System;
using System.Windows;

namespace Exercise14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string s = DecNaarBin(12);
            MessageBox.Show(s);
        }

        public string DecNaarBin(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
