using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {

                switch (command.Split()[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command.Split()[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(command.Split()[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(command.Split()[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command.Split()[1]);
                        int indexToInsert = int.Parse(command.Split()[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
                command = Console.ReadLine();


            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
