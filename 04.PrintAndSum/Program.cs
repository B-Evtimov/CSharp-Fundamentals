namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSum = int.Parse(Console.ReadLine()!);
            int secondSum = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = firstSum; i <= secondSum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}
