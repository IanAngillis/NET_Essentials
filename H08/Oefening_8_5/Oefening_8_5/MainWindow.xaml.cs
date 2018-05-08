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

namespace Oefening_8_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int sum = 0;

            for(int i = 0; i < 39; i++)
            {
                sum += (i + 1);
            }

            MessageBox.Show(Convert.ToString(sum));

            sum = 39 * (39 + 1) / 2;

            MessageBox.Show(Convert.ToString(sum));

        }
    }
}
