using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Oefening_11_7
{
    public class KnipperWekker : Wekker
    {
        public override void AlarmAction()
        {
            this.TijdsTextBlock.Background = this.SecondsPassedSinceAlarm % 2 == 1 ? new SolidColorBrush(Color.FromRgb(132, 8, 225)) : new SolidColorBrush(Colors.Transparent);
        }
    }
}
