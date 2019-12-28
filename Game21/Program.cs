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

            Console.WriteLine("Please select [0] or [1] to decide who will start firts - Gamer or Computer");
            string gamerInput = Console.ReadLine();
            int gamerChoice = -1;
            bool correctInput = false;
            while (!correctInput)
            {
                if (Int32.TryParse(gamerInput, out gamerChoice) && (gamerChoice == 0 || gamerChoice == 1))
                {
                    Console.WriteLine(gamerChoice);
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Entered value is not correct");
                }
            }

            int randomCoin = random.Next(2);
            Console.WriteLine("Random coin: {0}", randomCoin);
            if (gamerChoice == randomCoin)
            {
                Console.WriteLine("Gamer first");
            }
            else
            {
                Console.WriteLine("PC first");
            }


            //string gamerChoice = Console.ReadLine();
            //int gCoin = -1;


            //give 2 cards to each gamer
            Console.WriteLine("****************************************");
            int gamerScore = 0;
            int computerScore = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    gamer[i] = deck[i];
                    //Console.WriteLine(gamer[i].weight + " " + gamer[i].suit);
                    //string cardValue = (gamer[i].weight).ToString();
                    //gamerScore = gamerScore + CardValue(cardValue);

                }
                else
                {
                    computer[i] = deck[i];
                    //Console.WriteLine(computer[i].weight + " " + computer[i].suit);
                    //string cardValue = (computer[i].weight).ToString();
                    //computerScore = computerScore + CardValue(cardValue);
                }
                Console.WriteLine(gamer[i].weight + " " + gamer[i].suit);
                string cardValuePlayer1 = (gamer[i].weight).ToString();
                gamerScore = gamerScore + CardValue(cardValuePlayer1);
                Console.WriteLine(computer[i].weight + " " + computer[i].suit);
                string cardValuePlayer2 = (computer[i].weight).ToString();
                computerScore = computerScore + CardValue(cardValuePlayer2);
            }

            Console.WriteLine("Gamer score: {0}",gamerScore);
            Console.WriteLine("Computer score: {0}",computerScore);
            Console.WriteLine("****************************************");
            //Verify if someone has two Aces
            if (gamerScore == 22 || gamerScore == 21)
            {
                Console.WriteLine("Gamer WINS");
            }
            else if (computerScore == 22 || gamerScore == 21)
            {
                Console.WriteLine("Computer WINS");

            }
            else
            {
                Console.WriteLine("what do you want? Get [G] one more card or stop [S] receiving cards?");
                string gamerDecision = Console.ReadLine();
                if (gamerDecision == "G")
                {
                    gamer[2] = deck[4];
                    Console.WriteLine(gamer[2].weight + " " + gamer[2].suit);
                    string cardValue = (gamer[2].weight).ToString();
                    gamerScore = gamerScore + CardValue(cardValue);
                    Console.WriteLine("Gamer score: {0}", gamerScore);
                }

                int computerDecision = random.Next(2);
                if (computerScore <= 15)
                {
                    //
                }
            }  
            Console.ReadLine();
        }
    }
}
