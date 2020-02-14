using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesDependencyInversion.CalculationStrategy
{
    using Contracts;
    class MultiplicationStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
