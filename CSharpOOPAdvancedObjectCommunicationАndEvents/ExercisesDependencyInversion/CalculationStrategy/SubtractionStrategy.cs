namespace ExercisesDependencyInversion.CalculationStrategy
{
    using Contracts;
	public class SubtractionStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
