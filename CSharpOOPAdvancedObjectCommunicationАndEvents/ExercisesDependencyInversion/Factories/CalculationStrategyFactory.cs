namespace ExercisesDependencyInversion.Factories
{
    using Contracts;
    using CalculationStrategy;
    public class CalculationStrategyFactory
    {
        public ICalculationStrategy CreateStrategy(char @operator)
        {
            switch(@operator)
            {
                case '/':
                    return new DivisionStrategy();
                    break;
                case '*':
                    return new MultiplicationStrategy();
                    break;
                case '-':
                    return new SubtractionStrategy();
                    break;
                default:
                    return new AdditionStrategy();
            }
        }
    }
}
