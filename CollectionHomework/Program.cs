using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TestCollection();
            Console.Write("{");
            foreach (var item in t)
            {
                Console.Write(" {0}",item);
            }
            Console.WriteLine(" }");
        }
    }
}
