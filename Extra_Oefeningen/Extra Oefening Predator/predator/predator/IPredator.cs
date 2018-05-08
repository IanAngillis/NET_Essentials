using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predator
{
    interface IPredator
    {
        bool Starve { get; }
        Luis[] Chase(Luis[] predators);
        void Eat(Luis[] predators);
        double Distance(IPrey prey);
        IPredator Breed();
    }
}
