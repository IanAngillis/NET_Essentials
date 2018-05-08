using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace domineering
{
    class Block
    {

        public int XRow { get; set; }
        public int YColumn { get; set; }
        public bool IsFilled { get; set; }
        public Rectangle BlockArea { get; set; }

        public Block(int row, int column, double marginLeft, double marginTop, double size)
        {
            XRow = row;
            YColumn = column;
            IsFilled = false;

            BlockArea = new Rectangle
            {
                Width = size,
                Height = size,
                Stroke = new SolidColorBrush(Colors.Black),
                Margin = new Thickness(marginLeft, marginTop, 7, 7)
            };
        }
    }
}
