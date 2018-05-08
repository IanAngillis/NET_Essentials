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

namespace Oefening_18_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Teller { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Teller = 0;

            StreamWriter outputStream = File.CreateText("test.txt");

            for(int i = 0; i < 100; i++)
            {
                outputStream.WriteLine("dit is een lijn");
            }

            outputStream.Close();

            StreamReader inputStream = File.OpenText("test.txt");
            string line = inputStream.ReadLine();

            while(line != null)
            {
                Teller++;
                line = inputStream.ReadLine();
            }

            inputStream.Close();

            MessageBox.Show(Convert.ToString(Teller));
            
          
        }
    }
}
