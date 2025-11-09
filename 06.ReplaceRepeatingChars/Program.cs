using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || input[i] != input[i - 1])
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);

        }
    }
}
