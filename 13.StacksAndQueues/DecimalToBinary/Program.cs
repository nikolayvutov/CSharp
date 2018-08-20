using System;
using System.Collections.Generic;
using System.Linq;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            if (input == 0)
            {
                Console.WriteLine(input);
            }
            else 
            {
                while (input > 0)
                {
                    stack.Push(input % 2);
                    input /= 2;
                }

                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }    
            }
        }
    }
}
