using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=^|\s)\+359([ -])2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matches.Cast<Match>().Select(m => m.Value)));
        }
    }
}
