using System;

namespace MathPow
{
    class Pow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the pow: ");
            int Pow = int.Parse(Console.ReadLine());
            int Result = 1;
            for (int i = 0; i < Pow; i++)
                Result = Result * Number;
            Console.WriteLine(Number + "^" + Pow + " = " + Result);

        }
    }
}
