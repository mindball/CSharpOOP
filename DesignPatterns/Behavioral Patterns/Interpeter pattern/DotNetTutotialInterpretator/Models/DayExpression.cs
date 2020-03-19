using DotNetTutotialInterpretator.Contracts;

namespace DotNetTutotialInterpretator.Models
{
    public class DayExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}
