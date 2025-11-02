namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());


            double[] numbers = { num1, num2, num3 };

            var sorted = numbers.OrderByDescending(n => n);
            foreach (var number in sorted)
            {
                Console.WriteLine(number);
            }
        }
    }

}
