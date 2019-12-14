using System;

namespace DigitsName
{
    public enum NameOfDigits
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine
    }
    class DigitsName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            string numberString = Console.ReadLine();
            int numberOfDigits = numberString.Length;
            int Number = Convert.ToInt32(numberString);
            string[] arrayLetters = new string[numberOfDigits];
            int arrayElement = numberOfDigits-1;
            while (Number != 0)
            {
                arrayLetters[arrayElement] = Enum.GetName(typeof(NameOfDigits), (Number % 10));
                Number = Number / 10;
                arrayElement = arrayElement - 1;
            }
            Console.WriteLine("Result array:{0} ", String.Join(", ", arrayLetters));
            Console.ReadLine();
        }
    }
}

