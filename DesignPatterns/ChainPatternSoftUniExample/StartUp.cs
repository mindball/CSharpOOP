using System;

namespace ChainPatternSoftUniExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Approver employee = new Employee();
            Approver teamLead = new TeamLead();
            Approver vp = new VicePresident();
            Approver ceo = new President();

            employee.SetSuccessor(teamLead);
            teamLead.SetSuccessor(vp);
            vp.SetSuccessor(ceo);


            var purchase = new Purchase(20343, 50.00);
            employee.ProcessRequest(purchase);

            purchase = new Purchase(2034, 350.00);
            employee.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32050.10);
            employee.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122050.10);
            employee.ProcessRequest(purchase);
        }
    }
}
