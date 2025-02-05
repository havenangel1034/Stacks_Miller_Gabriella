using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Miller_Gabriella
{
    internal class Card
    {
        // Property to store the card's number (e.g., "Ace", "2", "King")
        public string Number { get; }

        // Property to store the card's suit (e.g., "Spades", "Hearts", "Clubs")
        public string Suit { get; }

        // Constructor for the Card class that initializes the card's number and suit
        public Card(string numParam, string suitParam)
        {
            // Assign the provided number parameter to the Number property
            Number = numParam;
            // Assign the provided suit parameter to the Suit property
            Suit = suitParam;
        }
    }
}
