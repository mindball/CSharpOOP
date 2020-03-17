using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetLeadRealExample.Contracts
{
    public interface IColleague<T>
    {
        void SendMessage(IMediator<T> mediator, T message);

        void ReceiveMessage(T message);
    }
}
