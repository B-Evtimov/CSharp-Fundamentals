using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> peopleById = new Dictionary<string, Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                string name = parts[0];
                string id = parts[1];
                int age = int.Parse(parts[2]);

                peopleById[id] = new Person(name, id, age);
            }

            var sortedPeople = peopleById.Values.OrderBy(p => p.Age);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
