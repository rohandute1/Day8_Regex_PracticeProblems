using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class OccuranceCounter
    {
        public int CountOccurrences()
        {
            string pattern = "fox(es)?";
            string input = @"foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            int count = matches.Count;

            return count;
        }
    }
}
