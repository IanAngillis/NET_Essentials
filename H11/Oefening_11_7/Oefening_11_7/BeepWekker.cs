using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_11_7
{
    public class BeepWekker : Wekker
    {
        public override void AlarmAction()
        {
            SystemSounds.Beep.Play();
        }
    }
}
