using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_17_7
{
    public class BankRekeningException : ApplicationException
    {
        public BankRekeningException(string message) : base(message)
        {

        }
    }
}
