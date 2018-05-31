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

namespace Oefening_13_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Persoon> list = new List<Persoon>();

        public MainWindow()
        {
            InitializeComponent();

            list.Add(new Persoon("Angillis", "Ian", 'M', "Diestersteenweg 55", "xxxxxxx", "27/06/1997"));
            list.Add(new Persoon("Elon", "Musk", 'M', "SpaceXTesla", "xxxxxxx", "12/04/1975"));
            list.Add(new Persoon("Kenens", "Simon", 'M', "Karresraat 45", "xxxxxxx", "26/06/1997"));
            list.Add(new Persoon("Cosemans", "Richard", 'M', "Decosterstraat 56", "xxxxxxx", "23/11/1997"));
            list.Add(new Persoon("Angillis", "Kylian", 'M', "Diestersteenweg 55", "xxxxxxx", "31/07/1998"));

            this.LoadItems();

        }

        private void LoadItems()
        {
            PersonenListBox_ListBox.ItemsSource = null;
            PersonenListBox_ListBox.ItemsSource = list;
        }

        private void DetailButton_Button_Click(object sender, RoutedEventArgs e)
        {
            if(PersonenListBox_ListBox.SelectedIndex == -1)
            {
                return;
            }

            DetailWindow detailWindow = new DetailWindow((Persoon)PersonenListBox_ListBox.SelectedItem);
            detailWindow.Show();
        }
    }
}
