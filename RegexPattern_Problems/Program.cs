using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern_Problems
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Validation validation = new Validation();
            string word = "foxes are omnivorous mammals belonging to sevaral genera of the family Canidae fox.";
            validation.Vadlidate_String_Pattern(word);
        }
    }
}
