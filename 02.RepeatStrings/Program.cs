using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (var item in words)
            {
                int repeatCount = item.Length;
                for (int i = 0; i < repeatCount; i++)
                {
                    result.Append(item);
                }


            }
            Console.WriteLine(result.ToString());
        }
    }
}
