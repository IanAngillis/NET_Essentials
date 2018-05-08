using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predator
{
    class Luis : Insect, IPrey
    {
        public double XPosition => this.XCoord;

        public double YPosition => this.YCoord;

        public Luis(double x, double y)
            : base (x, y)
        {
            //NOTHING
        }

        public IPrey Breed()
        {
            if(this.Age % 5 == 0)
            {
                return new Luis(this.XCoord, this.YCoord);
            }

            return null;
        }
    }
}
