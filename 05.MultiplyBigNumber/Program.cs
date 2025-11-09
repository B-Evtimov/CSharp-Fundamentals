using System;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }
            string result = string.Empty;
            int carry = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = bigNumber[i] - '0';
                int product = digit * multiplier + carry;
                carry = product / 10;
                result = (product % 10).ToString() + result;
            }
            if (carry > 0)
            {
                result = carry.ToString() + result;
            }
            Console.WriteLine(result);


        }
    }
}
