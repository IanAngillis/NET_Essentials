using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predator
{
    public interface IPrey
    {
        double XPosition{ get; }
        double YPosition { get; }
        IPrey Breed();
    }
}
