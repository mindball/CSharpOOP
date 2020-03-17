using DotnetLeadRealExample.Contracts;
using DotnetLeadRealExample.Models;
using System;

namespace DotnetLeadRealExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IColleague<string> colleagueA = new ConcreteColleague<string>("ColleagueA");
            IColleague<string> colleagueB = new ConcreteColleague<string>("ColleagueB");
            IColleague<string> colleagueC = new ConcreteColleague<string>("ColleagueC");

            IMediator<string> mediator1 = new ConcreteMediator<string>();
            mediator1.Register(colleagueA);
            mediator1.Register(colleagueB);
            mediator1.Register(colleagueC);

            colleagueA.SendMessage(mediator1, "MessageX from ColleagueA");


        }
    }
}
