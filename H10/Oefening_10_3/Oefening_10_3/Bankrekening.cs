using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening_10_3
{
    class Bankrekening
    {
        private double saldo = 0;

        public void Storting(double amount)
        {
            Saldo += amount;
        }

        public void Opname(double amount)
        {

            if(Saldo + amount < 0)
            {
                MessageBox.Show("U heeft te weinig krediet");
            } else
            {
                Saldo += amount;
            }

        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
    }
}
