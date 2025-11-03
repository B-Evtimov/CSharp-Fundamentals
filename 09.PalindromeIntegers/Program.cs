using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                Console.WriteLine(IsPalindrome(number));
            }
        }

        static string IsPalindrome(int num)
        {
            string numberAsString = num.ToString();
            string reversed = new string(numberAsString.Reverse().ToArray());

            return numberAsString == reversed ? "true" : "false";
        }
    }
}
