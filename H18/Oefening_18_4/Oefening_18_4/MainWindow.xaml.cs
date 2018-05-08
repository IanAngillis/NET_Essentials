using Microsoft.Win32;
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
namespace Oefening_18_4
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
        

        private void openFile2Button_Button_Click(object sender, RoutedEventArgs e)
        {
            file2TextBlock_TextBlock.Text = getFile();
        }

        private void openFile1Button_Button_Click(object sender, RoutedEventArgs e)
        {
            file1TextBlock_TextBlock.Text = getFile();
        }

        private string getFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.InitialDirectory = startDir;
            openFileDialog.Filter = "Image Files|*.BMP;" +
                                    "*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            } else
            {
                return null;
            }
        }

        private void compareButton_Button_Click(object sender, RoutedEventArgs e)
        {

            if (file1TextBlock_TextBlock == null || file2TextBlock_TextBlock == null)
            {
                MessageBox.Show("Gelieve 2 documenten te selecteren");
                return;
            }

            StreamReader inputStreamFile1 = null;
            StreamReader inputStreamFile2 = null;
            string lineFile1 = "";
            string lineFile2 = "";

            try
            {
                inputStreamFile1 = File.OpenText(file1TextBlock_TextBlock.Text);
                inputStreamFile2 = File.OpenText(file2TextBlock_TextBlock.Text);

                lineFile1 = inputStreamFile1.ReadLine();
                lineFile2 = inputStreamFile2.ReadLine();

                while(lineFile1 != null && lineFile2 != null)
                {

                    if (!lineFile1.Equals(lineFile2))
                    {
                        MessageBox.Show("Files zijn niet gelijk");
                        return;
                    }

                    lineFile1 = inputStreamFile1.ReadLine();
                    lineFile2 = inputStreamFile2.ReadLine();

                }

                if(lineFile1 == null && lineFile2 == null)
                {
                    MessageBox.Show("Files zijn gelijk");
                } else
                {
                    MessageBox.Show("Files zijn niet gelijk");
                }

            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputStreamFile1.Close();
                inputStreamFile2.Close();
            }
        }
    }
}
