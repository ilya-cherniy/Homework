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

            Card[] gamer = new Card[10];
            Card[] computer = new Card[10];

            int CardValue(string card)
            {
                int realValue = 0;
                switch (card)
                {
                    case "Six":
                        realValue = 6;
                        break;
                    case "Seven":
                        realValue = 7;
                        break;
                    case "Eight":
                        realValue = 8;
                        break;
                    case "Nine":
                        realValue = 9;
                        break;
                    case "Ten":
                        realValue = 10;
                        break;
                    case "Jack":
                        realValue = 2;
                        break;
                    case "Lady":
                        realValue = 3;
                        break;
                    case "King":
                        realValue = 4;
                        break;
                    case "Ace":
                        realValue = 11;
                        break;
                }
                return realValue;
            }

            Console.WriteLine("Please select 0 or 1 to decide who will start firts - Gamer or Computer");
            string gamerChoice = Console.ReadLine();
            int gCoin = -1;
            switch (gamerChoice)
            {
                case "0":
                    gCoin = 0;
                    break;
                case "1":
                    gCoin = 1;
                    break;
                default:
                    Console.WriteLine("Please input correct decision");
                    break;
            }
            int randomCoin = random.Next(2);
            Console.WriteLine("Random coin: {0}",randomCoin);
            if (gCoin == randomCoin)
            {
                Console.WriteLine("Gamer first");
            }
            else
            {
                Console.WriteLine("PC first");
            }

            //give 2 cards to each gamer
            for (int i = 0; i < 2; i++)
            {
                gamer[i] = deck[i];
            }
            int gamerScore = 0;
            int computerScore = 0;
            Console.WriteLine("****************************************");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(gamer[i].weight + " " + gamer[i].suit);
                string cardValue = (gamer[i].weight).ToString();
                gamerScore = gamerScore + CardValue(cardValue);
            }
            Console.WriteLine(gamerScore);
            Console.WriteLine("****************************************");
            for (int i = 2; i < 4; i++)
            {
                computer[i] = deck[i];
            }
            for (int i = 2; i < 4; i++)
            {
                Console.WriteLine(computer[i].weight + " " + computer[i].suit);
                string cardValue = (computer[i].weight).ToString();
                computerScore = computerScore + CardValue(cardValue);
            }
            Console.WriteLine(computerScore);

            Console.WriteLine("what do you want? Get [G] one more card or stop [S] receiving cards?");
            bool action = true;
            string decision = Console.ReadLine();
            switch (decision)
            {
                case "G":
                    action = true;
                    break;
                case "S":
                    action = false;
                    break;
                default:
                    Console.WriteLine("Please input correct decision");
                    break;
            }
            //while (!action)
            //{


            //}
               


            Console.ReadLine();
        }
    }
}
