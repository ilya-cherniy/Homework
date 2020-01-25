using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Emails.txt";
            //string pattern = @"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*){1,64}+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";
            const string pattern =
                @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
                @"(([\+\-_\.][0-9a-zA-Z]+)*){1,64}" + // No continuous or ending +-_. chars in email
                @")+" +
                @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

            string[] emails = File.ReadAllLines(source);
            Console.WriteLine(emails.Length + " emails have been verified");
            Console.WriteLine("------------------------------------------");
            foreach (string email in emails)
            {
                if (Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine("CORRECT " + email);
                }
                else
                {
                    ConsoleHelper.WriteColored("INCORRECT", ConsoleColor.Red);
                    Console.WriteLine(" " + email);
                }
            }
        }
    }
}
