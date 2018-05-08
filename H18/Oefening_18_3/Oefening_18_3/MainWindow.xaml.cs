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
using System.IO;

namespace Oefening_18_3
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

        private void searchButton_Button_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock_TextBlock.Text = "";
            string input = searchTextBox_TextBox.Text;
            int lineNumber = 1;
            string outputString = "";
            StreamReader inputStream = null;

            try
            {
                inputStream = File.OpenText("test.txt");
                string line = inputStream.ReadLine();

                while (line != null)
                {
                    if (line.Contains(input))
                    {
                        outputString += "test.txt | line " + Convert.ToString(lineNumber) + " : " + line + "\n";
                        resultTextBlock_TextBlock.Text = outputString;
                    }

                    lineNumber++;
                    line = inputStream.ReadLine();
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputStream.Close();
            }
        }
    }
}
