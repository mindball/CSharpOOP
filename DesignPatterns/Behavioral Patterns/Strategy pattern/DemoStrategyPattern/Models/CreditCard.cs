namespace DemoStrategyPattern.Models
{
    public class CreditCard
    {
        private int amount;
        private string number;
        private string date;
        private string cvv;

        public CreditCard(string number, string date, string cvv)
        {
            this.amount = 100_000;
            this.number = number;
            this.date = date;
            this.cvv = cvv;
        }

        public void SetAmount(int amount)
        {
            this.amount = amount;
        }

        public int GetAmount()
        {
            return this.amount;
        }
    }
}
