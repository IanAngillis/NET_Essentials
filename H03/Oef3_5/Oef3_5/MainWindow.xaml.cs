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

namespace Oef3_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Button_Click(object sender, RoutedEventArgs e)
        {
            //Aanmaken buitenste cirkel
            Ellipse buitensteCirkel = new Ellipse();
            buitensteCirkel.Width = 300;
            buitensteCirkel.Height = 300;
            buitensteCirkel.Fill = new SolidColorBrush(Colors.Green);
            buitensteCirkel.Stroke = new SolidColorBrush(Colors.Black);

            //Aanmaken midden cirkel
            Ellipse middenCirkel = new Ellipse();
            middenCirkel.Width = 200;
            middenCirkel.Height = 200;
            middenCirkel.Fill = new SolidColorBrush(Colors.Orange);
            middenCirkel.Stroke = new SolidColorBrush(Colors.Black);
            middenCirkel.Margin = new Thickness(50, 50, 0, 0);

            //Aanmaken binnenste cirkel
            Ellipse binnensteCirkel = new Ellipse();
            binnensteCirkel.Width = 100;
            binnensteCirkel.Height = 100;
            binnensteCirkel.Fill = new SolidColorBrush(Colors.Red);
            binnensteCirkel.Stroke = new SolidColorBrush(Colors.Black);
            binnensteCirkel.Margin = new Thickness(100, 100, 0, 0);

            //Cirkels toevoegen aan canvas
            drawCanvas_Canvas.Children.Add(buitensteCirkel);
            drawCanvas_Canvas.Children.Add(middenCirkel);
            drawCanvas_Canvas.Children.Add(binnensteCirkel);

        }
    }
}
