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

namespace Oef3_1
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

        private void drawButton_Butoon_Click(object sender, RoutedEventArgs e)
        {
            Line a = new Line();
            Line b = new Line();
            Line c = new Line();

            a.X1 = 40;
            a.Y1 = 20;
            a.X2 = 52;
            a.Y2 = 20;

            b.X1 = 52;
            b.Y1 = 20;
            b.X2 = 52;
            b.Y2 = 4;

            c.X1 = 40;
            c.Y1 = 20;
            c.X2 = 52;
            c.Y2 = 4;

            a.Stroke = new SolidColorBrush(Colors.Black);
            b.Stroke = new SolidColorBrush(Colors.Black);
            c.Stroke = new SolidColorBrush(Colors.Black);

            drawCanvas.Children.Add(a);
            drawCanvas.Children.Add(b);
            drawCanvas.Children.Add(c);
        }
    }
}
