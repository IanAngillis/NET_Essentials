using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise10
{
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressProgressBar_ProgressBar.Value += 20;

            if(progressProgressBar_ProgressBar.Value >= 100)
            {
                okButton_Button.IsEnabled = false;
                cancelButton_Button.IsEnabled = false;
                MessageBox.Show("U hebt slechts 5 seconden om in te loggen");
                timer.Stop();
            }
        }
        
    }
}
