using System;
using System.Windows;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private int total = 0;
        private int amountOfNumbersGenerated = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateButton_Button_Click(object sender, RoutedEventArgs e)
        {
            int randomNumber = rand.Next(200, 401);
            amountOfNumbersGenerated++;
            total += randomNumber;

            UpdateRandomNumber(randomNumber);
            UpdateAvarage();
        }

        private void UpdateRandomNumber(int randomNumber)
        {
            randomNumberTextBlock_TextBlock.Text = Convert.ToString(randomNumber);
        }

        private void UpdateAvarage()
        {
            gemiddeldeTextBlock_TextBlock.Text = Convert.ToString(GetAvarage());
        }

        private double GetAvarage()
        {
            return (double)total / amountOfNumbersGenerated;
        }
    }
}
