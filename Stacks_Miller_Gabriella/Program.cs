namespace Stacks_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array of Card objects with different ranks and suits
            Card[] myCardsArray = new Card[]
            {
    new Card("Ace", "Spades"), // Ace of Spades
    new Card("Jack", "Clubs"), // Jack of Clubs
    new Card("Queen", "Diamonds"), // Queen of Diamonds
    new Card("Queen", "Diamonds"), // Another Queen of Diamonds
    new Card("10", "Hearts"), // 10 of Hearts
    new Card("2", "Diamonds"), // 2 of Diamonds
    new Card("6", "Spades"), // 6 of Spades
    new Card("9", "Clubs"), // 9 of Clubs
    new Card("Ace", "Diamonds"), // Ace of Diamonds
            };

            // Create a Stack of Card objects from the array
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            // Display the cards in the deck
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck) // Iterate through each card in the stack
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!"); // Output card number and suit
            }

            // Display the number of cards in the stack
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Initialize a new hand (list of cards) with specific cards
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds")); // Add Jack of Diamonds
            myHand.Add(new Card("8", "Hearts")); // Add 8 of Hearts
            myHand.Add(new Card("3", "Diamonds")); // Add 3 of Diamonds

            // Check if there are any 8's in the deck
            Console.WriteLine("Got any 8's?");
            if (startingDeck.Count > 0) // Ensure there are cards left in the stack
            {
                myHand.Add(startingDeck.Pop()); // Pop one card from the stack and add it to the hand
            }

            // Display the number of cards left in the stack after popping one
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Push the first card in the hand back into the stack
            startingDeck.Push(myHand[0]);
            // Remove the first card from the hand after pushing it to the stack
            myHand.RemoveAt(0);

            // Display the cards in the deck again
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck) // Iterate through the updated stack
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!"); // Output card number and suit
            }
        }
    }
}