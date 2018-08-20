using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibraryModification
{
    class MainClass
    {
        public class Student
        {
            public string Name
            {
                get;
                set;
            }
            public double[] Grades
            {
                get;
                set;
            }
            public double Average
            {
                get { return Grades.Average(); }
            }
        }


        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            while ((n--) > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double[] grades = input.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student();
                student.Name = name;
                student.Grades = grades;
                students.Add(student);

            }
            students = students
                .Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name).ThenByDescending(s => s.Average).ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} -> {s.Average:F2}");
            }
        }
    }

}
