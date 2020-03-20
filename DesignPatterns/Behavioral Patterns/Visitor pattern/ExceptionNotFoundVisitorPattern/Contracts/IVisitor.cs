using ExceptionNotFoundVisitorPattern.Models;

namespace ExceptionNotFoundVisitorPattern.Contracts
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
