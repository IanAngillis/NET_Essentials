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

namespace Oefening_18_9
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

        private void selectFolderButton_Button_Click(object sender, RoutedEventArgs e)
        {
            mapTextBlock_TextBlock.Text = GetMap();

            if(mapTextBlock_TextBlock.Text != null)
            {
                resultTextBlock_Textblock.Text = GetResults();
            }

            
        }

        private string GetResults()
        {
            StreamReader inputStream = null;
            string line = null;
            string[] files = Directory.GetFiles(mapTextBlock_TextBlock.Text);
            int counter = 0;
            string temp = "";

            if(files == null)
            {
                MessageBox.Show("Incorrect map");
                return null;
            }

            foreach(string file in files)
            {
                if (file.EndsWith(".txt"))
                {
                    temp += file + "\n";

                    try
                    {
                        inputStream = File.OpenText(file);
                        line = inputStream.ReadLine();
                        counter = 0;

                        while(line != null)
                        {

                            if(counter >= 10)
                            {
                                break;
                            }

                            temp += line + "\n";

                            line = inputStream.ReadLine();
                            counter++;
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

            return temp;

        }

        private string GetMap()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            
            if(openFileDialog.ShowDialog() == true)
            {
                return System.IO.Path.GetDirectoryName(openFileDialog.FileName);
            }
            else
            {
                return null;
            }
        }
    }
}
