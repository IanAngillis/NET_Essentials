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

namespace Oefening_8_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 7; i > 0; i--)
            {
                zangTextBlock_TextBlock.Text += string.Format("{0} naar de zee.\nNee," +
                    " zei de moeder, ik ga niet mee.\n" +
                    "Ik blijf liever hier in die vieze vuile sloot\n" +
                    "Want in de zee daar zwemt een haai en die bijt je dan ... dood\n\n", GetAantalVissen(i));
            }
        }

        private string GetAantalVissen(int aantalVissen)
        {
            string temp = "";

            switch (aantalVissen)
            {
                case 7:
                    temp = "Zeven kleine visjes, die zwommen";
                    break;
                case 6:
                    temp = "Zes kleine visjes, die zwommen";
                    break;
                case 5:
                    temp = "Vijf kleine visjes, die zwommen";
                    break;
                case 4:
                    temp = "Vier kleine visjes, die zwommen";
                    break;
                case 3:
                    temp = "Drie kleine visjes, die zwommen";
                    break;
                case 2:
                    temp = "Twee kleine visjes, die zwommen";
                    break;
                case 1:
                    temp = "Een klein visje, die zwom";
                    break;

                default:
                    break;
            }

            return temp;
        }
    }
}
