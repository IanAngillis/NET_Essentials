using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_10_4
{
    class PuntenTeller
    {

        private int score;

        public PuntenTeller()
        {
            ResetScore();
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public void IncreaseScore()
        {
            Score++;
        }

        public void DecreaseScore()
        {
            Score--;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.score = value;
            }
        }

    }
}
