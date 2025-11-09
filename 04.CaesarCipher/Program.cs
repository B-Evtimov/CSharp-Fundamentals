using System;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            foreach (char character in input)
            {
                char encryptedChar = (char)(character + 3);
                output += encryptedChar;
            }
            Console.WriteLine(output);
        }
    }
}
