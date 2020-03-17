using DotnetLeadRealExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetLeadRealExample.Models
{
    public class ConcreteMediator<T> : IMediator<T>
    {
        private List<IColleague<T>> colleagueList = new List<IColleague<T>>();

        public List<IColleague<T>> ColleagueList => this.colleagueList;

        public void DistributeMessage(IColleague<T> sender, T message)
        {
            foreach (var colleague in colleagueList)
            {
                if (colleague != sender)
                    colleague.ReceiveMessage(message);
            }
        }

        public void Register(IColleague<T> colleague)
        {
            this.colleagueList.Add(colleague);
        }
    }
}
