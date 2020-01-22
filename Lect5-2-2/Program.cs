using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lect5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("");

            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.MaxCapacity);
            //Console.WriteLine(sb.Length);

            //sb.Append("Hello world");
            //sb.Insert(0, "123");
            //sb.Insert(3, "   ");

            //Console.WriteLine(sb);

            //string input = "(067) 893 4565";
            //string pattern = @"^((8|\+38)[\- ]?)?(\(?\d{3,4}\)?[\- ]?)?[\d\- ]{7,10}$";

            //if (Regex.IsMatch(input, pattern))
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("Not OK");
            //}

            var text = "Hello world. My name is Vova. London is the capital of Great Britain!!! How are you? I'm ok. I'm ok too";

            //var t = Regex.Split(text, @"\.");
            //foreach (var item in t)
            //{
            //    Console.WriteLine(item);
            //}

            //var k = Regex.Matches(text, @"o.|[A-Z]");
            //foreach (Match item in k)
            //{
            //    Console.WriteLine(item.Value);
            //}

            var k = Regex.Replace(text, @"o.|[A-Z]","T");
            Console.WriteLine(k);
            
        }
    }
}
