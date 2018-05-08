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
using Microsoft.Win32;

namespace Oefening_18_8
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

        private void openFileDialogButton_Button_Click(object sender, RoutedEventArgs e)
        {
            searchMapTextBox_TextBox.Text = getDirectory();
        }

        private string getDirectory()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(openFileDialog.ShowDialog() == true)
            {
                return System.IO.Path.GetDirectoryName(openFileDialog.FileName);
            }

            return null;
        }

        private void searchButton_Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader inputStream = null;
            string searchInput = inputTextBox_TextBox.Text;
            string[] files = Directory.GetFiles(searchMapTextBox_TextBox.Text);
            string line = null;

            foreach(string file in files)
            {

                if (file.EndsWith(".txt"))
                {

                    try
                    {
                        inputStream = File.OpenText(file);
                        line = inputStream.ReadLine();

                        while (line != null)
                        {
                            if (line.Contains(searchInput))
                            {
                                resultTextBlock_TextBlock.AppendText(file + " | " + line + "\n");
                            }

                            line = inputStream.ReadLine();
                        }

                    }
                    catch(FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if(inputStream != null)
                        {
                            inputStream.Close();
                        }
                    }
                   

                }

            }
        }
    }
}
