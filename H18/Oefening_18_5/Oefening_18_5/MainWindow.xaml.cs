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

namespace Oefening_18_5
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

        private void selectFileButton_Button_Click(object sender, RoutedEventArgs e)
        {
            fileTextBlock_TextBlock.Text = getFile();
        }

        private string getFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.InitialDirectory = startDir;
            openFileDialog.Filter = "All files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            } else
            {
                return "";
            }

        }

        private void pasAanButton_Button_Click(object sender, RoutedEventArgs e)
        {

            ChangeStringInFile();
        }

        private void ChangeStringInFile()
        {
            StreamReader inputStream = null;
            StreamWriter outputStream = null;
            string from = vanTextBox_TextBox.Text;
            string to = naarTextBox_TextBox.Text;
            string line = "";
           

            try
            {
                inputStream = File.OpenText(fileTextBlock_TextBlock.Text);
                outputStream = File.CreateText("result.txt");

                line = inputStream.ReadLine();
                

                while(line != null)
                {

                    if (line.Contains(from))
                    {
                        line = Change(line, from, to);
                    }

                    outputStream.WriteLine(line);

                    line = inputStream.ReadLine();
                }


            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputStream.Close();
                outputStream.Close();
            }
        }

        private string Change(string original, string fromText, string toText)
        {
            string leftBit, rightBit;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length,
                                            original.Length - place - fromText.Length);
                    //MessageBox.Show(leftBit);
                    //MessageBox.Show(rightBit);

                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
