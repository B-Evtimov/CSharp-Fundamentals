using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new Course(courseName);
                }
                courses[courseName].StudentsNames.Add(studentName);

            }
            foreach (var course in courses)
                Console.WriteLine(course.Value.ToString());


        }
    }

    public class Course
    {
        public string Name { get; set; }

        public List<string> StudentsNames { get; set; }
        public Course(string name)
        {
            StudentsNames = new List<string>();
            Name = name;

        }
        public override string ToString()
        {
            string result = $"{Name}: {StudentsNames.Count}\n";

            for (int i = 0; i < StudentsNames.Count; i++)
            {
                result += $"-- {StudentsNames[i]}\n";
            }

            return result.Trim();
        }
    }
}
