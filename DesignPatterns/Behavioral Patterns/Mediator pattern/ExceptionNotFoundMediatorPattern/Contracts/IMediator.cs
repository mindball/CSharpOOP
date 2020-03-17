using ExceptionNotFoundMediatorPattern.Models;

namespace ExceptionNotFoundMediatorPattern.Contracts
{
    public interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}
