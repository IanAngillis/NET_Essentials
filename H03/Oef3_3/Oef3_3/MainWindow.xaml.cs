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

namespace Oef3_3
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

            Rectangle house = new Rectangle();
            house.Width = 200;
            house.Height = 150;
            house.Margin = new Thickness(10, 50, 0, 0);
            house.Stroke = new SolidColorBrush(Colors.Black);

            Line roofLeftDiagonal = new Line();
            roofLeftDiagonal.X1 = 10;
            roofLeftDiagonal.Y1 = 50;
            roofLeftDiagonal.X2 = 110;
            roofLeftDiagonal.Y2 = 0;
            roofLeftDiagonal.Stroke = new SolidColorBrush(Colors.Black);

            Line roofRightDiagonal = new Line();
            roofRightDiagonal.X1 = 210;
            roofRightDiagonal.Y1 = 50;
            roofRightDiagonal.X2 = 110;
            roofRightDiagonal.Y2 = 0;
            roofRightDiagonal.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle door = new Rectangle();
            door.Width = 40;
            door.Height = 60;
            door.Margin = new Thickness(85, 140, 0, 0);
            door.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle leftWindow = new Rectangle();
            leftWindow.Width = 30;
            leftWindow.Height = 30;
            leftWindow.Margin = new Thickness(40, 100, 0, 0);
            leftWindow.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle rightWindow = new Rectangle();
            rightWindow.Width = 30;
            rightWindow.Height = 30;
            rightWindow.Margin = new Thickness(140, 100, 0, 0);
            rightWindow.Stroke = new SolidColorBrush(Colors.Black);

            //Adding drawing to the canvas
            drawCanvas_Canvas.Children.Add(house);
            drawCanvas_Canvas.Children.Add(roofLeftDiagonal);
            drawCanvas_Canvas.Children.Add(roofRightDiagonal);
            drawCanvas_Canvas.Children.Add(door);
            drawCanvas_Canvas.Children.Add(leftWindow);
            drawCanvas_Canvas.Children.Add(rightWindow);
        }
    }
}
