using ExceptionNotFoundMediatorPattern.Contracts;

namespace ExceptionNotFoundMediatorPattern.Models
{
    public abstract class ConcessionStand
    {
        protected IMediator mediator;

        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
