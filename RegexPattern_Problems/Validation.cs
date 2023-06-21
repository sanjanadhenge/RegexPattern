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
        public string String_Pattern = "(https://)([a-z]{1,}[.]){0,1}[a-z0-9A-Z]{1,}[.](com)[/]{1}([a-zA-Z/]{1,}){0,1}";
        public void Vadlidate_String_Pattern(string word)
        {
            int count = 0;
            Regex regex  = new Regex(String_Pattern);
            if(regex.IsMatch(word))
            {
                Console.WriteLine("Website is Valid");
            }
            else
            {
                Console.WriteLine("Website is Not Valid");
            }
            
           
        }
    }
}
