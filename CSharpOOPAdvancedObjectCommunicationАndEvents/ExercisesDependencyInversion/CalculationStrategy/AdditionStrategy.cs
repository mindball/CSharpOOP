﻿namespace ExercisesDependencyInversion.CalculationStrategy
{
    using Contracts;
	public class AdditionStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
