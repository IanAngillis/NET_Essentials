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

namespace Oefening_13_9
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

            list.Add("Red");
            list.Add("Green");
            list.Add("Blue");
            this.LoadItems();
            ColorComboBox_ComboBox.SelectedIndex = 0;
        }

        private void LoadItems()
        {
            ColorComboBox_ComboBox.ItemsSource = null;
            ColorComboBox_ComboBox.ItemsSource = list;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ColorCanvas((string)ColorComboBox_ComboBox.SelectedItem);
        }

        private void ColorCanvas(string color)
        {
            switch (color)
            {
                case "Red":
                    drawCanvas_Canvas.Background = new SolidColorBrush(Colors.Red);
                    break;
                case "Green":
                    drawCanvas_Canvas.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "Blue":
                    drawCanvas_Canvas.Background = new SolidColorBrush(Colors.Blue);
                    break;
                default:
                    drawCanvas_Canvas.Background = new SolidColorBrush(Colors.Gray);
                    break;
            }
        }
    }
}
