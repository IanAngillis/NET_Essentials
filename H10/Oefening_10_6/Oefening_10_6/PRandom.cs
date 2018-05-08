using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_10_6
{
    class PRandom
    {
        private int oldR;
        private int newR;

        public PRandom(int seed)
        {
            this.oldR = seed;
        }

        public int NextRandom()
        {
            this.newR = ((this.oldR * 25173) + 13849) % 65536;
            this.oldR = newR;

            return newR;
        }

    }
}
