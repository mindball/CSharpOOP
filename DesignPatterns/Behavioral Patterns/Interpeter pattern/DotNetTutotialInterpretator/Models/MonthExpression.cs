using DotNetTutotialInterpretator.Contracts;

namespace DotNetTutotialInterpretator.Models
{
    public class MonthExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
