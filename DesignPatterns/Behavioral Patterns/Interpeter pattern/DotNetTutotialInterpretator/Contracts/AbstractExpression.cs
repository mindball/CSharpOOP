using DotNetTutotialInterpretator.Models;

namespace DotNetTutotialInterpretator.Contracts
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}
