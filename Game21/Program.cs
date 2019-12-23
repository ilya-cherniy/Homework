using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game21
{
    class Program
    {
        struct Card
        {
            public Weight weight;
            public Suits suit;
        }
        public enum Suits
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }
        public enum Weight
        {
            Ace,
            King,
            Lady,
            Jack,
            Ten,
            Nine,
            Eight,
            Seven,
            Six
        }

        private static void Main(string[] args)
        {
            Card[] deck = new Card[36];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deck[(i * 4) + j] = new Card();
                    deck[(i * 4) + j].weight = (Weight)i;
                    deck[(i * 4) + j].suit = (Suits)j;
                }
            }
            //for (int i = 0; i < 36; i++)
            //{
            //    Console.WriteLine(deck[i].weight + " " + deck[i].suit);
            //}
            int indexCard;
            Card[] tempCard = new Card[1];
            Random random = new Random();
            for (int j = 35; j > 0; j--)
            {
                indexCard = random.Next(j + 1);
                tempCard[0] = deck[j];
                deck[j] = deck[indexCard];
                deck[indexCard] = tempCard[0];
            }
            Console.WriteLine("****************************************");
            for (int i = 0; i < 36; i++)
            {
                Console.WriteLine(deck[i].weight + " " + deck[i].suit);

            }
            Console.ReadLine();
        }
    }
}
