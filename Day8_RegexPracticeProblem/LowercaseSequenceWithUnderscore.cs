using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegexPracticeProblem
{
    public class LowercaseSequenceWithUnderscore
    {
        public static void ValidateSequenceOfLowercase()
        {
            
            string[] inputs = { "abc_nv", "bvh_dVsn_cn", "nkn_jd", "_dcn" };

            string pattern = "^[a-z]+_[a-z]+$";

            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is Valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
                    
            }

        }
    }
}
