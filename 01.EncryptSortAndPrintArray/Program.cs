using System;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] encryptedValues = new int[count];

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;

                foreach (char letter in name)
                {
                    if ("aeiouAEIOU".Contains(letter))
                    {
                        sum += (int)letter * name.Length;
                    }
                    else
                    {
                        sum += (int)letter / name.Length;
                    }
                }

                encryptedValues[i] = sum;
            }


            Array.Sort(encryptedValues);
            foreach (int value in encryptedValues)
            {
                Console.WriteLine(value);
            }

        }
    }
}
