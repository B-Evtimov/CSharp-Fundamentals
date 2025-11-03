using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string stringToRepeat = Console.ReadLine();
                int count = int.Parse(Console.ReadLine());
                repeatString(stringToRepeat, count);
            }
            static void repeatString(string stringToRepeat, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(stringToRepeat);
                }
            }
        }
    }
}
