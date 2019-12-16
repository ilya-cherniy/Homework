using System;

namespace RemoveCharacterFromString15
{
    class RemoveCharacterFromString15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text:");
            string testString = Console.ReadLine();
            Console.WriteLine("Please enter what character do you want to delete: ");
            string testCharacter = Console.ReadLine();
            testString = testString.Replace(testCharacter, "");
            Console.WriteLine("Modified string {0}", testString);
            Console.ReadLine();
        }
    }
}
