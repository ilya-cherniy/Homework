using System;

namespace MaxMinMedium
{
    class MaxMinMedium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 digits (a,b,c): ");
           
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());
            int maxValue = a;
            int minValue = b;
            int mediumValue = c;
            if ((a < b) && (b > c) && (a < c))
            {
                minValue = a;
                maxValue = b;
            }
            if ((a < b) && (b > c) && (a > c))
            {
                minValue = c;
                maxValue = b;
                mediumValue = a;
            }
            if ((a < b) && (b < c))
            {
                minValue = a;
                maxValue = c;
                mediumValue = b;
            }
            if ((a > b) && (b > c))
            {
                minValue = c;
                mediumValue = b;
            }
            Console.WriteLine("What digit do you want to find - max, min, medium. Please enter your choice:");
            string action = Console.ReadLine();
            switch (action)
            {
                case "max":
                    Console.WriteLine("Maximum value is: " + maxValue);
                    break;
                case "min":
                    Console.WriteLine("Minimum value is: " + minValue);
                    break;
                case "medium":
                    Console.WriteLine("Medium value is: " + mediumValue);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }        
            Console.ReadLine();
        }
    }
}
