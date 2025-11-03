using System;
using System.Linq;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] numbers = Console.ReadLine()
                .Split()
                .ToArray();

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomIndex = random.Next(0, numbers.Length);
                string temp = numbers[i];
                numbers[i] = numbers[randomIndex];
                numbers[randomIndex] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, numbers));


        }
    }
}
