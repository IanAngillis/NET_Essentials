using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartenApp
{
    internal class Card
    {

        //Class variables
        private string cardNumber;
        private string cardSuit;
        private int cardValue;

        //static variables, we need this to create cards
        private static List<string> suitList = new List<string> {"Hearts", "Spades", "Diamonds", "Cubes" };
        private static List<string> valueList = new List<string> { "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        //Constructor
        public Card(string newKaartNumber, string newKaartSoort)
        {
            this.Number = newKaartNumber;
            this.Suit = newKaartSoort;

            this.Value = Card.AssignCardValue(this.Number);
        }

        //Class methods
        public override string ToString()
        {
            return this.Number + " of " + this.Suit;
        }

        public string getLocation()
        {
            return "./images/" + this.Suit + this.Number + ".png";
        }

        //Class properties
        public string Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }

        public string Number
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int Value
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        //Static methods
        public static int AssignCardValue(string nummer)
        {
            int temp = 0;

            switch (nummer)
            {
                case "deuce":
                    temp = 2;
                    break;
                case "three":
                    temp = 3;
                    break;
                case "four":
                    temp = 4;
                    break;
                case "five":
                    temp = 5;
                    break;
                case "six":
                    temp = 6;
                    break;
                case "seven":
                    temp = 7;
                    break;
                case "eight":
                    temp = 8;
                    break;
                case "nine":
                    temp = 9;
                    break;
                case "ten":
                    temp = 10;
                    break;
                case "jack":
                    temp = 11;
                    break;
                case "queen":
                    temp = 12;
                    break;
                case "king":
                    temp = 13;
                    break;
                case "ace":
                    temp = 14;
                    break;
            }

            return temp;
        }

        //Static properties
        public static List<string> ValueList
        {
            get { return valueList; }
            set { valueList = value; }
        }


        public static List<string> SuitList
        {
            get { return suitList; }
            set { suitList = value; }
        }
    }
}
