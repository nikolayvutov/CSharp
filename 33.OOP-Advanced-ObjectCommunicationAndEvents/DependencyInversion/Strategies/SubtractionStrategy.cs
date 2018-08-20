using DependencyInversion.Contracts;

namespace DependencyInversion.Strategies
{
    public class SubtractionStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
