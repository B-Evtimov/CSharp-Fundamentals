using System;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string nums = default;
            string letters = default;
            string symbols = default;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    nums += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    symbols += ch;

                }

            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);


        }
    }
}
