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

namespace EenOefening
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

        private void item2Button_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(list[1]));
        }

        private void countButton_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(shoppingList_ListBox.Items.Count));
        }

        private void addButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add("tea");
            this.loadItems();
        }

        private void loadButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            list.Add("tea");
            list.Add("sugar");
            list.Add("milk");
            this.loadItems();
        }

        private void loadItems()
        {
            shoppingList_ListBox.ItemsSource = null;
            shoppingList_ListBox.ItemsSource = list;
        }

        private void clearButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            this.loadItems();
        }

        private void containsButton_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(list.Contains("tea")));
        }

        private void indexOfButton_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(list.IndexOf("tea")));
        }

        private void lastIndexOfButton_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(list.LastIndexOf("tea")));

        }

        private void removeButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Remove("tea");
            this.loadItems();
        }

        private void removeAtButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.RemoveAt(0);
            this.loadItems();
        }

        private void insertButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Insert(1, "tea");
            this.loadItems();
        }

        private void sortButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Sort();
            this.loadItems();
        }

        private void reverseButton_Button_Click(object sender, RoutedEventArgs e)
        {
            list.Reverse();
            this.loadItems();
        }
    }
}
