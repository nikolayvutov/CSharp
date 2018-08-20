using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{
    public class Student
    {
        public string Name { get; set; }
        public List<DateTime> Date { get; set; }
        public List<string> Comments { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            SortedDictionary<string, Student> students = new 
                SortedDictionary<string, Student>();

            while (input != "end of dates")
            {
                
                var line = input.Split(new char[] { ' ' },
                                   StringSplitOptions
                                   .RemoveEmptyEntries);

                List<DateTime> dates = new List<DateTime>();


                if (line.Length > 1)
                {
                    var dateString = line[1].Split(',').ToList();


                    foreach (var item in dateString)
                    {
                        dates.Add(DateTime.ParseExact(item, "dd/MM/yyyy",
                                                      CultureInfo
                                                      .InvariantCulture));
                    }
                }
                Student student = new Student();


                if (!students.ContainsKey(line[0]))
                {
                    string name = line[0];
                    students.Add(name, student);
                    students[name].Date = dates;
                }
                else
                {
                    if (students[line[0]].Date != null)
                    {
                        students[line[0]].Date.AddRange(dates);
                    }
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of comments")
            {
                var arguments = secondInput.Split('-');

                var commentName = arguments[0];
                var commentNew = arguments[1];
                Student student = new Student();

                List<string> comments = new List<string>();
                comments.Add(commentNew);

                if (students.ContainsKey(commentName))
                {
                    if (students[commentName].Comments != null)
                    {
                        students[commentName].Comments.AddRange(comments);
                    }
                    else
                    {
                        students[commentName].Comments = comments;
                    }
                }
                secondInput = Console.ReadLine();
            }

            foreach (var s in students)
            {
                string name = s.Key;
                Console.WriteLine(name);
                Console.WriteLine("Comments:");

                if (s.Value.Comments != null)
                {
                    foreach (var comment in s.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }

                }

                Console.WriteLine("Dates attended:");
                if (s.Value.Date != null)
                {
                    foreach (var date in s.Value.Date.OrderBy(x => x))
                    {
                        Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                    }
                }
            }
        }
    }
}