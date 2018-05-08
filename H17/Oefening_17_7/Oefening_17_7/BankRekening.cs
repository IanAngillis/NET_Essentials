using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_17_7
{
    class BankRekening
    {
        public int Saldo { get; set; }
        public string RekeningHouder { get; set; }
        public string RekeningNummber { get; set; }

        public BankRekening()
        {
            Saldo = 0;
            RekeningHouder = "Ian Angillis";
            RekeningNummber = "048-80499-02";
        }

        public void Storten(int bedrag)
        {
            if(bedrag > 2500)
            {
                throw new BankRekeningException("Een storting kan maximaal 2500 euro bedragen");
            } else
            {
                Saldo += bedrag;
            }
        }

        public void Opnemen(int bedrag)
        {
            if(Saldo - bedrag < 0)
            {
                throw new BankRekeningException("Het saldo kan nooit onder 0 gaan");
            } else
            {
                Saldo -= bedrag;
            }
        }

    }
}
