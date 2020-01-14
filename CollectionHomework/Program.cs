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
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
        }
    }
}
