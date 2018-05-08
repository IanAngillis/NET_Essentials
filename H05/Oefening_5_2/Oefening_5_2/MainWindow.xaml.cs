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

namespace Oefening_5_2
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

        private void ShowButton_Button_Click(object sender, RoutedEventArgs e)
        {
            string voornaam = voornaamTextBox_TextBox.Text;
            string achternaam = achternaamTextBox_TextBox.Text;

            ToonNamen(voornaam, achternaam);

        }

        private void ToonNamen(string voornaam, string achternaam)
        {
            MessageBox.Show(voornaam, "voornaam");
            MessageBox.Show(achternaam, "achternaam");
        }
    }
}
