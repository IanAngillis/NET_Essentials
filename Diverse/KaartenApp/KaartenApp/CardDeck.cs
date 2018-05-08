using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartenApp
{
    class CardDeck
    {
        //Class variables
        private List<Card> list = new List<Card>();

        //Constructor
        public CardDeck()
        {
            CreateDeck();
        }

        //Class methods
        public void CreateDeck()
        {
            
            for(int i = 0; i < Card.SuitList.Count; i++)
            {

                for(int j = 0; j < Card.ValueList.Count; j++)
                {
                    list.Add(new Card(Card.ValueList[j], Card.SuitList[i]));
                }
            }
           
        }

        //Shuffle function

        //Class properties
        public List<Card> Deck
        {
            get { return list; }
            set { list = value; }
        }

    }
}
