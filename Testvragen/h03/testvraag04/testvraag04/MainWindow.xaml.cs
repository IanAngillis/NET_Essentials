﻿using System;
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

namespace testvraag04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Line horizontal = new Line();
            Line vertical = new Line();

            horizontal.X1 = 20;
            horizontal.X2 = 80;
            horizontal.Y1 = 20;
            horizontal.Y2 = 20;

            horizontal.Stroke = new SolidColorBrush(Colors.Black);
            horizontal.StrokeThickness = 4;

            vertical.X1 = 50;
            vertical.X2 = 50;
            vertical.Y1 = 20;
            vertical.Y2 = 100;

            vertical.Stroke = new SolidColorBrush(Colors.Black);
            vertical.StrokeThickness = 4;

            DrawCanvas.Children.Add(horizontal);
            DrawCanvas.Children.Add(vertical);
        }
    }
}
