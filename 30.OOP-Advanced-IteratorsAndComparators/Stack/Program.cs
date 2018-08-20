using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                switch (tokens[0])
                {
                    case "Pop":
                        stack.Pop();
                        break;
                    case "Push":
                        stack.Push(tokens.Skip(1));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine(stack.ToString());
        Console.WriteLine(stack.ToString());
    }
}
