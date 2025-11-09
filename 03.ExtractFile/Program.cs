using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            //string fileName = filePath[(filePath.LastIndexOf('\\') + 1)..];

            string fileName = filePath[(filePath.LastIndexOf('\\') + 1)..filePath.LastIndexOf('.')];
            string extension = filePath[(filePath.LastIndexOf('.') + 1)..];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
