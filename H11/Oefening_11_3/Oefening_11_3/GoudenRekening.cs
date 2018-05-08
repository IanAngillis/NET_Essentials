using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_11_3
{
    class GoudenRekening : Rekening
    {
        public override double BerekenRente()
        {
            return this.HuidigSaldo * 0.1;
        }
    }
}
