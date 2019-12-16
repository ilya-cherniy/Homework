using System;

namespace SearchSubStringInString16
{
    class SearchSubStringInString16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter test string:");
            string testString = Console.ReadLine();
            Console.WriteLine("Please enter sub-string: ");
            string subString = Console.ReadLine();
            bool result = testString.Contains(subString);
            if (result)
                Console.WriteLine("Test string contains sub-string");
            else
                Console.WriteLine("Sub-sting doesnt find");
            Console.ReadLine();
        }
    }
}
