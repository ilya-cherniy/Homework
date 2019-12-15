using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingArrays
{
    class ComparingArrays
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter length of array (N): ");
            int lengthOfArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter min border of random range: ");
            int minBorder = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max border of random range: ");
            int maxBorder = int.Parse(Console.ReadLine());
            int[] array1 = new int[lengthOfArray];
            int[] array2 = new int[lengthOfArray];
            Random random = new Random();
            for (int i = 0; i < lengthOfArray; i++)
            {
                array1[i] = random.Next(minBorder, maxBorder);
                array2[i] = random.Next(minBorder, maxBorder);
            }*/
            int[] array1 = new [] { 1, 7, 5, 7, 8, 5 };
            int[] array2 = new [] { 1, 7, 5, 7, 8, 5 };
            int lengthOfArray = 6;
                Console.WriteLine("Generated array:{0} ", String.Join(" ", array1));
                Console.WriteLine("Generated array:{0} ", String.Join(" ", array2));
            bool identical = true;
            for (int i = 0; i < lengthOfArray; i++)
            {
                if (array1[i] != array2[i])
                    identical = false;
            }
            if (identical)
            {
                Console.WriteLine("These arrays are identical {0}", identical);
            }
            else
                Console.WriteLine("These arrays are different {0}", identical);
            Console.ReadLine();
        }
    }
}
