using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split();
                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                string hometown = parts[3];

                Student existingStudent = students
                    .FirstOrDefault(s => s.FirstName == firstName
                    && s.LastName == lastName);

                if (existingStudent != null)
                {

                    existingStudent.Age = age;
                    existingStudent.Hometown = hometown;
                }
                else
                {

                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    });
                }
            }

            string city = Console.ReadLine();

            foreach (Student student in students.Where(s => s.Hometown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
