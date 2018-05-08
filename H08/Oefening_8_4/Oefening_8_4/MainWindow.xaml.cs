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

namespace Oefening_8_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
            int xPos = 20;
            int yPos = 20;

            for(int i = 0; i < 6; i++)
            {

                for(int j = 0; j < (i+1); j++)
                {
                    DrawRectangle(xPos, yPos);
                    xPos += 25;
                }


                xPos = 20;
                yPos += 25;
            }
        }

        private void DrawRectangle(int xPos, int yPos)
        {
            Rectangle rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Black);
            rect.Margin = new Thickness(xPos, yPos, 0, 0);
            rect.Width = 20;
            rect.Height = 20;

            drawCanvas_Canvas.Children.Add(rect);
        }
    }

   
}
