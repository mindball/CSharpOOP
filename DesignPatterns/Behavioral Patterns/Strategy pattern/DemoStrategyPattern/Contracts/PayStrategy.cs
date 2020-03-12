namespace DemoStrategyPattern.Contracts
{
    public interface IPayStrategy
    {
        bool Pay(int paymentAmount);
        void CollectPaymentDetails();
    }
}
