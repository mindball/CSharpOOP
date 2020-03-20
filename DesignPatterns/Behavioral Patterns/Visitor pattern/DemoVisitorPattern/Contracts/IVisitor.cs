using DemoVisitorPattern.Models;

namespace DemoVisitorPattern.Contracts
{
    public interface IVisitor  
    {
        string VisitDot(Dot dot);
        
        string VisitCircle(Circle circle);
        
        string VisitRectangle(Rectangle rectangle);
        
        string VisitCompoundGraphic(CompoundShape cg);
    }
}
