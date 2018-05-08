using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void manRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(manRadioButton.IsChecked == true)
            {
                return;
            }
        }

        private void vrouwRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (vrouwRadioButton.IsChecked == true)
            {
                return;
            }
        }

        private void leeftijdTussen18En30RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (leeftijdTussen18En30RadioButton.IsChecked == true)
            {
                return;
            }
        }

        private void leeftijdTussen30En45RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (leeftijdTussen30En45RadioButton.IsChecked == true)
            {
                return;
            }
        }

        private void leeftijdTussen45En60RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (leeftijdTussen45En60RadioButton.IsChecked == true)
            {
                return;
            }
        }

        private void leeftijdOuderDan60Button_Checked(object sender, RoutedEventArgs e)
        {
            if (leeftijdOuderDan60Button.IsChecked == true)
            {
                return;
            }
        }
    }
}
