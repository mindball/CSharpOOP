namespace DotNetTrickExampleOfBridgePattern.Models
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body); 
        }
    }
}
