using System;
using System.Collections.Generic;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharactersInRange(firstChar, secondChar);
        }
        static void CharactersInRange(char firstChar, char secondChar)
        {
            int start = Math.Min(firstChar, secondChar) + 1;
            int end = Math.Max(firstChar, secondChar);
            List<char> charactersInRange = new List<char>();
            for (int i = start; i < end; i++)
            {
                charactersInRange.Add((char)i);
            }
            Console.WriteLine(string.Join(" ", charactersInRange));
        }
    }
}
