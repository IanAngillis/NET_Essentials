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

namespace Oefening_13_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            list.Add("Tea");
            list.Add("Milk");
            list.Add("Coffee");
            this.LoadItems();
        }

        private void LoadItems()
        {
            ShoppingListBox_ListBox.ItemsSource = null;
            ShoppingListBox_ListBox.ItemsSource = list;
        }

        private void SortButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Sort();
            this.LoadItems();
        }

        private void ClearButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            this.LoadItems();
        }
    }
}
