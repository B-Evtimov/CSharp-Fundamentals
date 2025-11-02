namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedDigits = new string(word.Reverse().ToArray());
            Console.WriteLine(reversedDigits);
        }
    }
}
