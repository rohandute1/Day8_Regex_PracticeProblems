using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regex practice problems.");
            Console.WriteLine("Please select program form list:");
            Console.WriteLine("1.Program that matches a string that has an ‘a’ followed by two to three 'b'.\n" +
                "2.Program to find sequences of lowercase letters joined by an underscore.\n" +
                "3.Program to fetch all HTML tags from a given string.");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    ValidateAwith2to3B.StringMatcher();
                    break;

                case 2:
                    LowercaseSequenceWithUnderscore.ValidateSequenceOfLowercase();
                    break;

                case 3:
                    HtmlTagsFetcher.FetchHtmlTags();
                    break;
            }

            Console.ReadLine();
        }
    }
}
