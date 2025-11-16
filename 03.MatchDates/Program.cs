using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(?<day>\d{2})(?<separator>[-./])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b");

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            
            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
