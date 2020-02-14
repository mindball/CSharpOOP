namespace LoggerMart2018.Models.Contracts
{
    public interface IAppender : ILevelError
    {
        ILayout Layout { get; }        
        void AppendMessage(IError error);
    }
}
