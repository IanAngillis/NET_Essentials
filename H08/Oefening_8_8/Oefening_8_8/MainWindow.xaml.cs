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

namespace Oefening_8_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int firstNumber = 1;
            int secondNumber = 1;
            int newNumber;

            MessageBox.Show(Convert.ToString(firstNumber));
            MessageBox.Show(Convert.ToString(secondNumber));


            for (int i = 2; i < 20; i++)
            {
                newNumber = firstNumber + secondNumber;
                MessageBox.Show(Convert.ToString(newNumber));

                firstNumber = secondNumber;
                secondNumber = newNumber;
            }
        }
    }
}
