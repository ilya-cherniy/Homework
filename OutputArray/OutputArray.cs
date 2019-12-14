using System;

namespace OutputArray
{
    class OutputArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length of array (N): ");
            int lengthOfArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter min border of random range: ");
            int minBorder = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max border of random range: ");
            int maxBorder = int.Parse(Console.ReadLine());
            int[] array = new int[lengthOfArray];
            Random random = new Random();
            for (int i = 0; i < lengthOfArray; i++)
                array[i] = random.Next(minBorder, maxBorder);

            Console.WriteLine("How we should output resulted array (horizontally -h, vertically -v? Please enter your choice:");
            string hv = Console.ReadLine();
            switch (hv)
            {
                case "h":
                    Console.WriteLine("Result array:{0} ", String.Join(", ", array));
                    break;
                case "v":
                    {
                        Console.WriteLine("Result array:");
                        for (int i = 0; i < lengthOfArray; i++)
                        {
                            Console.WriteLine("{0}", array[i]);
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}
