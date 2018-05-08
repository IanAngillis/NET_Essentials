using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Kanon
{
    class World
    {
        private Canvas worldCanvas;

        public World(int height = 600, int width = 1200)
        {
            worldCanvas = new Canvas
            {
                Width = width,
                Height = height,
                Background = new SolidColorBrush(Colors.Beige),
                Margin = new Thickness(-160, 100, 0, 0) 
            };

            Line x = new Line();

        }








        public Canvas WorldCanvas
        {
            get
            {
                return worldCanvas;
            }

            set
            {
                worldCanvas = value;
            }
        }
    }
}
