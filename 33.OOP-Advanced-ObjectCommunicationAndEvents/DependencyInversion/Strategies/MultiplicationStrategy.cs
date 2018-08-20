using System;
using DependencyInversion.Contracts;

namespace DependencyInversion.Strategies
{
    public class MultiplicationStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
