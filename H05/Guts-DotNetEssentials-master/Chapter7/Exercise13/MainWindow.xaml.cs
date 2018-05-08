using System;
using System.Windows;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btwTextBlock_TextBlock.IsEnabled = false;
            totaalPrijsTextBlock_TextBlock.IsEnabled = false;
        }

        private void berekenButton_Button_Click(object sender, RoutedEventArgs e)
        {
            double nettoPrijs = Convert.ToInt32(nettoPrijsInputTextBox_TextBox.Text);
            
            if(verlaagdTariefCheckBox_CheckBox.IsChecked == true)
            {
                btwTextBlock_TextBlock.Text = Convert.ToString(nettoPrijs * 0.06);
                totaalPrijsTextBlock_TextBlock.Text = Convert.ToString(nettoPrijs * 1.06);
            } else
            {
                btwTextBlock_TextBlock.Text = Convert.ToString(nettoPrijs * 0.21);
                totaalPrijsTextBlock_TextBlock.Text = Convert.ToString(nettoPrijs * 1.21);
            }
        }
    }
}
