using DependencyInversion.Contracts;

namespace DependencyInversion.Strategies
{
    public class AdditionStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
