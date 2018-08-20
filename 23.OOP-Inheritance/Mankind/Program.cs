using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var studentInput = Console.ReadLine().Split();
            var workerInput = Console.ReadLine().Split();

            Student student = new Student(studentInput[0],
                                          studentInput[1],
                                          studentInput[2]);

            Worker worker = new Worker(workerInput[0],
                                       workerInput[1],
                                       decimal.Parse(workerInput[2]),
                                       double.Parse(workerInput[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine(worker.ToString());

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

