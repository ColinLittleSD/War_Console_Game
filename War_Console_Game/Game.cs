using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Console_Game
{
    class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Deck CardDeck { get; set; }

        public Game()
        {
            PlayerOne = new Player("Colin");
            PlayerTwo = new Player("Max");
            CardDeck = new Deck();
        }

        public void PlayGame()
        { 
            while (CardDeck.Cards.Count > 0)
            {
                PlayersDrawCards();
                //SeeDeck();
                SeePoints();
            }
            if (PlayerOne.Points > PlayerTwo.Points)
            {
                Console.WriteLine($"{PlayerOne.Name} won the game!");
            }
            else if (PlayerTwo.Points > PlayerOne.Points)
            {
                Console.WriteLine($"{PlayerTwo.Name} won the game!");
            }
            else
            {
                Console.WriteLine("It's a Tie! Play Again");
            }

            Console.WriteLine($"Game Over");
        }

        public void PlayersDrawCards()
        {
            Card playerOneDrawnCard = CardDeck.Cards.FirstOrDefault();
            CardDeck.Cards.Remove(playerOneDrawnCard);
            PlayerOne.CardsInHand.Add(playerOneDrawnCard);

            Card playerTwoDrawnCard = CardDeck.Cards.FirstOrDefault();
            CardDeck.Cards.Remove(playerTwoDrawnCard);
            PlayerTwo.CardsInHand.Add(playerTwoDrawnCard);

            if (playerOneDrawnCard.Value > playerTwoDrawnCard.Value)
            {
                PlayerOne.Points += 1;
                Console.WriteLine($"{PlayerOne.Name} won the draw with {playerOneDrawnCard.ToString()} over " +
                                   $"{PlayerTwo.Name}'s {playerTwoDrawnCard.ToString()}");
            }
            else if (playerTwoDrawnCard.Value > playerOneDrawnCard.Value)
            {
                PlayerTwo.Points += 1;
                Console.WriteLine($"{PlayerTwo.Name} won the draw with {playerTwoDrawnCard.ToString()} over " +
                                   $"{PlayerOne.Name}'s {playerOneDrawnCard.ToString()}");
            }
            else
            {
                Console.WriteLine("Tie. No Points");
            }
        }

        public void SeeDeck()
        {
            foreach (Card c in CardDeck.Cards)
            {
                Console.WriteLine($"{c.Value} of {c.Suit}");
            }
            Console.WriteLine($"Card Count - {CardDeck.Cards.Count}");
        }

        public void SeePoints()
        {
            Console.WriteLine($"{PlayerOne.Name} - { PlayerOne.Points} vs. {PlayerTwo.Name} - {PlayerTwo.Points}");
        }
    }
}
