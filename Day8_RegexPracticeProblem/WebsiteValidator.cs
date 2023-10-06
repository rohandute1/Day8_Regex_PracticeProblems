using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class WebsiteValidator
    {
        public static void ValidateWebsite()
        {
            string[] websites = { "https://www.example.com", "http://sub.example.co.uk", "ftp://ftp.example.net", "www.invalidaddress", "https://", "example.com" };

            string pattern = @"^(http|https|ftp):\/\/[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}(\/\S*)?$";

            foreach (string website in websites) 
            {
                if (Regex.IsMatch(website, pattern))
                {
                    Console.WriteLine("{0} is a valid website.",website);
                }
                else
                {
                    Console.WriteLine("{0} is a invalid website.",website);
                }
            }
        }
        
    }
}
