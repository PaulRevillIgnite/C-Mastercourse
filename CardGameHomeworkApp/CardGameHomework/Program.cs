using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJackDeck deck = new BlackJackDeck();

            List<PlayingCard> hand = deck.DrawCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        public List<PlayingCard> FullDeck = new List<PlayingCard>();
        public List<PlayingCard> DrawPile = new List<PlayingCard>();
        public List<PlayingCard> DiscardPile = new List<PlayingCard>();

        public void CreateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 13; y++)
                {
                    FullDeck.Add(new PlayingCard { Value = (CardValue)i, Suit = (CardSuit)y });
                }
            }
        }

        public void ShuffleDeck()
        {
            Random rnd = new Random();
            FullDeck = FullDeck.OrderBy(a => rnd.Next()).ToList();
        }

        public abstract List<PlayingCard> DrawCards();

        public PlayingCard DrawCard()
        {
            PlayingCard output = FullDeck.Take(1).First();

            return output;
        }
    }

    public class PlayingCard
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }
    }

    public class BlackJackDeck : Deck
    {
        public BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCard> DrawCards()
        {
            List<PlayingCard> hand = new List<PlayingCard>();

            for (int i = 0; i < 2; i++)
            {
                hand.Add(DrawCard());
            }

            return hand;
        }
    }
}
