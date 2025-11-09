using System;
using System.Linq;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] banWords = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                      new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);

        }
    }
}
