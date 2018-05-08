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

namespace Oefening_10_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DobbelSteen dobbelsteen;

        public MainWindow()
        {
            InitializeComponent();

            dobbelsteen = new DobbelSteen();
        }

        private void gooiButton_Button_Click(object sender, RoutedEventArgs e)
        {
            waardeTextBlock_TextBlock.Text = Convert.ToString(dobbelsteen.GooiDobbelsteen());
        }
    }
}
