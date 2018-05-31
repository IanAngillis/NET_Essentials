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

namespace Oefening_13_4
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

            list.Add("Tea");
            list.Add("Coffee");
            list.Add("Milk");
            this.LoadItems();

        }

        private void LoadItems()
        {
            ShoppingListBox_ListBox.ItemsSource = null;
            ShoppingListBox_ListBox.ItemsSource = list;
        }

        private void ChangeButton_Button_Click(object sender, RoutedEventArgs e)
        {
            if(InputTextBox_TextBox.Text == "" ||ShoppingListBox_ListBox.SelectedIndex == -1)
            {
                return;
            }
            list[ShoppingListBox_ListBox.SelectedIndex] = InputTextBox_TextBox.Text;
            this.LoadItems();
        }
    }
}
