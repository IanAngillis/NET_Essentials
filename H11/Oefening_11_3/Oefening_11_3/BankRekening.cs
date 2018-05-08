using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_11_3
{
    public class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if(this.HuidigSaldo > 100)
            {
                return this.HuidigSaldo * 0.01;
            } else
            {
                return 0;
            }
        }
    }
}
