namespace ExercisesDependencyInversion.CalculationStrategy
{
    using Contracts;
    using System;

    public class DivisionStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {

            if (secondOperand != 0)
                return firstOperand / secondOperand;
            else
                throw new DivideByZeroException();
        }
    }
}
