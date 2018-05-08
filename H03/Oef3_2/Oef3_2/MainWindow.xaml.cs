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

namespace Oef3_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Line horizontal1 = new Line();
            Line horizontal2 = new Line();
            Line horizontal3 = new Line();
            Line horizontal4 = new Line();

            Line vertical1 = new Line();
            Line vertical2 = new Line();
            Line vertical3 = new Line();
            Line vertical4 = new Line();

            //Drawing horizontal lines 
            horizontal1.X1 = 20;
            horizontal1.Y1 = 20;
            horizontal1.X2 = 80;
            horizontal1.Y2 = 20;

            horizontal2.X1 = 20;
            horizontal2.Y1 = 40;
            horizontal2.X2 = 80;
            horizontal2.Y2 = 40;

            horizontal3.X1 = 20;
            horizontal3.Y1 = 60;
            horizontal3.X2 = 80;
            horizontal3.Y2 = 60;

            horizontal4.X1 = 20;
            horizontal4.Y1 = 80;
            horizontal4.X2 = 80;
            horizontal4.Y2 = 80;

            //Drawing vertical lines
            vertical1.X1 = 20;
            vertical1.Y1 = 20;
            vertical1.X2 = 20;
            vertical1.Y2 = 80;

            vertical2.X1 = 40;
            vertical2.Y1 = 20;
            vertical2.X2 = 40;
            vertical2.Y2 = 80;

            vertical3.X1 = 60;
            vertical3.Y1 = 20;
            vertical3.X2 = 60;
            vertical3.Y2 = 80;

            vertical4.X1 = 80;
            vertical4.Y1 = 20;
            vertical4.X2 = 80;
            vertical4.Y2 = 80;

            //Coloring lines
            horizontal1.Stroke = new SolidColorBrush(Colors.Black);
            horizontal2.Stroke = new SolidColorBrush(Colors.Black);
            horizontal3.Stroke = new SolidColorBrush(Colors.Black);
            horizontal4.Stroke = new SolidColorBrush(Colors.Black);

            vertical1.Stroke = new SolidColorBrush(Colors.Black);
            vertical2.Stroke = new SolidColorBrush(Colors.Black);
            vertical3.Stroke = new SolidColorBrush(Colors.Black);
            vertical4.Stroke = new SolidColorBrush(Colors.Black);

            //Add lines to canvas
            drawCanvas_Canvas.Children.Add(horizontal1);
            drawCanvas_Canvas.Children.Add(horizontal2);
            drawCanvas_Canvas.Children.Add(horizontal3);
            drawCanvas_Canvas.Children.Add(horizontal4);

            drawCanvas_Canvas.Children.Add(vertical1);
            drawCanvas_Canvas.Children.Add(vertical2);
            drawCanvas_Canvas.Children.Add(vertical3);
            drawCanvas_Canvas.Children.Add(vertical4);

        }
    }
}
