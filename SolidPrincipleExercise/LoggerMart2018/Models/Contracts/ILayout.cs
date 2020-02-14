namespace LoggerMart2018.Models.Contracts
{
    public interface ILayout
    {
        string FormatError(IError error);
    }
}