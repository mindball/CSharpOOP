using DotNetTutotialInterpretator.Contracts;

namespace DotNetTutotialInterpretator.Models
{
    public class SeparatorExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
