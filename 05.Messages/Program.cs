namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                char digit = input[0];

                if (digit == '0')
                {
                    message += " ";
                    continue;
                }

                int lettersCount = 3;

                if (digit == '7' || digit == '9')
                {
                    lettersCount = 4;
                }

                int offset = (digit - '2') * 3;

                if (digit == '8' || digit == '9')
                {
                    offset += 1;
                }

                int letterIndex = offset + ((length - 1) % lettersCount);
                char letter = (char)('a' + letterIndex);

                message += letter;
            }

            Console.WriteLine(message);

        }
    }
}
