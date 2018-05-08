using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_10_5
{
     public class DobbelSteen
    {
        private Random rand = new Random();

        public int GooiDobbelsteen()
        {
            return (rand.Next(6) + 1);
        }
    }
}
