using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine();

        
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        
        MatchCollection matches = Regex.Matches(input, pattern);

        
        foreach (Match match in matches)
        {
            Console.Write($"{match.Value} ");
        }
    }
}
