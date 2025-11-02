namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetLastDigitAsWord(int.Parse(Console.ReadLine()));
        }

        static void GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(strings[lastDigit]);

        }
    }
}
