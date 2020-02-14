namespace LoggerMart2018.Models.Contracts
{
    public interface ILogFile
    {
        int Size { get; }
        void WriteFile();
        string Path { get; }
    }
}
