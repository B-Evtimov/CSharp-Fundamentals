using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetAndPrintVowelsCount(word);
        }
        static void GetAndPrintVowelsCount(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            foreach (char letter in word)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
