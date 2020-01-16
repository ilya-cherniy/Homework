using System;

namespace CollectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TestCollection();
            Console.WriteLine("This is the list of simple digits from random int array [10]:");
            foreach (var item in t)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
