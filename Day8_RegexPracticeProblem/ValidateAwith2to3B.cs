using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class ValidateAwith2to3B
    {
        public static void StringMatcher()
        {

            Console.WriteLine("Please select from below options :-");
            Console.WriteLine("1.Inbuilt input with array\n2.Provide user input");
            int select = Convert.ToInt32(Console.ReadLine());
            switch(select)
            {
                case 1:
                    string[] inputs = { "aaa", "aabbb", "abbb", "bbb", "a", "abb", "abbbbb" };
                    string pattern = "^a[b]{2,3}$";

                    foreach(string input in inputs)
                    {
                        if (Regex.IsMatch(input, pattern))
                        {
                            Console.WriteLine("{0} is a valid input.",input);
                        }
                        else
                        {
                            Console.WriteLine("{0} is a invalid input.",input);
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Please enter string which you want to check :-");
                    string str = Console.ReadLine();
                    string patern = "^a[b]{2,3}$";
                    if(Regex.IsMatch(str, patern))
                    {
                        Console.WriteLine("{0} is a valid input.", str);
                    }
                    else
                    {
                        Console.WriteLine("{0} is a invalid input.", str);
                    }
                    break;
            }
        }
    }
}
