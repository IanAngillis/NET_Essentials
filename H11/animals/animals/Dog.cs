using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    public class Dog : Animal
    {
        public Dog(string naam) : base (naam)
        {

        }

        public override string Sound()
        {
            return "Woef woef";
        }
    }
}
