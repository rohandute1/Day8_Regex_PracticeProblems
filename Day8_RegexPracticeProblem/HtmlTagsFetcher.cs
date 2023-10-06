using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class HtmlTagsFetcher
    {
        public static void FetchHtmlTags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p><>";
            string pattern = "<[^>]*>";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
