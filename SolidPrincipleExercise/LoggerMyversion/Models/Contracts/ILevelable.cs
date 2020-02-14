using LoggerMyversion.Models.Enums;

namespace LoggerMyversion.Models.Contracts
{
    public interface ILevelable
    {
        LevelError LevelError { get; }
    }
}
