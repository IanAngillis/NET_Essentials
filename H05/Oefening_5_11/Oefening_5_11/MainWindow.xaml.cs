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

namespace Oefening_5_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int aantalSeconden = TijdInSec(1, 1, 2);
            MessageBox.Show(Convert.ToString(aantalSeconden), "Tijd in seconden");
        }

        private int TijdInSec(int uren, int minuten, int seconden)
        {
            return uren * 3600 + minuten * 60 + seconden;
        }
    }
}
