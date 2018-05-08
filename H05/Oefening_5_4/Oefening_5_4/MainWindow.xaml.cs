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

namespace Oefening_5_4
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
            double x = 50;
            double y = 50;
            double radius = 50;

            DrawCircle(drawCanvas_Canvas, new SolidColorBrush(Colors.Red), x, y, radius);
        }

        private void DrawCircle(Canvas canvas, SolidColorBrush brush, double xPos, double yPos, double radius)
        {
            Ellipse circle = new Ellipse();
            circle.Width = radius;
            circle.Height = radius;
            circle.Stroke = brush;
            circle.Margin = new Thickness(xPos + radius, yPos + radius, 0, 0);
            circle.Fill = brush;
            canvas.Children.Add(circle);
        }
    }
}
