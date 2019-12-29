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
            //variables for program needs
            int indexInDeck = 0;
            int gamerScore = 0;
            int computerScore = 0;
            Card[] deck = new Card[36];
            Card[] gamer = new Card[18];
            Card[] computer = new Card[18];
            int indexCard;
            int gamerChoice = 0;
            bool correctInput = false;
            string firstPlayer;
            string secondPlayer;


            //CardValue method will be used to calculate scores
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

            int DealCards(int numberOfCards, string playerName)
            {
                for (int i = indexInDeck; i < (numberOfCards+indexInDeck); i++)
                {
                    if (playerName == "gamer")
                    {
                        gamer[i] = deck[i];
                        Console.WriteLine(gamer[i].weight + " " + gamer[i].suit);
                        string cardValue = (gamer[i].weight).ToString();
                        gamerScore = gamerScore + CardValue(cardValue);
                    }
                    else if (playerName == "computer")
                    {
                        computer[i] = deck[i];
                        Console.WriteLine(computer[i].weight + " " + computer[i].suit);
                        string cardValue = (computer[i].weight).ToString();
                        computerScore = computerScore + CardValue(cardValue);
                    }
                }
                indexInDeck += numberOfCards;
                return indexInDeck;
            }

            int GamerDecision()
            {
                correctInput = false;
                string playerInput = "";
                Console.WriteLine("what do you want? Get [G] one more card or stop [S] receiving cards?");
                while (!correctInput)
                {
                    playerInput = Console.ReadLine();
                    if ((playerInput == "G") || (playerInput == "S"))
                    {
                        Console.WriteLine(playerInput);
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Entered value is not correct. Please try again: ");
                    }
                }

                if (playerInput == "G")
                {
                    DealCards(1, firstPlayer);
                }
                else if (playerInput == "S")
                {
                    Console.WriteLine("Player decided to stay");
                }

                return gamerScore;
            }

            //generate an ordered deck of cards
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

            //shuffle a deck of cards
            Card[] tempCard = new Card[1];
            Random random = new Random();
            for (int j = 35; j > 0; j--)
            {
                indexCard = random.Next(j + 1);
                tempCard[0] = deck[j];
                deck[j] = deck[indexCard];
                deck[indexCard] = tempCard[0];
            }
            //print shuffled deck
            //for (int i = 0; i < 36; i++)
            //{
            //    Console.WriteLine(deck[i].weight + " " + deck[i].suit);

            //}
            Console.WriteLine("Please select [0] or [1] to decide who will start firts - Gamer or Computer");
            while (!correctInput)
            {
                string gamerInput = Console.ReadLine();
                if (Int32.TryParse(gamerInput, out gamerChoice) && (gamerChoice == 0 || gamerChoice == 1))
                {
                    Console.WriteLine(gamerChoice);
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Entered value is not correct. Please try again: ");
                }
            }
            int randomCoin = random.Next(2);
            Console.WriteLine("Random coin: {0}", randomCoin);
            if (gamerChoice == randomCoin)
            {
                Console.WriteLine("Gamer first");
                firstPlayer = "gamer";
                secondPlayer = "computer";
            }
            else
            {
                Console.WriteLine("PC first");
                firstPlayer = "computer";
                secondPlayer = "gamer";
            }

            //give 2 cards to each gamer
            Console.WriteLine("****************************************");
            DealCards(2, firstPlayer);
            DealCards(2, secondPlayer);

            Console.WriteLine("Gamer score: {0}",gamerScore);
            Console.WriteLine("Computer score: {0}",computerScore);
            Console.WriteLine("****************************************");
            //Verify if someone has two Aces
            if (gamerScore == 22 || gamerScore == 21)
            {
                Console.WriteLine("Gamer WINS");
            }
            else if (computerScore == 22 || computerScore == 21)
            {
                Console.WriteLine("Computer WINS");

            }
            else
            {
                
                if (firstPlayer == "gamer")
                {
                    GamerDecision();
                    Console.WriteLine("Gamer score: {0}", gamerScore);
                }
                else if (firstPlayer == "computer")
                {
                    //TBD
                    int computerDecision = random.Next(2);
                    if (computerScore <= 15)
                    {
                        //
                    }
                }


            }  
            Console.ReadLine();
        }
    }
}
