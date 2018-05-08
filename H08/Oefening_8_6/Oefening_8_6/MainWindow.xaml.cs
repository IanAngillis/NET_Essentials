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

namespace Oefening_8_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 0; i < 3; i++)
            {
                drawZaagPatroon();
            }
           
        }

        private void drawZaagPatroon()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < (i+1); j++)
                {
                    zaagTextBlock_TextBlock.Text += "S";
                }

                zaagTextBlock_TextBlock.Text += "\n";
            }
        }

    }
}
