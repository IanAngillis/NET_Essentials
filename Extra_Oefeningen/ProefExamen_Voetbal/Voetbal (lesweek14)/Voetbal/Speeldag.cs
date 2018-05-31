using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public class Speeldag
    {

        //Properties
        public int DagNummer { get; set; }
        public List<Ploeg> PloegenReeks1 { get; set; }
        public List<Ploeg> PloegenReeks2 { get; set; }
        public List<int> ScoreReeks1 { get; set; }
        public List<int> ScoreReeks2 { get; set; }
        public DateTime Datum { get; set; }

        //Constructor
        public Speeldag(int newSpeeldag, List<Ploeg>ploegen, DateTime datum)
        {
            PloegenReeks1 = new List<Ploeg>();
            PloegenReeks2 = new List<Ploeg>();
            ScoreReeks1 = new List<int>();
            ScoreReeks2 = new List<int>();
            VoegPloegenToeAanReeksen(ploegen);
            ResetScores(ScoreReeks1);
            ResetScores(ScoreReeks2);
            DagNummer = newSpeeldag;
            Datum = datum;

        }

        public void ResetScores(List<int> reeks)
        {
            for(int i = 0; i < 8; i++)
            {
                reeks.Add(0);
            }
        }

        public void VoegPloegenToeAanReeksen(List<Ploeg> ploegen)
        {

            for(int i = 0; i < ploegen.Count; i++)
            {
                if(i < 8)
                {
                    PloegenReeks1.Add(ploegen[i]);
                }
                else
                {
                    PloegenReeks2.Add(ploegen[i]);
                }
            
            }
        }

        public override string ToString()
        {
            return "Speeldag " + DagNummer + ": " + Datum.ToShortDateString();
        }
    }
}
