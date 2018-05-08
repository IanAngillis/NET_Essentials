using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Oefening_10_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer clock;
        private Wekker wekker;

        public MainWindow()
        {
            InitializeComponent();

            wekker = new Wekker();

            clock = new DispatcherTimer();
            clock.Interval = new TimeSpan(0, 0, 0, 1);
            clock.Tick += Clock_Tick;
            clock.Start();
            
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            tijdTextBlock_TextBlock.Text = wekker.GetCurrentTimeInString();

            if(wekker.IfCurrentEqualsAlarm())
            {
                wekker.SecondsPassedSinceAlarm++;
            }

            if(!wekker.AlarmIsOver())
            {
                wekker.ChangeBackGround(tijdTextBlock_TextBlock);
                wekker.PlaySound();
                wekker.SecondsPassedSinceAlarm++;
            } else
            {
                wekker.ResetSecondsPassedSinceAlarm();
            }
        }

        

        private void setAlarmButton_Button_Click(object sender, RoutedEventArgs e)
        {
            wekker.AlarmTijd = alarmTextBox_TextBox.Text;
        }
    }
}
