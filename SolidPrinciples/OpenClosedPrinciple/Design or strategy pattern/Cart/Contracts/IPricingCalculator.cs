namespace OpenClosedPrinciple.Cart.Contracts
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
