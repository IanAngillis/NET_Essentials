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

namespace Oefening_13_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>() { "tea", "sugar", "milk" };

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void LoadItems()
        {
            ShoppingListBox.ItemsSource = null;
            ShoppingListBox.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.LoadItems();
        }

        private void SortButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Sort();
            this.LoadItems();
        }
    }
}
