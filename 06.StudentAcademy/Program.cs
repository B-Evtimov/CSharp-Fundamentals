using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            int n = int.Parse(Console.ReadLine());
            string name;
            decimal grade;
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                grade = decimal.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student(name));
                }
                students[name].Grades.Add(grade);
            }
            IEnumerable<KeyValuePair<string, Student>> filteredStudents = students.Where(g => g.Value.Grades.Average() >= 4.50m);

            foreach (KeyValuePair<string, Student> pair in filteredStudents)
            {
                Console.WriteLine($"{pair.Value}");
            }
        }
    }
    public class Student
    {
        public Student(string name)
        {
            Grades = new List<decimal>();
            Name = name;
        }

        public string Name { get; set; }

        public List<decimal> Grades { get; set; }

        public override string ToString()
        {

            return $"{Name} -> {Grades.Average():F2}";
        }
    }
}
