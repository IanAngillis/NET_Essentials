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
using System.Windows.Threading;

namespace Oefening_11_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer clock;
        Wekker wekker;
        private bool clockIsRunning;

        public MainWindow()
        {
            InitializeComponent();
            //Instellen klok
            clock = new DispatcherTimer();
            clock.Interval = new TimeSpan(0, 0, 0, 1);
            clock.Tick += Clock_Tick;
            clockIsRunning = false;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            wekker.TijdsTextBlock.Text = wekker.GetCurrentTimeInString();

            if (wekker.IfCurrentEqualsAlarm())
            {
                wekker.SecondsPassedSinceAlarm++;
            }

            if (!wekker.AlarmIsOver())
            {

                wekker.AlarmAction();
                wekker.SecondsPassedSinceAlarm++;
            }
            else
            {
                wekker.ResetSecondsPassedSinceAlarm();
            }
        }

        private void SetAlarmButton_Button_Click(object sender, RoutedEventArgs e)
        {   
            wekker.AlarmTijd = alarmTextBox_TextBox.Text;
        }

        private void KnipperWekker_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!clockIsRunning)
            {
                clock.Start();
                clockIsRunning = true;
            }
            else
            {
                wekker.removeTimeDisplayOn(mainGrid);
            }
            wekker = null;
            wekker = new KnipperWekker();
            wekker.DisplayTimeOn(mainGrid);
        }

        private void BeepWekker_RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (!clockIsRunning)
            {
                clock.Start();
                clockIsRunning = true;
            } else
            {
                wekker.removeTimeDisplayOn(mainGrid);
            }
            wekker = null;
            wekker = new BeepWekker();
            wekker.DisplayTimeOn(mainGrid);
        }
    }
}
