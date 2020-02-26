using CodeprojectExample.Contracts;
using System;

namespace CodeprojectExample.Models
{
    public class OrderVerificationManager : IOrderVerify
    {
        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine(string.Format("The product can be shipped to the pincode {0}.", pincode));
            return true;
        }
    }
}
