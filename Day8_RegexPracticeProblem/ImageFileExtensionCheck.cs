using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class ImageFileExtensionCheck
    {
        public static void ExtensionChecker()
        {
            string[] inputs = {"a.jpd", "b.pdf", "c.png", "d.txt", "e.jpeg", "f.gif", "g.jpg"};

            string pattern = "^.+\\.(jpg|png|jpeg|gif)$";

            foreach (string input in inputs) 
            { 
                if(Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is a valid image file.",input);
                }
                else
                {
                    Console.WriteLine("{0} is a invalid image file.",input);
                }
            }
        }
    }
}
