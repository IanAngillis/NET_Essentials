using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_13_8
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public char Geslact { get; set; }
        public string Adres { get; set; }
        public string Telefoon { get; set; }
        public string GeboorteDatum { get; set; }


        public Persoon(string newNaam, string newVoornaam, char newGeslacht, string newAdres, string newTelefoon, string newGeboorteDatum)
        {
            Naam = newNaam;
            Voornaam = newVoornaam;
            Geslact = newGeslacht;
            Adres = newAdres;
            Telefoon = newTelefoon;
            GeboorteDatum = newGeboorteDatum;
        }

        public override string ToString()
        {
            return Voornaam + " " + Naam;
        }
    }
}
