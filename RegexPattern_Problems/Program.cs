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
            Console.WriteLine("Enter File Name");
            string word = Console.ReadLine();
            validation.Vadlidate_String_Pattern(word);
        }
    }
}
