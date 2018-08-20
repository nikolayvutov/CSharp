using System;
using System.Collections.Generic;
using System.IO;
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
            var text = File.ReadAllText(@"../../../resources/8. Average Grades/text.txt").Skip(1).ToArray();

            File.Delete(@"../../../resources/8. Average Grades/output.txt");
            int number = File.ReadLines(@"../../../resources/8. Average Grades/text.txt").Select(int.Parse).First();


            //var input = text.Split(' ').ToArray();
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                string name = text[0].ToString();
                double[] grades = text.Skip(1).Select(double.Parse).ToArray();

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
                var output = $"{s.Name} -> {s.Average:F2}";
                File.AppendAllText(@"../../../resources/8. Average Grades/output.txt", output);
            }
        }
    }

}