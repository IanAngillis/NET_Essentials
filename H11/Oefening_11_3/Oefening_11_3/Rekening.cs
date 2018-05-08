using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening_11_3
{
    public abstract class Rekening
    {
        private int huidigSaldo;
        
        public virtual void CreditSaldo(int saldo)
        {
            if(this.huidigSaldo - saldo < 0)
            {
                MessageBox.Show("Bankrekening kan niet onder nul");
            } else
            {
                this.huidigSaldo -= saldo;
            }
        }
        
        public virtual void DebitSaldo(int saldo)
        {
            this.huidigSaldo += saldo;
        }

        public abstract double BerekenRente();



        public int HuidigSaldo 
        {
            get { return huidigSaldo; }
            set { huidigSaldo = value; }
        }

    }
}
