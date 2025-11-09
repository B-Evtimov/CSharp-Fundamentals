using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(toRemove))
            {
                text = text.Replace(toRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}
