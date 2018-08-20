using System;
using DependencyInversion.Contracts;
using DependencyInversion.Strategies;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calculator = 
                new PrimitiveCalculator(new AdditionStrategy());

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "mode")
                {
                    char operand = tokens[1][0];

                    ICalculationStrategy strategy = null;

                    switch (@operand)
                    {
                        case '+':
                            strategy = new AdditionStrategy();
                            break;
                        case '-':
                            strategy = new SubtractionStrategy();
                            break;
                        case '*':
                            strategy = new MultiplicationStrategy();
                            break;
                        case '/':
                            strategy = new DivisionStrategy();
                            break;
                    }

                    if (strategy == null)
                    {
                        throw new ArgumentException("Invalid mode!");
                    }

                    calculator.ChangeStrategy(strategy);
                }
                else
                {
                    int firstOperand = int.Parse(tokens[0]);
                    int secondOperand = int.Parse(tokens[1]);

                    int result = calculator.PerformCalculation(firstOperand, secondOperand);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
