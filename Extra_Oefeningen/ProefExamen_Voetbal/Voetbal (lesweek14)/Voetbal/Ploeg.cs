using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public class Ploeg
    {
        //Properties
        public string Stamnummer { get; set; }
        public string Naam { get; set; }
        public int Punten { get; set; }
        public List<Speler> Spelers { get; set; }

        //Constructor
        public Ploeg(string newStamnummer, string newNaam)
        {
            Stamnummer = newStamnummer;
            Naam = newNaam;
            Punten = 0;
            Spelers = new List<Speler>();
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
