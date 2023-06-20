using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern_Problems
{
    internal class Validation
    {
        public string String_Pattern = "[a-z][_]";
        public void Vadlidate_String_Pattern(string word)
        {
            int count = 0;
            Regex regex  = new Regex(String_Pattern);
           var result = regex.Matches(word);
            Console.WriteLine(result.Count);
            
           
        }
    }
}
