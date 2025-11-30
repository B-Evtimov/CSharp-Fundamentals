using System;
using System.Text.RegularExpressions;
/*4
$Request$: [73]|[115]|[105]|
%Taggy$: [73]|[73]|[73]|
%Taggy%: [118]|[97]|[108]|
$Request$: [73]|[115]|[105]|[32]|[75]|

*/
namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            string regexPattern = @"^(?<tag>(\$[A-Z][a-z]{2,}\$|%[A-Z][a-z]{2,}%)): \[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";

            for (int i = 0; i < inputCount; i++)
            {
                string message = Console.ReadLine();

                var match = Regex.Match(message, regexPattern);

                if (match.Success)
                {


                    string tag = match.Groups["tag"].Value;
                    int num1 = int.Parse(match.Groups[2].Value);
                    int num2 = int.Parse(match.Groups[3].Value);
                    int num3 = int.Parse(match.Groups[4].Value);

                    string decryptedMessage = $"{(char)num1}{(char)num2}{(char)num3}";

                    Console.WriteLine($"{tag.Substring(1, tag.Length - 2)}: {decryptedMessage}");
                }
                else

                {


                    Console.WriteLine("Valid message not found!");


                }
            }



        }

    }


}
