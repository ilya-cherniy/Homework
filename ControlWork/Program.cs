using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class ControlWork
    {
        static void Main(string[] args)
        {
            string text = "Kharkiv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352;Istanbul=10000000,810";
            char[] delimeterChars = { '=', ',', ';' };
            string[] words = text.Split(delimeterChars);
            int wordsLength = words.Length;
            int maxPeople = int.Parse(words[1]);
            int maxPeopleIndex = 1;
            for (int i = 4; i < wordsLength;)
            {
                if (int.Parse(words[i]) > maxPeople)
                {
                    maxPeople = int.Parse(words[i]);
                    maxPeopleIndex = i;
                }
                i = i + 3;
            }
            int maxLengthCityName = words[0].Length;
            int maxLengthCityNameIndex = 0;
            for (int i = 3; i < wordsLength;)
            {
                if (words[i].Length > maxLengthCityName)
                {
                    maxLengthCityName = words[i].Length;
                    maxLengthCityNameIndex = i;
                }
                i = i + 3;
            }
            Console.WriteLine("Most populated: {0}{1}{2}{3}", words[maxPeopleIndex - 1], "(", maxPeople, " people)");
            Console.WriteLine("Longest name: {0}{1}{2}{3}", words[maxLengthCityNameIndex], "(", maxLengthCityName, " characters)");
            Console.WriteLine("Density:");
            for (int i = 0; i < wordsLength;)
            {
                Console.WriteLine("{0}{1}{2}", words[i], " - ", float.Parse(words[i+1])/ float.Parse(words[i+2]));
                i = i + 3;
            }
            Console.ReadLine();
            }
    }
}
