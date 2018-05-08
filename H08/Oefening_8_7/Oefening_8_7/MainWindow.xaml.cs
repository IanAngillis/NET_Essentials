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

namespace Oefening_8_7
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

        private void tekenButton_Button_Click(object sender, RoutedEventArgs e)
        {
            string tabel = "";

            int vermenigVuldigGetal = Convert.ToInt32(inputTextBox_TextBox.Text);

            for(int i = 0; i < (vermenigVuldigGetal+1); i++)
            {

                for(int j = 0; j < (vermenigVuldigGetal + 1); j++)
                {
                    if(i == 0 && j == 0)
                    {
                        
                    } else if (i == 0)
                    {
                        tabel += j;
                    }
                    else if (j == 0) {
                        tabel += i;
                    } else
                    {
                        tabel += (i * j);
                    }

                    tabel += "\t";
                }

                tabel += "\n";
            }

            outPutTextBox_TextBox.Text = tabel;
        }
    }
}
