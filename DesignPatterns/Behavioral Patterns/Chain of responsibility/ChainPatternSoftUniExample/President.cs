using System;

namespace ChainPatternSoftUniExample
{
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine(
                    "{0} approved request #{1}",
                    this.GetType().Name,
                    purchase.Number);
            }
            else
            {
                Console.WriteLine(
                    "Request #{0} requires an execute meeting!",
                    purchase.Number);
            }
        }
    
    }
}
