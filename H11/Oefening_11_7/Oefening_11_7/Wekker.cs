using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Oefening_11_7
{
    public abstract class Wekker
    {
        private int aantalSecondenAlarm;
        private string alarmTijd;
        private int secondsPassedSinceAlarm;
        private TextBlock tijdsTextBlock;


        public Wekker(int aantalSecondenAlarm = 10)
        {
            this.aantalSecondenAlarm = aantalSecondenAlarm;
            this.ResetSecondsPassedSinceAlarm();
            this.CreateTijdsTextBlock();

        }

        public void removeTimeDisplayOn(Grid maingrid)
        {
            maingrid.Children.Remove(tijdsTextBlock);
        }

        public void DisplayTimeOn(Grid maingrid)
        {
            maingrid.Children.Add(tijdsTextBlock);
        }

        private void CreateTijdsTextBlock()
        {
            this.tijdsTextBlock = new TextBlock
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(166,112,0,0),
                TextWrapping = TextWrapping.Wrap,
                Text = "",
                Height = 50,
                Width = 177
            };
        }

        public bool AlarmIsOver()
        {
            if (this.secondsPassedSinceAlarm == 0)
            {
                return true;
            }

            if (this.secondsPassedSinceAlarm > aantalSecondenAlarm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ResetSecondsPassedSinceAlarm()
        {
            this.secondsPassedSinceAlarm = 0;
        }

        public bool IfCurrentEqualsAlarm()
        {
            if (this.GetCurrentTimeInString().Equals(alarmTijd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //To be implemented in derived classes
        public abstract void AlarmAction();

        public string GetCurrentTimeInString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        public int SecondsPassedSinceAlarm
        {
            get { return secondsPassedSinceAlarm; }
            set { secondsPassedSinceAlarm = value; }
        }

        public string AlarmTijd
        {
            get { return alarmTijd; }
            set { alarmTijd = value; }
        }

        public int AantalSecondenAlarm
        {
            get { return aantalSecondenAlarm; }
            set { aantalSecondenAlarm = value; }
        }

        public TextBlock TijdsTextBlock
        {
            get { return tijdsTextBlock; }
            set { tijdsTextBlock = value; }
        }

    }
}
