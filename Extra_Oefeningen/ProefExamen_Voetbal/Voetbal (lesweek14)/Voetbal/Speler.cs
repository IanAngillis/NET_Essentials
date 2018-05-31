using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public enum SpelersFunctie
    {
        Doelman = 'D',
        Verdediger = 'V',
        Middenvelder = 'M',
        Aanvaller = 'A'
    }

    public class Speler
    {
        //Properties
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Rugnummer { get; set; }
        public SpelersFunctie Functie { get; set; }

        //Constructor
        public Speler(string newNaam, string newVoornaam, string newRugNummer, string newFunctie)
        {
            Naam = newNaam;
            Voornaam = newVoornaam;
            Rugnummer = newRugNummer;
            Functie = (SpelersFunctie)Convert.ToChar(newFunctie);
        }

        public override string ToString()
        {
            return Naam + " " + Voornaam;
        }

    }
}
