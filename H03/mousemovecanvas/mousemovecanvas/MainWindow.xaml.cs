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

namespace mousemovecanvas
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

        private void tekenCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            PositionTextBox_TextBox.Text = e.GetPosition(tekenCanvas).ToString();
            Point punt = new Point();
            punt = e.GetPosition(tekenCanvas);
            PositionTextBox2_TextBox.Text = punt.ToString();
        }
    }
}
