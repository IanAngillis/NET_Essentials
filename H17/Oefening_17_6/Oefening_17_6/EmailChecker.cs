using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening_17_6
{
    public class EmailChecker
    {
        //Constructor
        public EmailChecker()
        {

        }

        public void CheckAdress(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                if (email.IndexOf("@") < email.IndexOf("."))
                {
                    MessageBox.Show("Valid email");
                    return;
                }
            }

            throw new InvalidEmailException("Email is not valid");
            
        }
    }
}
