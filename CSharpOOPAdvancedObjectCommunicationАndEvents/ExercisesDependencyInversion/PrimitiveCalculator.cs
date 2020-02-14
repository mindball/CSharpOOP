namespace ExercisesDependencyInversion
{
    using Contracts;
    public class PrimitiveCalculator
    {
        ICalculationStrategy newStrategy;
        public PrimitiveCalculator(ICalculationStrategy strategy)
        {
            this.ChangeStrategy(strategy);
        }

        public void ChangeStrategy(ICalculationStrategy strategy)
        {
            this.newStrategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.newStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}
