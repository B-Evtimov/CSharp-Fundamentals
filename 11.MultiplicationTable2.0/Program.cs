namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                int product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    int product = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {product}");
                }
            }

        }
    }
}
