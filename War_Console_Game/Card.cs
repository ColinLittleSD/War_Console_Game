using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace War_Console_Game
{
    public class Card
    {
        public CardSuit Suit;
        public int Value { get; }
        public Card(CardSuit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

    }
    //CardSuit is our type, in a property named Suit

    public enum CardSuit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }

}