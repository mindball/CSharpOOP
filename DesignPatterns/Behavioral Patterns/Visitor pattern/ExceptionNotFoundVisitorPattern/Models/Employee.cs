using ExceptionNotFoundVisitorPattern.Contracts;

namespace ExceptionNotFoundVisitorPattern.Models
{
    /// <summary>
    /// The ConcreteElement class, which implements 
    /// all operations defined by the Element.
    /// </summary>
    public class Employee : Element
    {
        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
