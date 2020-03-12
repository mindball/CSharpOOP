using DemoStrategyPattern.Contracts;
using System;

namespace DemoStrategyPattern.Models
{
    public class PayByCreditCard : IPayStrategy
    {
        private CreditCard card;
        public void CollectPaymentDetails()
        {
            try
            {
                Console.Write("Enter the card number: ");
                string number = Console.ReadLine();
                Console.Write("Enter the card expiration date 'mm/yy': ");
                string date = Console.ReadLine();
                Console.Write("Enter the CVV code: ");
                string cvv = Console.ReadLine();
                card = new CreditCard(number, date, cvv);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool Pay(int paymentAmount)
        {
            if (CardIsPresent())
            {
                Console.WriteLine("Paying " + paymentAmount + " using Credit Card.");
                this.card.SetAmount(this.card.GetAmount() - paymentAmount);
                return true;
            }
            else
                return false;
        }

        private bool CardIsPresent()
        {
            return this.card != null;
        }
    }
}
