using System;

namespace RemoveSubstringFromString17
{
    class RemoveSubstringFromString17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter test string:");
            string testString = Console.ReadLine();
            Console.WriteLine("Please enter sub-string: ");
            string subString = Console.ReadLine();
            testString = testString.Replace(subString, "");
            Console.WriteLine("Modified string {0}", testString);
            Console.ReadLine();
        }
    }
}
