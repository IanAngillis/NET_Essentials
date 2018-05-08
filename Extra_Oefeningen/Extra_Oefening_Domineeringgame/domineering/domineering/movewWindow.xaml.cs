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
using System.Windows.Shapes;

namespace domineering
{
    /// <summary>
    /// Interaction logic for movewWindow.xaml
    /// </summary>
    public partial class movewWindow : Window
    {
        public movewWindow()
        {
            InitializeComponent();

            ReadFile();
        }

        private void ReadFile()
        {
            StreamReader inputStream = null;
            string line = "";

            try
            {
                inputStream = File.OpenText("moves.txt");

                line = inputStream.ReadLine();

                while(line != null)
                {
                    textDisplayFromMovesFileTextBlock_TextBlock.Text += line + "\n";

                    line = inputStream.ReadLine();
                }

                inputStream.Close();

            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(inputStream != null)
                {
                    inputStream = null;
                }
            }
        }
    }
}
