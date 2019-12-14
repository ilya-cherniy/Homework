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

            int maxElement = array[0];
            int maxPoint = 0;
            int minElement = array[1];
            int minPoint = 1;

            for (int i = 0; i < lengthOfArray; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxPoint = i;
                }
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    minPoint = i;
                }
                if (array[i] == maxPoint)
                {
                    array[i] = minElement;
                }
                if (array[i] == minPoint)
                {
                    array[i] = maxElement;
                }
            }


            /*foreach (var item in array)
            {
                if (item > maxElement)
                    maxElement = item;
                if (item < minElement)
                    minElement = item;
            }
            */
            Console.WriteLine("Max element in array is: {0}", maxElement);
            Console.WriteLine("Max element has position: {0}", maxPoint);

            Console.WriteLine("Min element in array is: {0}", minElement);
            Console.WriteLine("Min element has position: {0}", minPoint);

            Console.WriteLine("Modified array:{0} ", String.Join(" ", array));
            Console.ReadLine();
        }
    }
}
