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
        public string String_Pattern = "^[a]{1}[b]{2,3}$";
        public void Vadlidate_String_Pattern(string word)
        {
            Regex regex  = new Regex(String_Pattern);
            if(regex.IsMatch(word))
            {
                Console.WriteLine("String is Valid");
            }
            else { Console.WriteLine("String is Not Valid"); }
        }
    }
}
