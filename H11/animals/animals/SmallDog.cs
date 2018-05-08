using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    class SmallDog : Animal
    {
        public SmallDog(string naam) : base(naam)
        {

        }

        public override string Sound()
        {
            return "Kef Kef";
        }
    }
}
