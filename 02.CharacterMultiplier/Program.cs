using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            string[] strings = stringInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string first = strings[0];
            string second = strings[1];
            int result = CharacterMultiplier(first, second);
            Console.WriteLine(result);

        }

        static int CharacterMultiplier(string first, string second)
        {
            int sum = 0;
            int minLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }
            for (int i = minLength; i < maxLength; i++)
            {
                if (first.Length > second.Length)
                {
                    sum += first[i];
                }
                else
                {
                    sum += second[i];
                }
            }
            return sum;
        }
    }
}
