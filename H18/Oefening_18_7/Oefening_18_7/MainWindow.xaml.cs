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

namespace Oefening_18_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int totalLines = 0;
            string line = "";
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            StreamReader inputStream = null;

            foreach(string file in files)
            {
                try
                {
                    inputStream = File.OpenText(file);

                    line = inputStream.ReadLine();

                    while(line != null)
                    {
                        totalLines++;
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

            MessageBox.Show(Convert.ToString(totalLines));

        }
    }
}
