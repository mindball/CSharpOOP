namespace DotNetTrickExampleOfBridgePattern.Contracts
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
