using System;
using System.Collections.Generic;
using System.IO;
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

namespace Hoofdstuk_18_invoer
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

        private void invoerButton_Button_Click(object sender, RoutedEventArgs e)
        {
            string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string myfile = System.IO.Path.Combine(sourcepath, "myfile.txt");
            StreamReader inputStream = File.OpenText(myfile);
            string line = inputStream.ReadLine();

            while (line != null)
            {
                invoerTextBox_TextBox.AppendText(line);
                invoerTextBox_TextBox.AppendText(Environment.NewLine);
                line = inputStream.ReadLine();
            }

            inputStream.Close();
        }
    }
}
