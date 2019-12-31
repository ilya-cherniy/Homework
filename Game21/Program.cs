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
            Random random = new Random();
            bool gamerStop = false;
            bool computerStop = false;
            int gamerWins = 0;
            int gamesNumbers = 0;
            bool continueGame = true;
            string userInput = "";

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
                        //Console.WriteLine(computer[i].weight + " " + computer[i].suit);
                        string cardValue = (computer[i].weight).ToString();
                        computerScore = computerScore + CardValue(cardValue);
                    }
                }
                indexInDeck += numberOfCards;
                return indexInDeck;
            }

            bool GamerDecision()
            {
                correctInput = false;
                string playerInput = "";
                Console.WriteLine("what do you want? Get [g] one more card or stop [s] receiving cards?");
                while (!correctInput)
                {
                    playerInput = Console.ReadLine();
                    if ((playerInput == "g") || (playerInput == "s"))
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Entered value is not correct. Please try again: ");
                    }
                }
                if (playerInput == "g")
                {
                    DealCards(1, "gamer");
                }
                else if (playerInput == "s")
                {
                    Console.WriteLine("Player decided to stop");
                    gamerStop = true;
                }
                return gamerStop; 
            }

            bool ComputerDecision()
            {
                if (computerScore <= 15)
                {
                    DealCards(1, "computer");
                }
                else
                {
                    int computerDecision = random.Next(2);
                    if (computerDecision == 0)
                    {
                        DealCards(1, "computer");
                    }
                    else
                    {
                        Console.WriteLine("Computer decided to stop");
                        computerStop = true;
                    }
                }
                return computerStop;
            }

            int PlayGame()
            {
                //erase all variables
                indexInDeck = 0;
                gamerScore = 0;
                computerScore = 0;
                indexCard = 0;
                gamerChoice = 0;
                correctInput = false;
                gamerStop = false;
                computerStop = false;

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
                //Print deck of cards
                //for (int i = 0; i < 36; i++)
                //{
                //    Console.WriteLine(deck[i].weight + " " + deck[i].suit);
                //}

                //shuffle a deck of cards
                Card[] tempCard = new Card[1];

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
                    Console.WriteLine("Computer first");
                    firstPlayer = "computer";
                    secondPlayer = "gamer";
                }
                //give 2 cards to each gamer
                Console.WriteLine("****************************************");
                DealCards(2, firstPlayer);
                DealCards(2, secondPlayer);
                Console.WriteLine("Gamer score: {0}", gamerScore);
                //Console.WriteLine("Computer score: {0}",computerScore);
                Console.WriteLine("****************************************");
                //Verify if someone has two Aces
                if (gamerScore == 22 || gamerScore == 21)
                {
                    Console.WriteLine("Gamer WINS with score: {0}", gamerScore);
                    gamerWins ++;
                }
                else if (computerScore == 22 || computerScore == 21)
                {
                    Console.WriteLine("Computer WINS with score: {0}", computerScore);
                }
                else
                {
                    do
                    {
                        if (firstPlayer == "gamer")
                        {
                            GamerDecision();
                            ComputerDecision();
                        }
                        else
                        {
                            ComputerDecision();
                            GamerDecision();
                        }
                        Console.WriteLine("Gamer score: {0}", gamerScore);
                        //Console.WriteLine("Computer score: {0}", computerScore);
                        if (((gamerStop == true) && (computerStop == true)) || ((gamerScore >= 21) || (computerScore >= 21)))
                        {
                            Console.WriteLine("****************************************");
                            Console.WriteLine("GAME IS OVER");
                            Console.WriteLine("****************************************");
                            if (gamerScore == 21)
                            {
                                Console.WriteLine("Gamer WINS with score: {0}", gamerScore);
                                gamerWins++;
                            }

                                if (computerScore == 21)
                                Console.WriteLine("Computer WINS with score: {0}", computerScore);
                            if ((gamerScore > 21) && (computerScore > 21))
                            {
                                if (computerScore > gamerScore)
                                {
                                    Console.WriteLine("Gamer WINS with score: {0}", gamerScore);
                                    gamerWins++;
                                }
                                else
                                    Console.WriteLine("Computer WINS with score: {0}", computerScore);
                            }
                            if ((gamerScore < 21) && (computerScore < 21))
                            {
                                if (computerScore > gamerScore)
                                    Console.WriteLine("Computer WINS with score: {0}", computerScore);
                                else
                                {
                                    Console.WriteLine("Gamer WINS with score: {0}", gamerScore);
                                    gamerWins++;
                                }
                            }
                            if ((gamerScore < 21) && (computerScore > 21))
                            {
                                Console.WriteLine("Gamer WINS with score: {0}", gamerScore);
                                gamerWins++;
                            }
                            if ((gamerScore > 21) && (computerScore < 21))
                            {
                                Console.WriteLine("Computer WINS with score: {0}", computerScore);
                            }
                            break;
                        }
                    } while (true);
                }
                return gamerWins;
            }
            while (continueGame)
            {
                PlayGame();
                Console.WriteLine("Do you want to start new game? Please enter [y]/[n]");
                bool correctRestart = false;
                while (!correctRestart)
                {
                    userInput = Console.ReadLine();
                    if ((userInput == "y") || (userInput == "n"))
                    {
                        correctRestart = true;
                    }
                    else
                    {
                        Console.WriteLine("Entered value is not correct. Please try again: ");
                    }
                }
             gamesNumbers++;
                if (userInput == "y")
                    continueGame = true;
             else
                    continueGame = false;
            }
         Console.WriteLine("You play {0} times", gamesNumbers);
         Console.WriteLine("Player wins {0} times", gamerWins);
         Console.WriteLine("Computer wins {0} times", gamesNumbers-gamerWins);
         Console.ReadLine();
        }
    }
}
