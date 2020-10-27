using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Console_Game
{
    class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck() 
        { 
            for (int suit = 0; suit <= 3; suit++)
            {
                CardSuit cardSuitType;
                if (suit == 0)
                {
                    cardSuitType = CardSuit.Heart;
                } 
                else if (suit == 1)
                {
                    cardSuitType = CardSuit.Diamond;
                } 
                else if (suit == 2)
                {
                    cardSuitType = CardSuit.Spade;
                } 
                else
                {
                    cardSuitType = CardSuit.Club;
                }
                for (int cardValue = 2; cardValue <= 14; cardValue++)
                {
                    Card card = new Card(cardSuitType, cardValue);
                    Cards.Add(card);
                }
            }

            Shuffle();
        }

        private void Shuffle()
        {
            Random randy = new Random();
            int currentCardIndex = Cards.Count;
            while (currentCardIndex > 1)
            {
                currentCardIndex--;
                int swapIndex = randy.Next(currentCardIndex + 1);
                Card tempCard = Cards[swapIndex];
                Cards[swapIndex] = Cards[currentCardIndex];
                Cards[currentCardIndex] = tempCard;
            }
        }


        // switch this to <int, string> and reverse values. 
        // Value is now stored as an int in Card
        private Dictionary<string, int> CardValuesToScore = new Dictionary<string, int>()
        {
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "10", 10 },
            { "Jack", 11 },
            { "Queen", 12 },
            { "King", 13 },
            { "Ace", 14 },
        };
    }
}
