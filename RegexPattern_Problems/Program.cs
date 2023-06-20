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
            string word = "<p>The<code>Regex</code>is a compiled representaion of a regular expression.</p>";
            validation.Vadlidate_String_Pattern(word);
        }
    }
}
