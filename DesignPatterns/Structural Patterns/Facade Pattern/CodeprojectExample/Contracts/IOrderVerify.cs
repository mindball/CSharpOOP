namespace CodeprojectExample.Contracts
{
    public interface IOrderVerify
    {
        bool VerifyShippingAddress(int pincode);
    }
}
