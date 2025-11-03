namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];
            while (numbers.Contains(bombNumber))
            {
                int index = numbers.IndexOf(bombNumber);
                int startIndex = Math.Max(0, index - bombPower);
                int endIndex = Math.Min(numbers.Count - 1, index + bombPower);
                int count = endIndex - startIndex + 1;
                numbers.RemoveRange(startIndex, count);
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);




        }
    }
}
