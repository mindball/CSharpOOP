using ExceptionNotFoundMediatorPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionNotFoundMediatorPattern.Models
{
    class ConcessionsMediator : IMediator
    {
        private NorthConcessionStand northConcessions;
        private SouthConcessionStand southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { this.northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { this.southConcessions = value; }
        }

        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == this.northConcessions)
            {
                this.southConcessions.Notify(message);
            }
            else
            {
                this.northConcessions.Notify(message);
            }
        }
    }
}
