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

namespace Oefening_4_9
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

        private void calculateButton_Button_Click(object sender, RoutedEventArgs e)
        {
            int amountGiven = Convert.ToInt32(geldTextBox_TextBox.Text);
            int itemCost = Convert.ToInt32(prijsProductTextBox_TextBox.Text);
            int difference = amountGiven - itemCost;
            int temp;

            wisselGeldTextBlock_TextBlock.Text = difference.ToString();

            if(difference < 0)
            {
                MessageBox.Show("Niet genoeg geld");
                return;
            }
            else
            {
                temp = difference / 200;
                euro2TextBlock_TextBlock.Text = Convert.ToString(temp);

                if(difference % 200 != 0)
                {
                    difference = difference % 200;
                }
                else
                {
                    return;
                }

                temp = difference / 100;
                euro1TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 100 != 0)
                {
                    difference = difference % 100;
                }
                else
                {
                    return;
                }

                temp = difference / 50;
                cent50TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 50 != 0)
                {
                    difference = difference % 50;
                }
                else
                {
                    return;
                }

                temp = difference / 20;
                cent20TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 20 != 0)
                {
                    difference = difference % 20;
                }
                else
                {
                    return;
                }

                temp = difference / 10;
                cent10TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 10 != 0)
                {
                    difference = difference % 10;
                }
                else
                {
                    return;
                }

                temp = difference / 5;
                cent5TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 5 != 0)
                {
                    difference = difference % 5;
                }
                else
                {
                    return;
                }

                temp = difference / 2;
                cent2TextBlock_TextBlock.Text = Convert.ToString(temp);

                if (difference % 2 != 0)
                {
                    difference = difference % 2;
                }
                else
                {
                    return;
                }

                cent1TextBlock_TextBlock.Text = Convert.ToString(difference);
            }
            }
        }
    }

