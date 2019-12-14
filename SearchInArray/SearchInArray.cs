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
            Console.WriteLine("Result array:{0} ", String.Join(" ", array));

            //search min/max value
            //for ....
        }
    }
}
