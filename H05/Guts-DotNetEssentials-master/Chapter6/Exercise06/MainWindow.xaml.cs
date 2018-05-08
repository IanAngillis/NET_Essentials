using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        int secondsPassed = 0;
        Rectangle minuteRect = new Rectangle();
        Rectangle secondsRect = new Rectangle();

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;

            minuteRect.Height = 100;
            minuteRect.Width = 0;
            minuteRect.Stroke = new SolidColorBrush(Colors.Red);
            minuteRect.Fill = new SolidColorBrush(Colors.Red);
            minuteRect.Margin = new Thickness(0, 0, 0, 0);
            drawArea.Children.Add(minuteRect);
 
            secondsRect.Height = 100;
            secondsRect.Width = 0;
            secondsRect.Stroke = new SolidColorBrush(Colors.Red);
            secondsRect.Fill = new SolidColorBrush(Colors.Red);
            secondsRect.Margin = new Thickness(0, 150, 0, 0);
            drawArea.Children.Add(secondsRect);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsPassed++;

            if(secondsPassed % 3600 == 0)
            {
                minuteRect.Width = 0;
            }

            if(secondsPassed % 60 == 0)
            {
                UpdateMinutes();
            }

            UpdateSeconds();
            UpdateTime();
        }

        private void UpdateMinutes()
        {
            minuteRect.Width += 10;
            secondsRect.Width = 0;
        }

        private void UpdateSeconds()
        {
            secondsRect.Width += 10;
        }

        private void UpdateTime()
        {
            int seconds = secondsPassed;
            int hours;
            int minutes;

            hours = seconds / 3600;
            seconds %= 3600;

            minutes = seconds / 60;
            seconds %= 60;

            timeTextBlock_TextBlock.Text = string.Format("{0}:{1}:{2}", hours, minutes, seconds);
        }
    }
}
