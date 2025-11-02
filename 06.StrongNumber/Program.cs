namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Factorial(int n)
            {
                int result = 1;
                for (int j = 1; j <= n; j++)
                {
                    result *= j;
                }
                return result;
            }

            string user = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < user.Length; i++)
            {
                int digit = int.Parse(user[i].ToString());
                sum += Factorial(digit);
            }

            if (sum == int.Parse(user))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
