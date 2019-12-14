using System;

namespace Homework
{
    class DigitMultiplication
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Number = random.Next(1000, 9999);
            int draftNumber = Number;
            int Multiply = 1;
            while (Number != 0)
            {
                Multiply = Multiply * (Number % 10);
                Number = Number / 10;
            }
            Console.WriteLine("Digits multiplication of " + draftNumber + " is " + Multiply);
            Console.ReadLine();
        }
    }
}
