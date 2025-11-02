namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double coffeePrice = capsulePrice * capsulesCount * days;
                total += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
