using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private int totalSum;
        private char currentSign;
        private char previousSign;
        private string newNumber;
        private string textBoxString;
        private Boolean hasJustCalculated;

        public MainWindow()
        {
            InitializeComponent();
          

            totalSum = 0;
            previousSign = '+';
            hasJustCalculated = false;

            digit0Button_Button.Click += digitButton_Button_Click;
            digit1Button_Button.Click += digitButton_Button_Click;
            digit2Button_Button.Click += digitButton_Button_Click;
            digit3Button_Button.Click += digitButton_Button_Click;
            digit4Button_Button.Click += digitButton_Button_Click;
            digit5Button_Button.Click += digitButton_Button_Click;
            digit6Button_Button.Click += digitButton_Button_Click;
            digit7Button_Button.Click += digitButton_Button_Click;
            digit8Button_Button.Click += digitButton_Button_Click;
            digit9Button_Button.Click += digitButton_Button_Click;

            plusButton_Button.Click += operationButton_Click;
            minusButton_Button.Click += operationButton_Click;
            calculatorScreenTextBlock_TextBlock.Text = "0";
        }

        private void operationButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            currentSign =Convert.ToChar(btn.Content);

            textBoxString += btn.Content;
            calculatorScreenTextBlock_TextBlock.Text = textBoxString;

            calculateSum();

            previousSign = currentSign;
            newNumber = "";
        }

        private void digitButton_Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) sender;

            textBoxString += btn.Content;
            calculatorScreenTextBlock_TextBlock.Text = textBoxString;
            newNumber += btn.Content;
        }

        private void calculateSum()
        {
            if (hasJustCalculated)
            {
                hasJustCalculated = false;
                return;
            }

            if (previousSign.Equals('+'))
            {
                totalSum += Convert.ToInt32(newNumber);
            } else
            {
                totalSum -= Convert.ToInt32(newNumber);
            }
        }

        private void calculateButton_Button_Click(object sender, RoutedEventArgs e)
        {
            if(newNumber.Length > 0)
            {
                calculateSum();
            } 
           

            textBoxString = Convert.ToString(totalSum);
            calculatorScreenTextBlock_TextBlock.Text = textBoxString;
            newNumber = Convert.ToString(totalSum);
            hasJustCalculated = true;
        }

        private void clearButton_Button_Click(object sender, RoutedEventArgs e)
        {
            totalSum = 0;
            newNumber = "";
            textBoxString = "";
            calculatorScreenTextBlock_TextBlock.Text = "0";
        }
    }
}
