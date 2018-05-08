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

namespace Oef3_6
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
            //Maak gezicht
            Ellipse gezicht = new Ellipse();
            gezicht.Width = 300;
            gezicht.Height = 300;
            gezicht.Fill = new SolidColorBrush(Colors.LightPink);
            gezicht.Stroke = new SolidColorBrush(Colors.Black);

            //Maak linkeroog
            Ellipse linkeroog = new Ellipse();
            linkeroog.Width = 30;
            linkeroog.Height = 20;
            linkeroog.Fill = new SolidColorBrush(Colors.White);
            linkeroog.Stroke = new SolidColorBrush(Colors.Black);
            linkeroog.Margin = new Thickness(80, 120, 0, 0);

            //Maak linkeroogbal
            Ellipse linkeroogBal = new Ellipse();
            linkeroogBal.Width = 5;
            linkeroogBal.Height = 5;
            linkeroogBal.Fill = new SolidColorBrush(Colors.Black);
            linkeroogBal.Stroke = new SolidColorBrush(Colors.Black);
            linkeroogBal.Margin = new Thickness(90, 124, 0, 0);

            //Maak rechteroog
            Ellipse rechteroog = new Ellipse();
            rechteroog.Width = 30;
            rechteroog.Height = 20;
            rechteroog.Fill = new SolidColorBrush(Colors.White);
            rechteroog.Stroke = new SolidColorBrush(Colors.Black);
            rechteroog.Margin = new Thickness(200, 120, 0, 0);

            //Maak rechteroogBal
            Ellipse rechteroogBal = new Ellipse();
            rechteroogBal.Width = 5;
            rechteroogBal.Height = 5;
            rechteroogBal.Fill = new SolidColorBrush(Colors.Black);
            rechteroogBal.Stroke = new SolidColorBrush(Colors.Black);
            rechteroogBal.Margin = new Thickness(215, 124, 0, 0);

            //Maak neus
            Line horizontalNoseLine = new Line();
            horizontalNoseLine.X1 = 150;
            horizontalNoseLine.Y1 = 170;
            horizontalNoseLine.X2 = 130;
            horizontalNoseLine.Y2 = 170;
            horizontalNoseLine.Stroke = new SolidColorBrush(Colors.Black);

            Line diagonalNoseLine = new Line();
            diagonalNoseLine.X1 = 130;
            diagonalNoseLine.Y1 = 170;
            diagonalNoseLine.X2 = 150;
            diagonalNoseLine.Y2 = 125;
            diagonalNoseLine.Stroke = new SolidColorBrush(Colors.Black);

            //Maak mond
            Ellipse mond = new Ellipse();
            mond.Width = 60;
            mond.Height = 45;
            mond.Fill = new SolidColorBrush(Colors.Red);
            mond.Stroke = new SolidColorBrush(Colors.Black);
            mond.Margin = new Thickness(115, 200, 0, 0);

            //Maak haar

            Line hair1 = new Line();
            hair1.X1 = 130;
            hair1.Y1 = 40;
            hair1.X2 = 150;
            hair1.Y2 = 0;
            hair1.Stroke = new SolidColorBrush(Colors.Black);

            Line hair2 = new Line();
            hair2.X1 = 140;
            hair2.Y1 = 40;
            hair2.X2 = 150;
            hair2.Y2 = 0;
            hair2.Stroke = new SolidColorBrush(Colors.Black);

            Line hair3 = new Line();
            hair3.X1 = 150;
            hair3.Y1 = 40;
            hair3.X2 = 150;
            hair3.Y2 = 0;
            hair3.Stroke = new SolidColorBrush(Colors.Black);

            Line hair4 = new Line();
            hair4.X1 = 160;
            hair4.Y1 = 40;
            hair4.X2 = 150;
            hair4.Y2 = 0;
            hair4.Stroke = new SolidColorBrush(Colors.Black);

            Line hair5 = new Line();
            hair5.X1 = 170;
            hair5.Y1 = 40;
            hair5.X2 = 150;
            hair5.Y2 = 0;
            hair5.Stroke = new SolidColorBrush(Colors.Black);



            //tekeningen toevoegen aan canvas
            drawCanvas_Canvas.Children.Add(gezicht);
            drawCanvas_Canvas.Children.Add(linkeroog);
            drawCanvas_Canvas.Children.Add(linkeroogBal);
            drawCanvas_Canvas.Children.Add(rechteroog);
            drawCanvas_Canvas.Children.Add(rechteroogBal);
            drawCanvas_Canvas.Children.Add(horizontalNoseLine);
            drawCanvas_Canvas.Children.Add(diagonalNoseLine);
            drawCanvas_Canvas.Children.Add(mond);
            drawCanvas_Canvas.Children.Add(hair1);
            drawCanvas_Canvas.Children.Add(hair2);
            drawCanvas_Canvas.Children.Add(hair3);
            drawCanvas_Canvas.Children.Add(hair4);
            drawCanvas_Canvas.Children.Add(hair5);
        }
    }
}
