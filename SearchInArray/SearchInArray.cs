using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInArray
{
    class SearchInArray
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
            Console.WriteLine("Generated array:{0} ", String.Join(" ", array));
            Console.WriteLine("Please select what to you use - odd or even numbers:");
            string typeOfNumbers = Console.ReadLine();
            /*if ((minBorder % 2) == 0)
            {
                int maxElementOdd = minBorder;
            }
            else
            {
                int maxElementEven = minBorder;
                int maxElementOdd = minBorder+1;
            }*/
            switch (typeOfNumbers)
            {
                
                case "odd":
                    {
                        for (int i = 0; i < lengthOfArray; i++)
                        {
                            if ((array[i] % 2) == 1)
                            {
                                if (array[i] > maxElementOdd)
                                {
                                    maxElementOdd = array[i];
                                    int maxPointOdd = i;
                                }
                                if (array[i] < minElementOdd)
                                {
                                    minElementOdd = array[i];
                                    int minPointOdd = i;
                                }
                            }
                        }
                        Console.WriteLine("Max element in array is: {0}{1}{2}", maxElementOdd, " position ", maxPointOdd);
                        Console.WriteLine("Min element in array is: {0}{1}{2}", minElementOdd, " position ", minPointOdd);
                        int x = array[maxPointOdd];
                        array[maxPointOdd] = array[minPointOdd];
                        array[minPointOdd] = x;
                        Console.WriteLine("Modified array:{0} ", String.Join(" ", array));
                        break;
                    }
                case "even":
                    {
                        //code
                        //int maxElementEven = 0;
                        //int maxPointEven = 0;
                       // int minElementEven = 0;
                       // int minPointEven = 0;
                        for (int i = 0; i < lengthOfArray; i++)
                        {
                            if ((array[i] % 2) == 1)
                            {
                                if (array[i] > maxElementEven)
                                {
                                    maxElementEven = array[i];
                                    maxPointEven = i;
                                }
                                if (array[i] < minElementEven)
                                {
                                    minElementEven = array[i];
                                    minPointEven = i;
                                }
                            }
                        }
                        Console.WriteLine("Max element in array is: {0}{1}{2}", maxElementEven, " position ", maxPointEven);
                        Console.WriteLine("Min element in array is: {0}{1}{2}", minElementEven, " position ", minPointEven);
                        int x = array[maxPointEven];
                        array[maxPointEven] = array[minPointEven];
                        array[minPointEven] = x;
                        Console.WriteLine("Modified array:{0} ", String.Join(" ", array));
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
