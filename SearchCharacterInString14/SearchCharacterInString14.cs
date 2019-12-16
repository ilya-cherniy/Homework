using System;

namespace SearchCharacterInString14
{
    class SearchCharacterInString14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text:");
            string testString = Console.ReadLine();
            Console.WriteLine("Please enter what do you find (character): ");
            char testCharacter = char.Parse(Console.ReadLine());
            int stringLength = testString.Length;
            int searchResult = 0;
            for (int i = 0; i < stringLength; i++)
            {
                if (testString[i] == testCharacter)
                    searchResult ++;
            }
            if (searchResult == 0)
                Console.WriteLine("Character {0}{1}", testCharacter," doesn't find");
            else
                Console.WriteLine("Character {0}{1}{2}{3}", testCharacter, "find ", searchResult, "times");
            Console.ReadLine();
        }
    }
}
