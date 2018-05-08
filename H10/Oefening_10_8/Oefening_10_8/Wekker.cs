using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Oefening_10_8
{
    public class Wekker
    {
        private int aantalSecondenAlarm;
        private string alarmTijd;
        private int secondsPassedSinceAlarm;
     

        public Wekker(int aantalSecondenAlarm = 10)
        {
            this.aantalSecondenAlarm = aantalSecondenAlarm;
            this.ResetSecondsPassedSinceAlarm();
        
        }

        public bool AlarmIsOver()
        {
            if(this.secondsPassedSinceAlarm == 0)
            {
                return true;
            }

            if(this.secondsPassedSinceAlarm > aantalSecondenAlarm)
            {
                return true;
            } else
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
            if(this.GetCurrentTimeInString().Equals(alarmTijd))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void PlaySound()
        {
            SystemSounds.Beep.Play();
        }

        public void ChangeBackGround(TextBlock textblock)
        {
            if(this.secondsPassedSinceAlarm % 2 == 1)
            {
                textblock.Background = new SolidColorBrush(Colors.Red);
            } else
            {
                textblock.Background = new SolidColorBrush(Colors.Transparent);
            }
        }

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

}
}
