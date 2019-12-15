using System;

namespace SummDiagonalsOfMatrix
{
    class SummDiagonalsOfMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length of array (N): ");
            int lengthOfArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter min border of random range: ");
            int minBorder = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max border of random range: ");
            int maxBorder = int.Parse(Console.ReadLine());
            int[,] array1 = new int[lengthOfArray,lengthOfArray];
            Random random = new Random();
            for (int i = 0; i < lengthOfArray; i++)
            {
                for (int j = 0; j < lengthOfArray; j++)
                {
                    array1[i,j] = random.Next(minBorder, maxBorder);
                    Console.Write("{0,3}  ", array1[i, j]);
                }
                Console.WriteLine();
            }
            int Sum = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {
                    int j = i;
                    Sum = Sum + array1[i, j];
            }
            for (int i = 0; i < lengthOfArray; i++)
            {
                    int j = lengthOfArray - 1 - i;
                    Sum = Sum + array1[i, j];
            }
            Console.WriteLine("Sum is {0}",Sum);
            Console.ReadLine();
        }
    }
}
